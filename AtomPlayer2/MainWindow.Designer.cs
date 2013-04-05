namespace AtomPlayer
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playPauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.slowDownSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speedUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stretchToFillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stretchToWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stretchToWidthToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dontStretchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subtitlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.trackVolume = new MediaSlider.MediaSlider();
            this.trackTime = new MediaSlider.MediaSlider();
            this.pnlVideo = new System.Windows.Forms.Panel();
            this.lblVolumeVideo = new System.Windows.Forms.Label();
            this.tmrVolume = new System.Windows.Forms.Timer(this.components);
            this.tmrVideo = new System.Windows.Forms.Timer(this.components);
            this.MainMenu.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.pnlVideo.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mediaToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.subtitlesToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(823, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromFileToolStripMenuItem,
            this.fromURLToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // fromFileToolStripMenuItem
            // 
            this.fromFileToolStripMenuItem.Name = "fromFileToolStripMenuItem";
            this.fromFileToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.fromFileToolStripMenuItem.Text = "From file...";
            // 
            // fromURLToolStripMenuItem
            // 
            this.fromURLToolStripMenuItem.Name = "fromURLToolStripMenuItem";
            this.fromURLToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.fromURLToolStripMenuItem.Text = "From URL...";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // mediaToolStripMenuItem
            // 
            this.mediaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playPauseToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.toolStripSeparator1,
            this.slowDownSpeedToolStripMenuItem,
            this.speedUpToolStripMenuItem});
            this.mediaToolStripMenuItem.Name = "mediaToolStripMenuItem";
            this.mediaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.mediaToolStripMenuItem.Text = "Media";
            // 
            // playPauseToolStripMenuItem
            // 
            this.playPauseToolStripMenuItem.Name = "playPauseToolStripMenuItem";
            this.playPauseToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.playPauseToolStripMenuItem.Text = "Play/Pause";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
            // 
            // slowDownSpeedToolStripMenuItem
            // 
            this.slowDownSpeedToolStripMenuItem.Name = "slowDownSpeedToolStripMenuItem";
            this.slowDownSpeedToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.slowDownSpeedToolStripMenuItem.Text = "Slower";
            // 
            // speedUpToolStripMenuItem
            // 
            this.speedUpToolStripMenuItem.Name = "speedUpToolStripMenuItem";
            this.speedUpToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.speedUpToolStripMenuItem.Text = "Faster";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stretchToFillToolStripMenuItem,
            this.stretchToWidthToolStripMenuItem,
            this.stretchToWidthToolStripMenuItem1,
            this.dontStretchToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // stretchToFillToolStripMenuItem
            // 
            this.stretchToFillToolStripMenuItem.Name = "stretchToFillToolStripMenuItem";
            this.stretchToFillToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.stretchToFillToolStripMenuItem.Text = "Stretch to fill";
            // 
            // stretchToWidthToolStripMenuItem
            // 
            this.stretchToWidthToolStripMenuItem.Name = "stretchToWidthToolStripMenuItem";
            this.stretchToWidthToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.stretchToWidthToolStripMenuItem.Text = "Stretch to width";
            // 
            // stretchToWidthToolStripMenuItem1
            // 
            this.stretchToWidthToolStripMenuItem1.Name = "stretchToWidthToolStripMenuItem1";
            this.stretchToWidthToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.stretchToWidthToolStripMenuItem1.Text = "Stretch to width";
            // 
            // dontStretchToolStripMenuItem
            // 
            this.dontStretchToolStripMenuItem.Name = "dontStretchToolStripMenuItem";
            this.dontStretchToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.dontStretchToolStripMenuItem.Text = "Don\'t stretch";
            // 
            // subtitlesToolStripMenuItem
            // 
            this.subtitlesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFromFileToolStripMenuItem,
            this.toolStripSeparator2,
            this.showToolStripMenuItem});
            this.subtitlesToolStripMenuItem.Name = "subtitlesToolStripMenuItem";
            this.subtitlesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.subtitlesToolStripMenuItem.Text = "Subtitles";
            // 
            // loadFromFileToolStripMenuItem
            // 
            this.loadFromFileToolStripMenuItem.Name = "loadFromFileToolStripMenuItem";
            this.loadFromFileToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.loadFromFileToolStripMenuItem.Text = "Load from file...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(154, 6);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Checked = true;
            this.showToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showToolStripMenuItem.Enabled = false;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.showToolStripMenuItem.Text = "Show";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlControl.Controls.Add(this.btnPlayPause);
            this.pnlControl.Controls.Add(this.trackVolume);
            this.pnlControl.Controls.Add(this.trackTime);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControl.Location = new System.Drawing.Point(0, 407);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(823, 100);
            this.pnlControl.TabIndex = 1;
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayPause.FlatAppearance.BorderSize = 0;
            this.btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPause.ForeColor = System.Drawing.Color.White;
            this.btnPlayPause.Image = global::AtomPlayer.Properties.Resources.play;
            this.btnPlayPause.Location = new System.Drawing.Point(12, 53);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(32, 32);
            this.btnPlayPause.TabIndex = 2;
            this.btnPlayPause.UseVisualStyleBackColor = false;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            this.btnPlayPause.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPlayPause_MouseDown);
            this.btnPlayPause.MouseEnter += new System.EventHandler(this.btnPlayPause_MouseEnter);
            this.btnPlayPause.MouseLeave += new System.EventHandler(this.btnPlayPause_MouseLeave);
            // 
            // trackVolume
            // 
            this.trackVolume.Animated = false;
            this.trackVolume.AnimationSize = 0.2F;
            this.trackVolume.AnimationSpeed = MediaSlider.MediaSlider.AnimateSpeed.Normal;
            this.trackVolume.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.trackVolume.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.trackVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.trackVolume.BackGroundImage = null;
            this.trackVolume.ButtonAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trackVolume.ButtonBorderColor = System.Drawing.Color.Black;
            this.trackVolume.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.trackVolume.ButtonCornerRadius = ((uint)(4u));
            this.trackVolume.ButtonSize = new System.Drawing.Size(12, 12);
            this.trackVolume.ButtonStyle = MediaSlider.MediaSlider.ButtonType.Round;
            this.trackVolume.ContextMenuStrip = null;
            this.trackVolume.LargeChange = 2;
            this.trackVolume.Location = new System.Drawing.Point(668, 45);
            this.trackVolume.Margin = new System.Windows.Forms.Padding(0);
            this.trackVolume.Maximum = 100;
            this.trackVolume.Minimum = 0;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.trackVolume.ShowButtonOnHover = false;
            this.trackVolume.Size = new System.Drawing.Size(150, 51);
            this.trackVolume.SliderFlyOut = MediaSlider.MediaSlider.FlyOutStyle.None;
            this.trackVolume.SmallChange = 1;
            this.trackVolume.SmoothScrolling = false;
            this.trackVolume.TabIndex = 1;
            this.trackVolume.TickColor = System.Drawing.Color.DarkGray;
            this.trackVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackVolume.TickType = MediaSlider.MediaSlider.TickMode.Standard;
            this.trackVolume.TrackBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.trackVolume.TrackDepth = 4;
            this.trackVolume.TrackFillColor = System.Drawing.Color.Transparent;
            this.trackVolume.TrackProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(101)))), ((int)(((byte)(188)))));
            this.trackVolume.TrackShadow = false;
            this.trackVolume.TrackShadowColor = System.Drawing.Color.DarkGray;
            this.trackVolume.TrackStyle = MediaSlider.MediaSlider.TrackType.Value;
            this.trackVolume.Value = 50;
            this.trackVolume.ValueChanged += new MediaSlider.MediaSlider.ValueChangedDelegate(this.trackVolume_ValueChanged);
            // 
            // trackTime
            // 
            this.trackTime.Animated = false;
            this.trackTime.AnimationSize = 0.2F;
            this.trackTime.AnimationSpeed = MediaSlider.MediaSlider.AnimateSpeed.Normal;
            this.trackTime.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.trackTime.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.trackTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.trackTime.BackGroundImage = null;
            this.trackTime.ButtonAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trackTime.ButtonBorderColor = System.Drawing.Color.Black;
            this.trackTime.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.trackTime.ButtonCornerRadius = ((uint)(4u));
            this.trackTime.ButtonSize = new System.Drawing.Size(12, 12);
            this.trackTime.ButtonStyle = MediaSlider.MediaSlider.ButtonType.Round;
            this.trackTime.ContextMenuStrip = null;
            this.trackTime.LargeChange = 2;
            this.trackTime.Location = new System.Drawing.Point(4, 4);
            this.trackTime.Margin = new System.Windows.Forms.Padding(0);
            this.trackTime.Maximum = 10;
            this.trackTime.Minimum = 0;
            this.trackTime.Name = "trackTime";
            this.trackTime.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.trackTime.ShowButtonOnHover = false;
            this.trackTime.Size = new System.Drawing.Size(815, 26);
            this.trackTime.SliderFlyOut = MediaSlider.MediaSlider.FlyOutStyle.None;
            this.trackTime.SmallChange = 1;
            this.trackTime.SmoothScrolling = false;
            this.trackTime.TabIndex = 0;
            this.trackTime.TickColor = System.Drawing.Color.DarkGray;
            this.trackTime.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackTime.TickType = MediaSlider.MediaSlider.TickMode.Standard;
            this.trackTime.TrackBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.trackTime.TrackDepth = 4;
            this.trackTime.TrackFillColor = System.Drawing.Color.Transparent;
            this.trackTime.TrackProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(101)))), ((int)(((byte)(188)))));
            this.trackTime.TrackShadow = false;
            this.trackTime.TrackShadowColor = System.Drawing.Color.DarkGray;
            this.trackTime.TrackStyle = MediaSlider.MediaSlider.TrackType.Value;
            this.trackTime.Value = 0;
            // 
            // pnlVideo
            // 
            this.pnlVideo.Controls.Add(this.lblVolumeVideo);
            this.pnlVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVideo.Location = new System.Drawing.Point(0, 24);
            this.pnlVideo.Name = "pnlVideo";
            this.pnlVideo.Size = new System.Drawing.Size(823, 383);
            this.pnlVideo.TabIndex = 2;
            this.pnlVideo.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pnlVideo_Scroll);
            this.pnlVideo.DoubleClick += new System.EventHandler(this.pnlVideo_DoubleClick);
            // 
            // lblVolumeVideo
            // 
            this.lblVolumeVideo.AutoSize = true;
            this.lblVolumeVideo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumeVideo.ForeColor = System.Drawing.Color.White;
            this.lblVolumeVideo.Location = new System.Drawing.Point(10, 10);
            this.lblVolumeVideo.Name = "lblVolumeVideo";
            this.lblVolumeVideo.Size = new System.Drawing.Size(151, 32);
            this.lblVolumeVideo.TabIndex = 0;
            this.lblVolumeVideo.Text = "Volume : X%";
            this.lblVolumeVideo.Visible = false;
            // 
            // tmrVolume
            // 
            this.tmrVolume.Interval = 1000;
            this.tmrVolume.Tick += new System.EventHandler(this.tmrVolume_Tick);
            // 
            // tmrVideo
            // 
            this.tmrVideo.Interval = 1000;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(823, 507);
            this.Controls.Add(this.pnlVideo);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.MainMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            this.pnlVideo.ResumeLayout(false);
            this.pnlVideo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subtitlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playPauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem slowDownSpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speedUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stretchToFillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stretchToWidthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stretchToWidthToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dontStretchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Panel pnlVideo;
        private MediaSlider.MediaSlider trackTime;
        internal System.Windows.Forms.Button btnPlayPause;
        private MediaSlider.MediaSlider trackVolume;
        private System.Windows.Forms.Label lblVolumeVideo;
        private System.Windows.Forms.Timer tmrVolume;
        private System.Windows.Forms.Timer tmrVideo;
    }
}

