namespace GZDML
{
    partial class FormMain
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
            rbHost = new RadioButton();
            rbJoin = new RadioButton();
            labelIPJ = new Label();
            buttonStart = new Button();
            tbIP = new TextBox();
            panelJoin = new Panel();
            panelHost = new Panel();
            cbCrouch = new CheckBox();
            cbJump = new CheckBox();
            cbTeam = new CheckBox();
            cbAltDM = new CheckBox();
            numSkill = new NumericUpDown();
            labelSkill = new Label();
            numMapNo = new NumericUpDown();
            labelMapNo = new Label();
            numPlayers = new NumericUpDown();
            labelPlayers = new Label();
            rbCoop = new RadioButton();
            rbDM = new RadioButton();
            labelMode = new Label();
            panelJoin.SuspendLayout();
            panelHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSkill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMapNo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPlayers).BeginInit();
            SuspendLayout();
            // 
            // rbHost
            // 
            rbHost.AutoSize = true;
            rbHost.Location = new Point(26, 12);
            rbHost.Name = "rbHost";
            rbHost.Size = new Size(83, 19);
            rbHost.TabIndex = 0;
            rbHost.Text = "Host game";
            rbHost.UseVisualStyleBackColor = true;
            rbHost.CheckedChanged += rbHost_CheckedChanged;
            // 
            // rbJoin
            // 
            rbJoin.AutoSize = true;
            rbJoin.Location = new Point(132, 12);
            rbJoin.Name = "rbJoin";
            rbJoin.Size = new Size(79, 19);
            rbJoin.TabIndex = 0;
            rbJoin.Text = "Join game";
            rbJoin.UseVisualStyleBackColor = true;
            rbJoin.CheckedChanged += rbJoin_CheckedChanged;
            // 
            // labelIPJ
            // 
            labelIPJ.AutoSize = true;
            labelIPJ.Location = new Point(69, 7);
            labelIPJ.Name = "labelIPJ";
            labelIPJ.Size = new Size(63, 15);
            labelIPJ.TabIndex = 3;
            labelIPJ.Text = "IP address:";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(76, 301);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 4;
            buttonStart.Text = "Start game!";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // tbIP
            // 
            tbIP.Location = new Point(29, 25);
            tbIP.MaxLength = 15;
            tbIP.Name = "tbIP";
            tbIP.Size = new Size(150, 23);
            tbIP.TabIndex = 5;
            tbIP.TextAlign = HorizontalAlignment.Center;
            // 
            // panelJoin
            // 
            panelJoin.BorderStyle = BorderStyle.FixedSingle;
            panelJoin.Controls.Add(tbIP);
            panelJoin.Controls.Add(labelIPJ);
            panelJoin.Location = new Point(13, 236);
            panelJoin.Name = "panelJoin";
            panelJoin.Size = new Size(209, 58);
            panelJoin.TabIndex = 6;
            // 
            // panelHost
            // 
            panelHost.BorderStyle = BorderStyle.FixedSingle;
            panelHost.Controls.Add(cbCrouch);
            panelHost.Controls.Add(cbJump);
            panelHost.Controls.Add(cbTeam);
            panelHost.Controls.Add(cbAltDM);
            panelHost.Controls.Add(numSkill);
            panelHost.Controls.Add(labelSkill);
            panelHost.Controls.Add(numMapNo);
            panelHost.Controls.Add(labelMapNo);
            panelHost.Controls.Add(numPlayers);
            panelHost.Controls.Add(labelPlayers);
            panelHost.Controls.Add(rbCoop);
            panelHost.Controls.Add(rbDM);
            panelHost.Controls.Add(labelMode);
            panelHost.Location = new Point(13, 39);
            panelHost.Name = "panelHost";
            panelHost.Size = new Size(209, 191);
            panelHost.TabIndex = 7;
            // 
            // cbCrouch
            // 
            cbCrouch.AutoSize = true;
            cbCrouch.Location = new Point(99, 150);
            cbCrouch.Name = "cbCrouch";
            cbCrouch.Size = new Size(96, 19);
            cbCrouch.TabIndex = 16;
            cbCrouch.Text = "Allow crouch";
            cbCrouch.UseVisualStyleBackColor = true;
            // 
            // cbJump
            // 
            cbJump.AutoSize = true;
            cbJump.Location = new Point(12, 150);
            cbJump.Name = "cbJump";
            cbJump.Size = new Size(87, 19);
            cbJump.TabIndex = 15;
            cbJump.Text = "Allow jump";
            cbJump.UseVisualStyleBackColor = true;
            // 
            // cbTeam
            // 
            cbTeam.AutoSize = true;
            cbTeam.Location = new Point(99, 125);
            cbTeam.Name = "cbTeam";
            cbTeam.Size = new Size(79, 19);
            cbTeam.TabIndex = 14;
            cbTeam.Text = "Team play";
            cbTeam.UseVisualStyleBackColor = true;
            // 
            // cbAltDM
            // 
            cbAltDM.AutoSize = true;
            cbAltDM.Location = new Point(12, 125);
            cbAltDM.Name = "cbAltDM";
            cbAltDM.Size = new Size(66, 19);
            cbAltDM.TabIndex = 8;
            cbAltDM.Text = "Alt. DM";
            cbAltDM.UseVisualStyleBackColor = true;
            // 
            // numSkill
            // 
            numSkill.Location = new Point(150, 85);
            numSkill.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numSkill.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSkill.Name = "numSkill";
            numSkill.Size = new Size(45, 23);
            numSkill.TabIndex = 13;
            numSkill.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelSkill
            // 
            labelSkill.AutoSize = true;
            labelSkill.Location = new Point(157, 67);
            labelSkill.Name = "labelSkill";
            labelSkill.Size = new Size(31, 15);
            labelSkill.TabIndex = 12;
            labelSkill.Text = "Skill:";
            // 
            // numMapNo
            // 
            numMapNo.Location = new Point(80, 85);
            numMapNo.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numMapNo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMapNo.Name = "numMapNo";
            numMapNo.Size = new Size(45, 23);
            numMapNo.TabIndex = 11;
            numMapNo.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelMapNo
            // 
            labelMapNo.AutoSize = true;
            labelMapNo.Location = new Point(88, 67);
            labelMapNo.Name = "labelMapNo";
            labelMapNo.Size = new Size(34, 15);
            labelMapNo.TabIndex = 8;
            labelMapNo.Text = "Map:";
            // 
            // numPlayers
            // 
            numPlayers.Location = new Point(12, 85);
            numPlayers.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            numPlayers.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPlayers.Name = "numPlayers";
            numPlayers.Size = new Size(45, 23);
            numPlayers.TabIndex = 10;
            numPlayers.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelPlayers
            // 
            labelPlayers.AutoSize = true;
            labelPlayers.Location = new Point(12, 67);
            labelPlayers.Name = "labelPlayers";
            labelPlayers.Size = new Size(47, 15);
            labelPlayers.TabIndex = 8;
            labelPlayers.Text = "Players:";
            // 
            // rbCoop
            // 
            rbCoop.AutoSize = true;
            rbCoop.Location = new Point(108, 30);
            rbCoop.Name = "rbCoop";
            rbCoop.Size = new Size(89, 19);
            rbCoop.TabIndex = 0;
            rbCoop.TabStop = true;
            rbCoop.Text = "Cooperative";
            rbCoop.UseVisualStyleBackColor = true;
            // 
            // rbDM
            // 
            rbDM.AutoSize = true;
            rbDM.Location = new Point(12, 30);
            rbDM.Name = "rbDM";
            rbDM.Size = new Size(90, 19);
            rbDM.TabIndex = 0;
            rbDM.TabStop = true;
            rbDM.Text = "Deathmatch";
            rbDM.UseVisualStyleBackColor = true;
            // 
            // labelMode
            // 
            labelMode.AutoSize = true;
            labelMode.Location = new Point(62, 12);
            labelMode.Name = "labelMode";
            labelMode.Size = new Size(75, 15);
            labelMode.TabIndex = 8;
            labelMode.Text = "Game mode:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 336);
            Controls.Add(panelHost);
            Controls.Add(panelJoin);
            Controls.Add(buttonStart);
            Controls.Add(rbJoin);
            Controls.Add(rbHost);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GZDML";
            panelJoin.ResumeLayout(false);
            panelJoin.PerformLayout();
            panelHost.ResumeLayout(false);
            panelHost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSkill).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMapNo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPlayers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbHost;
        private RadioButton rbJoin;
        private Label labelIPJ;
        private Button buttonStart;
        private TextBox tbIP;
        private Panel panelJoin;
        private Panel panelHost;
        private Label labelMode;
        private RadioButton rbCoop;
        private RadioButton rbDM;
        private NumericUpDown numPlayers;
        private Label labelPlayers;
        private NumericUpDown numMapNo;
        private Label labelMapNo;
        private NumericUpDown numSkill;
        private Label labelSkill;
        private CheckBox cbCrouch;
        private CheckBox cbJump;
        private CheckBox cbTeam;
        private CheckBox cbAltDM;
    }
}