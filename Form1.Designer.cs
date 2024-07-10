﻿namespace RoboUI2
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
        private void InitializeComponent() {
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
            targets = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            dminus = new Button();
            dplus = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            cminus = new Button();
            cplus = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            bminus = new Button();
            bplus = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            aminus = new Button();
            aplus = new Button();
            resetBox.SuspendLayout();
            preloadBox.SuspendLayout();
            playcontrolBox.SuspendLayout();
            resultsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)points2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)points1).BeginInit();
            CCBox.SuspendLayout();
            targets.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            preload_send.Click += Preload_send_Click;
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
            playcontrolBox.Controls.Add(play_send);
            playcontrolBox.Location = new Point(12, 176);
            playcontrolBox.Name = "playcontrolBox";
            playcontrolBox.Size = new Size(170, 74);
            playcontrolBox.TabIndex = 2;
            playcontrolBox.TabStop = false;
            playcontrolBox.Text = "Playcontrol";
            // 
            // interrupt_send
            // 
            interrupt_send.Location = new Point(87, 22);
            interrupt_send.Name = "interrupt_send";
            interrupt_send.Size = new Size(75, 46);
            interrupt_send.TabIndex = 2;
            interrupt_send.Text = "Interrupt";
            interrupt_send.UseVisualStyleBackColor = true;
            interrupt_send.Click += interrupt_send_Click;
            // 
            // play_send
            // 
            play_send.Location = new Point(6, 22);
            play_send.Name = "play_send";
            play_send.Size = new Size(75, 46);
            play_send.TabIndex = 0;
            play_send.Text = "Play";
            play_send.UseVisualStyleBackColor = true;
            play_send.Click += play_send_Click;
            // 
            // resultsBox
            // 
            resultsBox.Controls.Add(points_send);
            resultsBox.Controls.Add(points2);
            resultsBox.Controls.Add(points1);
            resultsBox.Location = new Point(188, 194);
            resultsBox.Name = "resultsBox";
            resultsBox.Size = new Size(150, 89);
            resultsBox.TabIndex = 3;
            resultsBox.TabStop = false;
            resultsBox.Text = "Results";
            // 
            // points_send
            // 
            points_send.Location = new Point(51, 50);
            points_send.Name = "points_send";
            points_send.Size = new Size(90, 33);
            points_send.TabIndex = 3;
            points_send.Text = "Send";
            points_send.UseVisualStyleBackColor = true;
            points_send.Click += points_send_Click;
            // 
            // points2
            // 
            points2.Location = new Point(77, 22);
            points2.Name = "points2";
            points2.Size = new Size(64, 23);
            points2.TabIndex = 1;
            // 
            // points1
            // 
            points1.Location = new Point(6, 22);
            points1.Name = "points1";
            points1.Size = new Size(65, 23);
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
            label1.Location = new Point(316, 405);
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
            // targets
            // 
            targets.Controls.Add(tableLayoutPanel1);
            targets.Location = new Point(12, 289);
            targets.Name = "targets";
            targets.Size = new Size(307, 205);
            targets.TabIndex = 9;
            targets.TabStop = false;
            targets.Text = "Cíle";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Location = new Point(6, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(292, 177);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(dminus, 1, 0);
            tableLayoutPanel5.Controls.Add(dplus, 0, 0);
            tableLayoutPanel5.Location = new Point(149, 92);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(139, 81);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // dminus
            // 
            dminus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dminus.AutoSize = true;
            dminus.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            dminus.Location = new Point(72, 3);
            dminus.Name = "dminus";
            dminus.Size = new Size(64, 75);
            dminus.TabIndex = 4;
            dminus.Text = "-";
            dminus.UseVisualStyleBackColor = true;
            dminus.Click += dminus_Click;
            // 
            // dplus
            // 
            dplus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dplus.AutoSize = true;
            dplus.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            dplus.Location = new Point(3, 3);
            dplus.Name = "dplus";
            dplus.Size = new Size(63, 75);
            dplus.TabIndex = 2;
            dplus.Text = "+";
            dplus.UseVisualStyleBackColor = true;
            dplus.Click += dplus_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(cminus, 0, 0);
            tableLayoutPanel4.Controls.Add(cplus, 0, 0);
            tableLayoutPanel4.Location = new Point(149, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(139, 81);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // cminus
            // 
            cminus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cminus.AutoSize = true;
            cminus.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            cminus.Location = new Point(72, 3);
            cminus.Name = "cminus";
            cminus.Size = new Size(64, 75);
            cminus.TabIndex = 4;
            cminus.Text = "-";
            cminus.UseVisualStyleBackColor = true;
            cminus.Click += cminus_Click;
            // 
            // cplus
            // 
            cplus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cplus.AutoSize = true;
            cplus.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            cplus.Location = new Point(3, 3);
            cplus.Name = "cplus";
            cplus.Size = new Size(63, 75);
            cplus.TabIndex = 1;
            cplus.Text = "+";
            cplus.UseVisualStyleBackColor = true;
            cplus.Click += cplus_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(bminus, 1, 0);
            tableLayoutPanel3.Controls.Add(bplus, 0, 0);
            tableLayoutPanel3.Location = new Point(4, 92);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(138, 81);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // bminus
            // 
            bminus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bminus.AutoSize = true;
            bminus.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            bminus.Location = new Point(72, 3);
            bminus.Name = "bminus";
            bminus.Size = new Size(63, 75);
            bminus.TabIndex = 4;
            bminus.Text = "-";
            bminus.UseVisualStyleBackColor = true;
            bminus.Click += bminus_Click;
            // 
            // bplus
            // 
            bplus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bplus.AutoSize = true;
            bplus.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            bplus.Location = new Point(3, 3);
            bplus.Name = "bplus";
            bplus.Size = new Size(63, 75);
            bplus.TabIndex = 1;
            bplus.Text = "+";
            bplus.UseVisualStyleBackColor = true;
            bplus.Click += bplus_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(aminus, 1, 0);
            tableLayoutPanel2.Controls.Add(aplus, 0, 0);
            tableLayoutPanel2.Location = new Point(4, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(138, 81);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // aminus
            // 
            aminus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            aminus.AutoSize = true;
            aminus.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            aminus.Location = new Point(72, 3);
            aminus.Name = "aminus";
            aminus.Size = new Size(63, 75);
            aminus.TabIndex = 3;
            aminus.Text = "-";
            aminus.UseVisualStyleBackColor = true;
            aminus.Click += aminus_Click;
            // 
            // aplus
            // 
            aplus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            aplus.AutoSize = true;
            aplus.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            aplus.Location = new Point(3, 3);
            aplus.Name = "aplus";
            aplus.Size = new Size(63, 75);
            aplus.TabIndex = 0;
            aplus.Text = "+";
            aplus.UseVisualStyleBackColor = true;
            aplus.Click += aplus_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 506);
            Controls.Add(targets);
            Controls.Add(modechg_send);
            Controls.Add(dropMode);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(targetURL);
            Controls.Add(teams);
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
            targets.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
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
        private GroupBox targets;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel5;
        private Button dminus;
        private Button dplus;
        private TableLayoutPanel tableLayoutPanel4;
        private Button cminus;
        private Button cplus;
        private TableLayoutPanel tableLayoutPanel3;
        private Button bminus;
        private Button bplus;
        private TableLayoutPanel tableLayoutPanel2;
        private Button aminus;
        private Button aplus;
    }
}
