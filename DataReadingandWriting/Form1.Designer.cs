namespace DataReadingandWriting
{
    partial class Form1
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
            this.b_LoadAll = new System.Windows.Forms.Button();
            this.lb_studentPick = new System.Windows.Forms.ListBox();
            this.lb_studentSelect = new System.Windows.Forms.ListBox();
            this.l_Voter = new System.Windows.Forms.Label();
            this.lb_VoterName = new System.Windows.Forms.ListBox();
            this.b_ResetAll = new System.Windows.Forms.Button();
            this.l_FileName = new System.Windows.Forms.Label();
            this.tb_FileName = new System.Windows.Forms.TextBox();
            this.b_SaveToFile = new System.Windows.Forms.Button();
            this.lb_IdealTeam = new System.Windows.Forms.ListBox();
            this.b_Randomizer = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamMakerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.l_teamCap = new System.Windows.Forms.Label();
            this.nUD_teamCap = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_teamCap)).BeginInit();
            this.SuspendLayout();
            // 
            // b_LoadAll
            // 
            this.b_LoadAll.Location = new System.Drawing.Point(322, 25);
            this.b_LoadAll.Name = "b_LoadAll";
            this.b_LoadAll.Size = new System.Drawing.Size(77, 23);
            this.b_LoadAll.TabIndex = 1;
            this.b_LoadAll.Text = "Load";
            this.b_LoadAll.UseVisualStyleBackColor = true;
            this.b_LoadAll.Click += new System.EventHandler(this.b_LoadAll_Click);
            // 
            // lb_studentPick
            // 
            this.lb_studentPick.FormattingEnabled = true;
            this.lb_studentPick.Location = new System.Drawing.Point(33, 102);
            this.lb_studentPick.Name = "lb_studentPick";
            this.lb_studentPick.Size = new System.Drawing.Size(283, 342);
            this.lb_studentPick.TabIndex = 7;
            this.lb_studentPick.SelectedIndexChanged += new System.EventHandler(this.lb_studentPick_SelectedIndexChanged);
            // 
            // lb_studentSelect
            // 
            this.lb_studentSelect.FormattingEnabled = true;
            this.lb_studentSelect.Location = new System.Drawing.Point(402, 102);
            this.lb_studentSelect.Name = "lb_studentSelect";
            this.lb_studentSelect.Size = new System.Drawing.Size(283, 342);
            this.lb_studentSelect.TabIndex = 8;
            this.lb_studentSelect.SelectedIndexChanged += new System.EventHandler(this.lb_studentSelect_SelectedIndexChanged);
            // 
            // l_Voter
            // 
            this.l_Voter.AutoSize = true;
            this.l_Voter.Location = new System.Drawing.Point(30, 68);
            this.l_Voter.Name = "l_Voter";
            this.l_Voter.Size = new System.Drawing.Size(35, 13);
            this.l_Voter.TabIndex = 9;
            this.l_Voter.Text = "Voter:";
            // 
            // lb_VoterName
            // 
            this.lb_VoterName.FormattingEnabled = true;
            this.lb_VoterName.Location = new System.Drawing.Point(111, 67);
            this.lb_VoterName.Name = "lb_VoterName";
            this.lb_VoterName.Size = new System.Drawing.Size(120, 17);
            this.lb_VoterName.TabIndex = 10;
            this.lb_VoterName.SelectedIndexChanged += new System.EventHandler(this.lb_VoterName_SelectedIndexChanged);
            // 
            // b_ResetAll
            // 
            this.b_ResetAll.Location = new System.Drawing.Point(87, 25);
            this.b_ResetAll.Name = "b_ResetAll";
            this.b_ResetAll.Size = new System.Drawing.Size(75, 23);
            this.b_ResetAll.TabIndex = 11;
            this.b_ResetAll.Text = "Reset";
            this.b_ResetAll.UseVisualStyleBackColor = true;
            this.b_ResetAll.Click += new System.EventHandler(this.b_ResetAll_Click);
            // 
            // l_FileName
            // 
            this.l_FileName.AutoSize = true;
            this.l_FileName.Location = new System.Drawing.Point(399, 69);
            this.l_FileName.Name = "l_FileName";
            this.l_FileName.Size = new System.Drawing.Size(52, 13);
            this.l_FileName.TabIndex = 12;
            this.l_FileName.Text = "Filename:";
            // 
            // tb_FileName
            // 
            this.tb_FileName.Location = new System.Drawing.Point(489, 64);
            this.tb_FileName.Name = "tb_FileName";
            this.tb_FileName.Size = new System.Drawing.Size(120, 20);
            this.tb_FileName.TabIndex = 13;
            // 
            // b_SaveToFile
            // 
            this.b_SaveToFile.Location = new System.Drawing.Point(577, 26);
            this.b_SaveToFile.Name = "b_SaveToFile";
            this.b_SaveToFile.Size = new System.Drawing.Size(75, 23);
            this.b_SaveToFile.TabIndex = 14;
            this.b_SaveToFile.Text = "Save";
            this.b_SaveToFile.UseVisualStyleBackColor = true;
            this.b_SaveToFile.Click += new System.EventHandler(this.b_SaveToFile_Click);
            // 
            // lb_IdealTeam
            // 
            this.lb_IdealTeam.FormattingEnabled = true;
            this.lb_IdealTeam.Location = new System.Drawing.Point(87, 176);
            this.lb_IdealTeam.Name = "lb_IdealTeam";
            this.lb_IdealTeam.Size = new System.Drawing.Size(164, 121);
            this.lb_IdealTeam.TabIndex = 17;
            this.lb_IdealTeam.Visible = false;
            // 
            // b_Randomizer
            // 
            this.b_Randomizer.Location = new System.Drawing.Point(131, 327);
            this.b_Randomizer.Name = "b_Randomizer";
            this.b_Randomizer.Size = new System.Drawing.Size(75, 23);
            this.b_Randomizer.TabIndex = 18;
            this.b_Randomizer.Text = "Try Again!";
            this.b_Randomizer.UseVisualStyleBackColor = true;
            this.b_Randomizer.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programsToolStripMenuItem,
            this.autoloadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // programsToolStripMenuItem
            // 
            this.programsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voterToolStripMenuItem,
            this.teamMakerToolStripMenuItem});
            this.programsToolStripMenuItem.Name = "programsToolStripMenuItem";
            this.programsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.programsToolStripMenuItem.Text = "Programs";
            // 
            // voterToolStripMenuItem
            // 
            this.voterToolStripMenuItem.Name = "voterToolStripMenuItem";
            this.voterToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.voterToolStripMenuItem.Text = "Voter";
            this.voterToolStripMenuItem.Click += new System.EventHandler(this.voterToolStripMenuItem_Click);
            // 
            // teamMakerToolStripMenuItem
            // 
            this.teamMakerToolStripMenuItem.Name = "teamMakerToolStripMenuItem";
            this.teamMakerToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.teamMakerToolStripMenuItem.Text = "TeamMaker";
            this.teamMakerToolStripMenuItem.Click += new System.EventHandler(this.teamMakerToolStripMenuItem_Click);
            // 
            // autoloadToolStripMenuItem
            // 
            this.autoloadToolStripMenuItem.Name = "autoloadToolStripMenuItem";
            this.autoloadToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.autoloadToolStripMenuItem.Text = "Autoload";
            this.autoloadToolStripMenuItem.Click += new System.EventHandler(this.autoloadToolStripMenuItem_Click);
            // 
            // l_teamCap
            // 
            this.l_teamCap.AutoSize = true;
            this.l_teamCap.Location = new System.Drawing.Point(48, 133);
            this.l_teamCap.Name = "l_teamCap";
            this.l_teamCap.Size = new System.Drawing.Size(81, 13);
            this.l_teamCap.TabIndex = 20;
            this.l_teamCap.Text = "Team Capacity:";
            this.l_teamCap.Visible = false;
            // 
            // nUD_teamCap
            // 
            this.nUD_teamCap.Location = new System.Drawing.Point(135, 133);
            this.nUD_teamCap.Maximum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.nUD_teamCap.Name = "nUD_teamCap";
            this.nUD_teamCap.Size = new System.Drawing.Size(120, 20);
            this.nUD_teamCap.TabIndex = 21;
            this.nUD_teamCap.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.nUD_teamCap);
            this.Controls.Add(this.l_teamCap);
            this.Controls.Add(this.b_Randomizer);
            this.Controls.Add(this.lb_IdealTeam);
            this.Controls.Add(this.b_SaveToFile);
            this.Controls.Add(this.tb_FileName);
            this.Controls.Add(this.l_FileName);
            this.Controls.Add(this.b_ResetAll);
            this.Controls.Add(this.lb_VoterName);
            this.Controls.Add(this.l_Voter);
            this.Controls.Add(this.lb_studentSelect);
            this.Controls.Add(this.lb_studentPick);
            this.Controls.Add(this.b_LoadAll);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_teamCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_LoadAll;
        private System.Windows.Forms.ListBox lb_studentPick;
        private System.Windows.Forms.ListBox lb_studentSelect;
        private System.Windows.Forms.Label l_Voter;
        private System.Windows.Forms.ListBox lb_VoterName;
        private System.Windows.Forms.Button b_ResetAll;
        private System.Windows.Forms.Label l_FileName;
        private System.Windows.Forms.TextBox tb_FileName;
        private System.Windows.Forms.Button b_SaveToFile;
        private System.Windows.Forms.ListBox lb_IdealTeam;
        private System.Windows.Forms.Button b_Randomizer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamMakerToolStripMenuItem;
        private System.Windows.Forms.Label l_teamCap;
        private System.Windows.Forms.NumericUpDown nUD_teamCap;
    }
}

