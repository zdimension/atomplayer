namespace AtomPlayer
{
    partial class FullScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblVolumeVideo = new System.Windows.Forms.Label();
            this.tmrVolume = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblVolumeVideo
            // 
            this.lblVolumeVideo.AutoSize = true;
            this.lblVolumeVideo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumeVideo.ForeColor = System.Drawing.Color.White;
            this.lblVolumeVideo.Location = new System.Drawing.Point(10, 10);
            this.lblVolumeVideo.Name = "lblVolumeVideo";
            this.lblVolumeVideo.Size = new System.Drawing.Size(151, 32);
            this.lblVolumeVideo.TabIndex = 1;
            this.lblVolumeVideo.Text = "Volume : X%";
            this.lblVolumeVideo.Visible = false;
            // 
            // tmrVolume
            // 
            this.tmrVolume.Interval = 1000;
            this.tmrVolume.Tick += new System.EventHandler(this.tmrVolume_Tick);
            // 
            // FullScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.lblVolumeVideo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FullScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AtomPlayer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblVolumeVideo;
        private System.Windows.Forms.Timer tmrVolume;
    }
}