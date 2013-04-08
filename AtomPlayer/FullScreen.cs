using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace AtomPlayer
{
    public partial class FullScreen : Form
    {
        public FullScreen()
        {
            InitializeComponent();
        }
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
    }
}
