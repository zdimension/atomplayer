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

namespace AtomPlayer
{
    public partial class MainWindow : Form
    {
        string args = "";
        string currentFile = "";
        bool fullScreen = false;
        public MainWindow()
        {
            InitializeComponent();

            this.MainMenu.Renderer = new Renderers.DarkMenuStripRenderer();

            //this.pnlVideo.MouseWheel += new MouseEventHandler(pnlVideo_MouseWheel);
            foreach (Control c in this.Controls)
            {
                c.MouseWheel += pnlVideo_MouseWheel;
            }

            this.btnPlayPause.Image = AtomPlayer.Properties.Resources.play;
        }
  Process p = new Process();
        private void MainWindow_Load(object sender, EventArgs e)
        {
          
            p.StartInfo.FileName = "mplayer\\mplayer2.exe";

            p.StartInfo.UseShellExecute = false;
            
            p.StartInfo.RedirectStandardInput = true;
            args = "-nofs -noquiet -identify -slave ";
            args += "-nomouseinput -sub-fuzziness 1 ";

            //-wid will tell MPlayer to show output inside our panel
            args += " -vo direct3d, -ao dsound  -wid ";
            int id = (int)pnlVideo.Handle;
            args += id;

            //currentFile = @"C:\Users\Tom2\Videos\intro-video.avi";
            LoadFile(@"C:\Users\Tom2\Videos\intro-video.avi");
        }

        string currentbtn = "play";



       

        private void trackVolume_ValueChanged(object sender, EventArgs e)
        {
            
        }

        public void LoadFile(string filePath)
        {
            currentFile = filePath;
            
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
    }
}
