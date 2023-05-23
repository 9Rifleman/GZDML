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
            numTLimit = new NumericUpDown();
            numFLimit = new NumericUpDown();
            labelTLimit = new Label();
            labelFLimit = new Label();
            cbMonsters = new CheckBox();
            cbCrouch = new CheckBox();
            cbJump = new CheckBox();
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
            buttonPWAD1 = new Button();
            openPWAD = new OpenFileDialog();
            buttonPWAD2 = new Button();
            labelPWAD = new Label();
            panelPWAD = new Panel();
            comboxIWAD = new ComboBox();
            labelIWAD = new Label();
            panelSelect = new Panel();
            cbClose = new CheckBox();
            panelJoin.SuspendLayout();
            panelHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTLimit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFLimit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSkill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMapNo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPlayers).BeginInit();
            panelPWAD.SuspendLayout();
            panelSelect.SuspendLayout();
            SuspendLayout();
            // 
            // rbHost
            // 
            rbHost.AutoSize = true;
            rbHost.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbHost.Location = new Point(13, 11);
            rbHost.Name = "rbHost";
            rbHost.Size = new Size(85, 19);
            rbHost.TabIndex = 0;
            rbHost.Text = "Host game";
            rbHost.UseVisualStyleBackColor = true;
            rbHost.CheckedChanged += rbHost_CheckedChanged;
            // 
            // rbJoin
            // 
            rbJoin.AutoSize = true;
            rbJoin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbJoin.Location = new Point(144, 11);
            rbJoin.Name = "rbJoin";
            rbJoin.Size = new Size(81, 19);
            rbJoin.TabIndex = 0;
            rbJoin.Text = "Join game";
            rbJoin.UseVisualStyleBackColor = true;
            rbJoin.CheckedChanged += rbJoin_CheckedChanged;
            // 
            // labelIPJ
            // 
            labelIPJ.AutoSize = true;
            labelIPJ.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelIPJ.Location = new Point(80, 7);
            labelIPJ.Name = "labelIPJ";
            labelIPJ.Size = new Size(66, 15);
            labelIPJ.TabIndex = 3;
            labelIPJ.Text = "IP address:";
            // 
            // buttonStart
            // 
            buttonStart.FlatAppearance.BorderSize = 3;
            buttonStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStart.Location = new Point(12, 526);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(113, 32);
            buttonStart.TabIndex = 4;
            buttonStart.Text = "Start game!";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // tbIP
            // 
            tbIP.BorderStyle = BorderStyle.FixedSingle;
            tbIP.Location = new Point(38, 25);
            tbIP.MaxLength = 15;
            tbIP.Name = "tbIP";
            tbIP.Size = new Size(150, 23);
            tbIP.TabIndex = 5;
            tbIP.TextAlign = HorizontalAlignment.Center;
            // 
            // panelJoin
            // 
            panelJoin.BackColor = SystemColors.Control;
            panelJoin.BorderStyle = BorderStyle.FixedSingle;
            panelJoin.Controls.Add(tbIP);
            panelJoin.Controls.Add(labelIPJ);
            panelJoin.Location = new Point(9, 324);
            panelJoin.Name = "panelJoin";
            panelJoin.Size = new Size(234, 58);
            panelJoin.TabIndex = 6;
            // 
            // panelHost
            // 
            panelHost.BackColor = SystemColors.Control;
            panelHost.BorderStyle = BorderStyle.FixedSingle;
            panelHost.Controls.Add(numTLimit);
            panelHost.Controls.Add(numFLimit);
            panelHost.Controls.Add(labelTLimit);
            panelHost.Controls.Add(labelFLimit);
            panelHost.Controls.Add(cbMonsters);
            panelHost.Controls.Add(cbCrouch);
            panelHost.Controls.Add(cbJump);
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
            panelHost.Location = new Point(9, 56);
            panelHost.Name = "panelHost";
            panelHost.Size = new Size(235, 262);
            panelHost.TabIndex = 7;
            // 
            // numTLimit
            // 
            numTLimit.Location = new Point(133, 146);
            numTLimit.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numTLimit.Name = "numTLimit";
            numTLimit.Size = new Size(45, 23);
            numTLimit.TabIndex = 21;
            // 
            // numFLimit
            // 
            numFLimit.Location = new Point(54, 146);
            numFLimit.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numFLimit.Name = "numFLimit";
            numFLimit.Size = new Size(45, 23);
            numFLimit.TabIndex = 20;
            // 
            // labelTLimit
            // 
            labelTLimit.AutoSize = true;
            labelTLimit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTLimit.Location = new Point(128, 128);
            labelTLimit.Name = "labelTLimit";
            labelTLimit.Size = new Size(66, 15);
            labelTLimit.TabIndex = 19;
            labelTLimit.Text = "Time limit:";
            // 
            // labelFLimit
            // 
            labelFLimit.AutoSize = true;
            labelFLimit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelFLimit.Location = new Point(46, 128);
            labelFLimit.Name = "labelFLimit";
            labelFLimit.Size = new Size(62, 15);
            labelFLimit.TabIndex = 18;
            labelFLimit.Text = "Frag limit:";
            // 
            // cbMonsters
            // 
            cbMonsters.AutoSize = true;
            cbMonsters.Location = new Point(126, 201);
            cbMonsters.Name = "cbMonsters";
            cbMonsters.Size = new Size(94, 19);
            cbMonsters.TabIndex = 17;
            cbMonsters.Text = "No monsters";
            cbMonsters.UseVisualStyleBackColor = true;
            // 
            // cbCrouch
            // 
            cbCrouch.AutoSize = true;
            cbCrouch.Location = new Point(126, 226);
            cbCrouch.Name = "cbCrouch";
            cbCrouch.Size = new Size(96, 19);
            cbCrouch.TabIndex = 16;
            cbCrouch.Text = "Allow crouch";
            cbCrouch.UseVisualStyleBackColor = true;
            // 
            // cbJump
            // 
            cbJump.AutoSize = true;
            cbJump.Location = new Point(12, 226);
            cbJump.Name = "cbJump";
            cbJump.Size = new Size(87, 19);
            cbJump.TabIndex = 15;
            cbJump.Text = "Allow jump";
            cbJump.UseVisualStyleBackColor = true;
            // 
            // cbAltDM
            // 
            cbAltDM.AutoSize = true;
            cbAltDM.Location = new Point(12, 201);
            cbAltDM.Name = "cbAltDM";
            cbAltDM.Size = new Size(94, 19);
            cbAltDM.TabIndex = 8;
            cbAltDM.Text = "Alt. DM flags";
            cbAltDM.UseVisualStyleBackColor = true;
            // 
            // numSkill
            // 
            numSkill.Location = new Point(175, 85);
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
            labelSkill.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSkill.Location = new Point(179, 67);
            labelSkill.Name = "labelSkill";
            labelSkill.Size = new Size(33, 15);
            labelSkill.TabIndex = 12;
            labelSkill.Text = "Skill:";
            // 
            // numMapNo
            // 
            numMapNo.Location = new Point(94, 85);
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
            labelMapNo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelMapNo.Location = new Point(101, 67);
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
            labelPlayers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlayers.Location = new Point(12, 67);
            labelPlayers.Name = "labelPlayers";
            labelPlayers.Size = new Size(49, 15);
            labelPlayers.TabIndex = 8;
            labelPlayers.Text = "Players:";
            // 
            // rbCoop
            // 
            rbCoop.AutoSize = true;
            rbCoop.Location = new Point(133, 30);
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
            labelMode.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelMode.Location = new Point(76, 12);
            labelMode.Name = "labelMode";
            labelMode.Size = new Size(78, 15);
            labelMode.TabIndex = 8;
            labelMode.Text = "Game mode:";
            // 
            // buttonPWAD1
            // 
            buttonPWAD1.Location = new Point(11, 94);
            buttonPWAD1.Name = "buttonPWAD1";
            buttonPWAD1.Size = new Size(103, 23);
            buttonPWAD1.TabIndex = 8;
            buttonPWAD1.Text = "PWAD 1";
            buttonPWAD1.UseVisualStyleBackColor = true;
            buttonPWAD1.Click += buttonPWAD1_Click;
            // 
            // openPWAD
            // 
            openPWAD.FileName = "openFileDialog1";
            // 
            // buttonPWAD2
            // 
            buttonPWAD2.Location = new Point(120, 94);
            buttonPWAD2.Name = "buttonPWAD2";
            buttonPWAD2.Size = new Size(101, 23);
            buttonPWAD2.TabIndex = 22;
            buttonPWAD2.Text = "PWAD 2";
            buttonPWAD2.UseVisualStyleBackColor = true;
            buttonPWAD2.Click += buttonPWAD2_Click;
            // 
            // labelPWAD
            // 
            labelPWAD.AutoSize = true;
            labelPWAD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPWAD.Location = new Point(94, 76);
            labelPWAD.Name = "labelPWAD";
            labelPWAD.Size = new Size(51, 15);
            labelPWAD.TabIndex = 23;
            labelPWAD.Text = "PWADs:";
            labelPWAD.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelPWAD
            // 
            panelPWAD.BackColor = SystemColors.Control;
            panelPWAD.BorderStyle = BorderStyle.FixedSingle;
            panelPWAD.Controls.Add(comboxIWAD);
            panelPWAD.Controls.Add(labelIWAD);
            panelPWAD.Controls.Add(labelPWAD);
            panelPWAD.Controls.Add(buttonPWAD2);
            panelPWAD.Controls.Add(buttonPWAD1);
            panelPWAD.Location = new Point(9, 388);
            panelPWAD.Name = "panelPWAD";
            panelPWAD.Size = new Size(234, 132);
            panelPWAD.TabIndex = 8;
            // 
            // comboxIWAD
            // 
            comboxIWAD.FormattingEnabled = true;
            comboxIWAD.Location = new Point(54, 31);
            comboxIWAD.Name = "comboxIWAD";
            comboxIWAD.Size = new Size(121, 23);
            comboxIWAD.TabIndex = 25;
            // 
            // labelIWAD
            // 
            labelIWAD.AutoSize = true;
            labelIWAD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelIWAD.Location = new Point(94, 13);
            labelIWAD.Name = "labelIWAD";
            labelIWAD.Size = new Size(43, 15);
            labelIWAD.TabIndex = 24;
            labelIWAD.Text = "IWAD:";
            labelIWAD.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelSelect
            // 
            panelSelect.BackColor = SystemColors.Control;
            panelSelect.BorderStyle = BorderStyle.FixedSingle;
            panelSelect.Controls.Add(rbJoin);
            panelSelect.Controls.Add(rbHost);
            panelSelect.Location = new Point(9, 9);
            panelSelect.Name = "panelSelect";
            panelSelect.Size = new Size(235, 41);
            panelSelect.TabIndex = 9;
            // 
            // cbClose
            // 
            cbClose.AutoSize = true;
            cbClose.Checked = true;
            cbClose.CheckState = CheckState.Checked;
            cbClose.Location = new Point(134, 532);
            cbClose.Name = "cbClose";
            cbClose.Size = new Size(108, 19);
            cbClose.TabIndex = 10;
            cbClose.Text = "Close after start";
            cbClose.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(253, 570);
            Controls.Add(cbClose);
            Controls.Add(panelSelect);
            Controls.Add(panelPWAD);
            Controls.Add(panelHost);
            Controls.Add(panelJoin);
            Controls.Add(buttonStart);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GZDML";
            panelJoin.ResumeLayout(false);
            panelJoin.PerformLayout();
            panelHost.ResumeLayout(false);
            panelHost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTLimit).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFLimit).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSkill).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMapNo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPlayers).EndInit();
            panelPWAD.ResumeLayout(false);
            panelPWAD.PerformLayout();
            panelSelect.ResumeLayout(false);
            panelSelect.PerformLayout();
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
        private CheckBox cbAltDM;
        private CheckBox cbMonsters;
        private Label labelTLimit;
        private Label labelFLimit;
        private NumericUpDown numTLimit;
        private NumericUpDown numFLimit;
        private OpenFileDialog openPWAD;
        private Button buttonPWAD1;
        private Button buttonPWAD2;
        private Label labelPWAD;
        private Panel panelPWAD;
        private Panel panelSelect;
        private CheckBox cbClose;
        private Label labelIWAD;
        private ComboBox comboxIWAD;
    }
}