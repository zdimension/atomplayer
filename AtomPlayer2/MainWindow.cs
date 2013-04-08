using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;
using System.Threading;

using LibMPlayerCommon;
using System.IO;

namespace AtomPlayer
{
    public partial class MainWindow : Form
    {
        public MPlayer player;

        string args = "";
        string currentFile = "";
        bool fullScreen = false;
        public MainWindow()
        {
            InitializeComponent();

            player = new MPlayer(pnlVideo.Handle.ToInt32(), MplayerBackends.Direct3D, Path.Combine(Application.StartupPath, "mplayer\\mplayer2.exe"));

            this.MainMenu.Renderer = new Renderers.DarkMenuStripRenderer();

            //this.pnlVideo.MouseWheel += new MouseEventHandler(pnlVideo_MouseWheel);
            foreach (Control c in this.Controls)
            {
                c.MouseWheel += pnlVideo_MouseWheel;
                c.KeyDown += MainWindow_KeyDown;
            }

            this.btnPlayPause.Image = AtomPlayer.Properties.Resources.play;

            player.CurrentPosition += player_CurrentPosition;
            player.VideoExited += player_VideoExited;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
        
            //currentFile = @"C:\Users\Tom2\Videos\intro-video.avi";
            //LoadFile(@"C:\Users\Tom2\Videos\intro-video.avi");
        }

        string currentbtn = "play";


        private void player_CurrentPosition(object sender, EventArgs e)
        {
            trackTime.Value = player.GetCurrentPosition();
            TimeSpan t = TimeSpan.FromSeconds(player.GetCurrentPosition());

            string answer = string.Format("{0:D2}:{1:D2}:{2:D2}",
                            t.Hours,
                            t.Minutes,
                            t.Seconds);
            lblTime.Text = answer;
        }

        private void player_VideoExited(object sender, EventArgs e)
        {
        }
       

        private void trackVolume_ValueChanged(object sender, EventArgs e)
        {
            player.Volume(trackVolume.Value);
            
        }

        public void LoadFile(string filePath)
        {
            currentFile = filePath;
            player.Play(currentFile);
            //player.LoadFile(currentFile);
            trackTime.Maximum = player.CurrentPlayingFileLength();
            btnPlayPause.Enabled = true;
            currentbtn = "pause";
        }

        private void pnlVideo_Scroll(object sender, ScrollEventArgs e)
        {
            trackVolume.Value += 2;
        }

        private void pnlVideo_MouseWheel(object sender, MouseEventArgs e)
        {
            
            if (e.Delta > 0)
            {
                trackVolume.Value += 2;

            }
            else
            {
                trackVolume.Value -= 2;
            }
            /*lblVolumeVideo.BringToFront();
            lblVolumeVideo.Visible = true;
            lblVolumeVideo.Text = "Volume : " + trackVolume.Value + "%";
            fsc.lblVolumeVideo.Text = "Volume : " + trackVolume.Value + "%";
            tmrVolume.Enabled = true;
            tmrVolume.Start();
            lblVolumeVideo.ForeColor = Color.FromArgb(255, lblVolumeVideo.ForeColor);
            lblVolumeVideo.Visible = false;*/
        }

        private void pnlVideo_DoubleClick(object sender, EventArgs e)
        {
            switchFullScreen(!fullScreen);
        }
FullScreen fsc = new FullScreen();
        public void switchFullScreen(bool full)
        {
            if (full)
            {
                

                this.Controls.Remove(pnlVideo);
                fsc.Controls.Add(pnlVideo);

                fsc.Show();
                this.Visible = false;

                fullScreen = full;
            }
            else
            {
                fsc.Controls.Remove(pnlVideo);
                this.Controls.Add(pnlVideo);

                fsc.Hide();
                this.Visible = true;

                fullScreen = full;
            }
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            player.Pause();
            if (player.CurrentStatus == MediaStatus.Playing)
            {
                currentbtn = "play";
            }
            else if (player.CurrentStatus == MediaStatus.Paused)
            {
                currentbtn = "pause";
            }
            else
            {
                currentbtn = "play";
                btnPlayPause.Enabled = false;
            }
        }






        int speed = 1000;


        int vlm = 0;
        private void tmrVolume_Tick(object sender, EventArgs e)
        {
            vlm++;
            bool g = false;
            if (vlm == 2)
            {
                while (!g)
                {
                    if (lblVolumeVideo.ForeColor.A == 0)
                    {
                        g = true;
                        continue;
                    }
                    lblVolumeVideo.ForeColor = Color.FromArgb(lblVolumeVideo.ForeColor.A - 1, lblVolumeVideo.ForeColor);
                    Thread.Sleep(50);
                }
            }
            if (g)
            {
                tmrVolume.Enabled = false;
                tmrVolume.Stop();
            }
        }

        private void btnPlayPause_MouseEnter(object sender, EventArgs e)
        {
            if (currentbtn == "play")
            {
                btnPlayPause.Image = AtomPlayer.Properties.Resources.playhover;
            }
            else
            {
                btnPlayPause.Image = AtomPlayer.Properties.Resources.pausehover;
            }
        }

        private void btnPlayPause_MouseLeave(object sender, EventArgs e)
        {
            if (currentbtn == "play")
            {
                btnPlayPause.Image = AtomPlayer.Properties.Resources.play;
            }
            else
            {
                btnPlayPause.Image = AtomPlayer.Properties.Resources.pause;
            }
        }

        private void btnPlayPause_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentbtn == "play")
            {
                btnPlayPause.Image = AtomPlayer.Properties.Resources.playdown;
            }
            else
            {
                btnPlayPause.Image = AtomPlayer.Properties.Resources.pausedown;
            }
        }

        
        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)
            {
                player.Mute();
            }
            else if (e.KeyCode == Keys.Space)
            {
                btnPlayPause_Click(sender, (EventArgs)e);
            }
            else if (e.KeyCode == Keys.Left)
            {
                player.Seek(-10, Seek.Relative);
            }
            else if (e.KeyCode == Keys.Right)
            {
                player.Seek(+10, Seek.Relative);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog(this);
        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Options("general").ShowDialog(this);
        }
    }
}
