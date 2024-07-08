namespace RoboUI2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            resetBox = new GroupBox();
            hreset_lock = new CheckBox();
            sreset = new Button();
            hreset = new Button();
            preloadBox = new GroupBox();
            preload_send = new Button();
            dropteam2 = new ComboBox();
            dropteam1 = new ComboBox();
            playcontrolBox = new GroupBox();
            interrupt_send = new Button();
            start_send = new Button();
            play_send = new Button();
            resultsBox = new GroupBox();
            points_send = new Button();
            points2 = new NumericUpDown();
            points1 = new NumericUpDown();
            CCBox = new GroupBox();
            cc_send = new Button();
            tvPort = new TextBox();
            tvIP = new TextBox();
            streamPort = new TextBox();
            streamIP = new TextBox();
            label1 = new Label();
            teams = new Label();
            targetURL = new TextBox();
            button1 = new Button();
            dropMode = new ComboBox();
            modechg_send = new Button();
            resetBox.SuspendLayout();
            preloadBox.SuspendLayout();
            playcontrolBox.SuspendLayout();
            resultsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)points2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)points1).BeginInit();
            CCBox.SuspendLayout();
            SuspendLayout();
            // 
            // resetBox
            // 
            resetBox.Controls.Add(hreset_lock);
            resetBox.Controls.Add(sreset);
            resetBox.Controls.Add(hreset);
            resetBox.Location = new Point(12, 12);
            resetBox.Name = "resetBox";
            resetBox.Size = new Size(263, 61);
            resetBox.TabIndex = 0;
            resetBox.TabStop = false;
            resetBox.Text = "Reset";
            // 
            // hreset_lock
            // 
            hreset_lock.AutoSize = true;
            hreset_lock.Font = new Font("Segoe UI", 11F);
            hreset_lock.Location = new Point(236, 32);
            hreset_lock.Name = "hreset_lock";
            hreset_lock.Size = new Size(15, 14);
            hreset_lock.TabIndex = 2;
            hreset_lock.UseVisualStyleBackColor = true;
            hreset_lock.CheckedChanged += hreset_lock_CheckedChanged;
            // 
            // sreset
            // 
            sreset.BackColor = Color.FromArgb(255, 128, 128);
            sreset.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            sreset.ForeColor = Color.Black;
            sreset.Location = new Point(124, 22);
            sreset.Name = "sreset";
            sreset.Size = new Size(106, 33);
            sreset.TabIndex = 1;
            sreset.Text = "Reset";
            sreset.UseVisualStyleBackColor = false;
            sreset.Click += sreset_Click;
            // 
            // hreset
            // 
            hreset.BackColor = Color.FromArgb(192, 0, 0);
            hreset.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            hreset.ForeColor = Color.White;
            hreset.Location = new Point(6, 22);
            hreset.Name = "hreset";
            hreset.Size = new Size(112, 33);
            hreset.TabIndex = 0;
            hreset.Text = "Hard reset";
            hreset.UseVisualStyleBackColor = false;
            hreset.Click += hreset_Click;
            // 
            // preloadBox
            // 
            preloadBox.Controls.Add(preload_send);
            preloadBox.Controls.Add(dropteam2);
            preloadBox.Controls.Add(dropteam1);
            preloadBox.Location = new Point(12, 79);
            preloadBox.Name = "preloadBox";
            preloadBox.Size = new Size(285, 91);
            preloadBox.TabIndex = 1;
            preloadBox.TabStop = false;
            preloadBox.Text = "Stream preload";
            // 
            // preload_send
            // 
            preload_send.Location = new Point(188, 51);
            preload_send.Name = "preload_send";
            preload_send.Size = new Size(90, 33);
            preload_send.TabIndex = 2;
            preload_send.Text = "Load";
            preload_send.UseVisualStyleBackColor = true;
            // 
            // dropteam2
            // 
            dropteam2.FormattingEnabled = true;
            dropteam2.Location = new Point(145, 22);
            dropteam2.Name = "dropteam2";
            dropteam2.Size = new Size(133, 23);
            dropteam2.TabIndex = 1;
            // 
            // dropteam1
            // 
            dropteam1.FormattingEnabled = true;
            dropteam1.Location = new Point(6, 22);
            dropteam1.Name = "dropteam1";
            dropteam1.Size = new Size(133, 23);
            dropteam1.TabIndex = 0;
            // 
            // playcontrolBox
            // 
            playcontrolBox.Controls.Add(interrupt_send);
            playcontrolBox.Controls.Add(start_send);
            playcontrolBox.Controls.Add(play_send);
            playcontrolBox.Location = new Point(12, 176);
            playcontrolBox.Name = "playcontrolBox";
            playcontrolBox.Size = new Size(251, 74);
            playcontrolBox.TabIndex = 2;
            playcontrolBox.TabStop = false;
            playcontrolBox.Text = "Playcontrol";
            // 
            // interrupt_send
            // 
            interrupt_send.Location = new Point(168, 22);
            interrupt_send.Name = "interrupt_send";
            interrupt_send.Size = new Size(75, 46);
            interrupt_send.TabIndex = 2;
            interrupt_send.Text = "Interrupt";
            interrupt_send.UseVisualStyleBackColor = true;
            // 
            // start_send
            // 
            start_send.Location = new Point(87, 22);
            start_send.Name = "start_send";
            start_send.Size = new Size(75, 46);
            start_send.TabIndex = 1;
            start_send.Text = "Start";
            start_send.UseVisualStyleBackColor = true;
            // 
            // play_send
            // 
            play_send.Location = new Point(6, 22);
            play_send.Name = "play_send";
            play_send.Size = new Size(75, 46);
            play_send.TabIndex = 0;
            play_send.Text = "Play";
            play_send.UseVisualStyleBackColor = true;
            // 
            // resultsBox
            // 
            resultsBox.Controls.Add(points_send);
            resultsBox.Controls.Add(points2);
            resultsBox.Controls.Add(points1);
            resultsBox.Location = new Point(12, 256);
            resultsBox.Name = "resultsBox";
            resultsBox.Size = new Size(219, 89);
            resultsBox.TabIndex = 3;
            resultsBox.TabStop = false;
            resultsBox.Text = "Results";
            // 
            // points_send
            // 
            points_send.Location = new Point(122, 51);
            points_send.Name = "points_send";
            points_send.Size = new Size(90, 33);
            points_send.TabIndex = 3;
            points_send.Text = "Send";
            points_send.UseVisualStyleBackColor = true;
            // 
            // points2
            // 
            points2.Location = new Point(112, 22);
            points2.Name = "points2";
            points2.Size = new Size(100, 23);
            points2.TabIndex = 1;
            // 
            // points1
            // 
            points1.Location = new Point(6, 22);
            points1.Name = "points1";
            points1.Size = new Size(100, 23);
            points1.TabIndex = 0;
            // 
            // CCBox
            // 
            CCBox.Controls.Add(cc_send);
            CCBox.Controls.Add(tvPort);
            CCBox.Controls.Add(tvIP);
            CCBox.Controls.Add(streamPort);
            CCBox.Controls.Add(streamIP);
            CCBox.Location = new Point(303, 79);
            CCBox.Name = "CCBox";
            CCBox.Size = new Size(274, 112);
            CCBox.TabIndex = 4;
            CCBox.TabStop = false;
            CCBox.Text = "Setup CC";
            // 
            // cc_send
            // 
            cc_send.Location = new Point(204, 80);
            cc_send.Name = "cc_send";
            cc_send.Size = new Size(64, 26);
            cc_send.TabIndex = 5;
            cc_send.Text = "Config";
            cc_send.UseVisualStyleBackColor = true;
            // 
            // tvPort
            // 
            tvPort.Location = new Point(178, 51);
            tvPort.Name = "tvPort";
            tvPort.PlaceholderText = "5250";
            tvPort.Size = new Size(90, 23);
            tvPort.TabIndex = 3;
            // 
            // tvIP
            // 
            tvIP.Location = new Point(6, 51);
            tvIP.Name = "tvIP";
            tvIP.PlaceholderText = "127.0.0.1";
            tvIP.Size = new Size(166, 23);
            tvIP.TabIndex = 2;
            // 
            // streamPort
            // 
            streamPort.Location = new Point(178, 22);
            streamPort.Name = "streamPort";
            streamPort.PlaceholderText = "5250";
            streamPort.Size = new Size(90, 23);
            streamPort.TabIndex = 1;
            // 
            // streamIP
            // 
            streamIP.Location = new Point(6, 22);
            streamIP.Name = "streamIP";
            streamIP.PlaceholderText = "127.0.0.1";
            streamIP.Size = new Size(166, 23);
            streamIP.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            label1.Location = new Point(316, 254);
            label1.Name = "label1";
            label1.Size = new Size(261, 86);
            label1.TabIndex = 5;
            label1.Text = "RoboUI";
            // 
            // teams
            // 
            teams.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            teams.AutoSize = true;
            teams.Font = new Font("Segoe UI", 12F);
            teams.Location = new Point(303, 198);
            teams.Name = "teams";
            teams.Size = new Size(0, 21);
            teams.TabIndex = 6;
            // 
            // targetURL
            // 
            targetURL.Location = new Point(304, 34);
            targetURL.Name = "targetURL";
            targetURL.Size = new Size(192, 23);
            targetURL.TabIndex = 6;
            targetURL.Text = "http://127.0.0.1:7777";
            // 
            // button1
            // 
            button1.Location = new Point(502, 34);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += reset_click;
            // 
            // dropMode
            // 
            dropMode.FormattingEnabled = true;
            dropMode.Location = new Point(456, 200);
            dropMode.Name = "dropMode";
            dropMode.Size = new Size(121, 23);
            dropMode.TabIndex = 8;
            // 
            // modechg_send
            // 
            modechg_send.Font = new Font("Segoe UI", 8F);
            modechg_send.Location = new Point(386, 194);
            modechg_send.Name = "modechg_send";
            modechg_send.Size = new Size(64, 35);
            modechg_send.TabIndex = 6;
            modechg_send.Text = "Change mode";
            modechg_send.UseVisualStyleBackColor = true;
            modechg_send.Click += modechg_send_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 355);
            Controls.Add(modechg_send);
            Controls.Add(dropMode);
            Controls.Add(button1);
            Controls.Add(targetURL);
            Controls.Add(teams);
            Controls.Add(label1);
            Controls.Add(CCBox);
            Controls.Add(resultsBox);
            Controls.Add(playcontrolBox);
            Controls.Add(preloadBox);
            Controls.Add(resetBox);
            Name = "Form1";
            Text = "RoboUI Controller";
            resetBox.ResumeLayout(false);
            resetBox.PerformLayout();
            preloadBox.ResumeLayout(false);
            playcontrolBox.ResumeLayout(false);
            resultsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)points2).EndInit();
            ((System.ComponentModel.ISupportInitialize)points1).EndInit();
            CCBox.ResumeLayout(false);
            CCBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox resetBox;
        private CheckBox hreset_lock;
        private Button sreset;
        private Button hreset;
        private GroupBox preloadBox;
        private Button preload_send;
        private ComboBox dropteam2;
        private ComboBox dropteam1;
        private GroupBox playcontrolBox;
        private Button interrupt_send;
        private Button start_send;
        private Button play_send;
        private GroupBox resultsBox;
        private Button points_send;
        private NumericUpDown points2;
        private NumericUpDown points1;
        private GroupBox CCBox;
        private TextBox tvPort;
        private TextBox tvIP;
        private TextBox streamPort;
        private TextBox streamIP;
        private Label label1;
        private Button cc_send;
        private Label teams;
        private TextBox targetURL;
        private Button button1;
        private Button modechg_send;
        private ComboBox dropMode;
    }
}
