namespace DraftManager
{
    partial class frmDraft
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
			  this.PlayerPos6 = new System.Windows.Forms.ColumnHeader();
			  this.RosterPos2 = new System.Windows.Forms.ColumnHeader();
			  this.RosterSpace = new System.Windows.Forms.ColumnHeader();
			  this.btnADP = new System.Windows.Forms.Button();
			  this.RosterPos1 = new System.Windows.Forms.ColumnHeader();
			  this.textUp = new System.Windows.Forms.TextBox();
			  this.btnClear = new System.Windows.Forms.Button();
			  this.PlayerPos5 = new System.Windows.Forms.ColumnHeader();
			  this.RosterPos3 = new System.Windows.Forms.ColumnHeader();
			  this.PlayerPos4 = new System.Windows.Forms.ColumnHeader();
			  this.textNext = new System.Windows.Forms.TextBox();
			  this.PlayerPos3 = new System.Windows.Forms.ColumnHeader();
			  this.btnSave = new System.Windows.Forms.Button();
			  this.btnPass = new System.Windows.Forms.Button();
			  this.btnUndo = new System.Windows.Forms.Button();
			  this.btnTrade = new System.Windows.Forms.Button();
			  this.btnPause = new System.Windows.Forms.Button();
			  this.RosterPos4 = new System.Windows.Forms.ColumnHeader();
			  this.btnAlpha = new System.Windows.Forms.Button();
			  this.RosterPos5 = new System.Windows.Forms.ColumnHeader();
			  this.btnValue = new System.Windows.Forms.Button();
			  this.textBox8 = new System.Windows.Forms.TextBox();
			  this.textBox7 = new System.Windows.Forms.TextBox();
			  this.textBox6 = new System.Windows.Forms.TextBox();
			  this.textBox5 = new System.Windows.Forms.TextBox();
			  this.textBox4 = new System.Windows.Forms.TextBox();
			  this.PickRound = new System.Windows.Forms.ColumnHeader();
			  this.textBox2 = new System.Windows.Forms.TextBox();
			  this.PickTeam = new System.Windows.Forms.ColumnHeader();
			  this.RosterPos6 = new System.Windows.Forms.ColumnHeader();
			  this.PickPlayer = new System.Windows.Forms.ColumnHeader();
			  this.textBox3 = new System.Windows.Forms.TextBox();
			  this.textComment = new System.Windows.Forms.TextBox();
			  this.textBox1 = new System.Windows.Forms.TextBox();
			  this.PlayerPos2 = new System.Windows.Forms.ColumnHeader();
			  this.PlayerPos1 = new System.Windows.Forms.ColumnHeader();
			  this.btnStart = new System.Windows.Forms.Button();
			  this.lvwPlayer = new System.Windows.Forms.ListView();
			  this.PlayerVal = new System.Windows.Forms.ColumnHeader();
			  this.lvwRoster = new System.Windows.Forms.ListView();
			  this.lvwPick = new System.Windows.Forms.ListView();
			  this.cmbRoster = new System.Windows.Forms.ComboBox();
			  this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			  this.draftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			  this.newDraftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			  this.openDraftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			  this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			  this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			  this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			  this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			  this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			  this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			  this.generalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			  this.generalInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			  this.fTPInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			  this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			  this.scoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			  this.averagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			  this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			  this.playersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			  this.teamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			  this.picksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			  this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			  this.rankingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			  this.btnClose = new System.Windows.Forms.Button();
			  this.btnPost = new System.Windows.Forms.Button();
			  this.tmrClock = new System.Windows.Forms.Timer(this.components);
			  this.btnCS = new System.Windows.Forms.Button();
			  this.menuStrip1.SuspendLayout();
			  this.SuspendLayout();
			  // 
			  // PlayerPos6
			  // 
			  this.PlayerPos6.Text = "";
			  this.PlayerPos6.Width = 160;
			  // 
			  // RosterPos2
			  // 
			  this.RosterPos2.Text = "";
			  this.RosterPos2.Width = 160;
			  // 
			  // RosterSpace
			  // 
			  this.RosterSpace.Text = "#";
			  this.RosterSpace.Width = 50;
			  // 
			  // btnADP
			  // 
			  this.btnADP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			  this.btnADP.Location = new System.Drawing.Point(1170, 570);
			  this.btnADP.Name = "btnADP";
			  this.btnADP.Size = new System.Drawing.Size(100, 30);
			  this.btnADP.TabIndex = 89;
			  this.btnADP.Text = "ADP";
			  this.btnADP.UseVisualStyleBackColor = true;
			  this.btnADP.Click += new System.EventHandler(this.btnADP_Click);
			  // 
			  // RosterPos1
			  // 
			  this.RosterPos1.Text = "";
			  this.RosterPos1.Width = 160;
			  // 
			  // textUp
			  // 
			  this.textUp.Location = new System.Drawing.Point(460, 40);
			  this.textUp.Name = "textUp";
			  this.textUp.Size = new System.Drawing.Size(170, 20);
			  this.textUp.TabIndex = 76;
			  // 
			  // btnClear
			  // 
			  this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			  this.btnClear.Location = new System.Drawing.Point(1170, 490);
			  this.btnClear.Name = "btnClear";
			  this.btnClear.Size = new System.Drawing.Size(100, 41);
			  this.btnClear.TabIndex = 75;
			  this.btnClear.Text = "Clear";
			  this.btnClear.UseVisualStyleBackColor = true;
			  this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			  // 
			  // PlayerPos5
			  // 
			  this.PlayerPos5.Text = "";
			  this.PlayerPos5.Width = 160;
			  // 
			  // RosterPos3
			  // 
			  this.RosterPos3.Text = "";
			  this.RosterPos3.Width = 160;
			  // 
			  // PlayerPos4
			  // 
			  this.PlayerPos4.Text = "";
			  this.PlayerPos4.Width = 160;
			  // 
			  // textNext
			  // 
			  this.textNext.Location = new System.Drawing.Point(680, 40);
			  this.textNext.Name = "textNext";
			  this.textNext.Size = new System.Drawing.Size(190, 20);
			  this.textNext.TabIndex = 77;
			  // 
			  // PlayerPos3
			  // 
			  this.PlayerPos3.Text = "";
			  this.PlayerPos3.Width = 160;
			  // 
			  // btnSave
			  // 
			  this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			  this.btnSave.Location = new System.Drawing.Point(1130, 660);
			  this.btnSave.Name = "btnSave";
			  this.btnSave.Size = new System.Drawing.Size(64, 41);
			  this.btnSave.TabIndex = 73;
			  this.btnSave.Text = "Save";
			  this.btnSave.UseVisualStyleBackColor = true;
			  this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			  // 
			  // btnPass
			  // 
			  this.btnPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			  this.btnPass.Location = new System.Drawing.Point(1060, 440);
			  this.btnPass.Name = "btnPass";
			  this.btnPass.Size = new System.Drawing.Size(102, 41);
			  this.btnPass.TabIndex = 72;
			  this.btnPass.Text = "Pass";
			  this.btnPass.UseVisualStyleBackColor = true;
			  this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
			  // 
			  // btnUndo
			  // 
			  this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			  this.btnUndo.Location = new System.Drawing.Point(1170, 440);
			  this.btnUndo.Name = "btnUndo";
			  this.btnUndo.Size = new System.Drawing.Size(100, 41);
			  this.btnUndo.TabIndex = 71;
			  this.btnUndo.Text = "Undo";
			  this.btnUndo.UseVisualStyleBackColor = true;
			  this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
			  // 
			  // btnTrade
			  // 
			  this.btnTrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			  this.btnTrade.Location = new System.Drawing.Point(1060, 490);
			  this.btnTrade.Name = "btnTrade";
			  this.btnTrade.Size = new System.Drawing.Size(102, 41);
			  this.btnTrade.TabIndex = 70;
			  this.btnTrade.Text = "Trade...";
			  this.btnTrade.UseVisualStyleBackColor = true;
			  this.btnTrade.Click += new System.EventHandler(this.btnTrade_Click);
			  // 
			  // btnPause
			  // 
			  this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			  this.btnPause.Location = new System.Drawing.Point(1170, 350);
			  this.btnPause.Name = "btnPause";
			  this.btnPause.Size = new System.Drawing.Size(100, 41);
			  this.btnPause.TabIndex = 69;
			  this.btnPause.Text = "Pause";
			  this.btnPause.UseVisualStyleBackColor = true;
			  this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
			  // 
			  // RosterPos4
			  // 
			  this.RosterPos4.Text = "";
			  this.RosterPos4.Width = 160;
			  // 
			  // btnAlpha
			  // 
			  this.btnAlpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			  this.btnAlpha.Location = new System.Drawing.Point(1170, 610);
			  this.btnAlpha.Name = "btnAlpha";
			  this.btnAlpha.Size = new System.Drawing.Size(100, 30);
			  this.btnAlpha.TabIndex = 88;
			  this.btnAlpha.Text = "A-Z";
			  this.btnAlpha.UseVisualStyleBackColor = true;
			  this.btnAlpha.Click += new System.EventHandler(this.bnAlpha_Click);
			  // 
			  // RosterPos5
			  // 
			  this.RosterPos5.Text = "";
			  this.RosterPos5.Width = 160;
			  // 
			  // btnValue
			  // 
			  this.btnValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			  this.btnValue.Location = new System.Drawing.Point(1060, 570);
			  this.btnValue.Name = "btnValue";
			  this.btnValue.Size = new System.Drawing.Size(100, 30);
			  this.btnValue.TabIndex = 87;
			  this.btnValue.Text = "VBD";
			  this.btnValue.UseVisualStyleBackColor = true;
			  this.btnValue.Click += new System.EventHandler(this.bnValue_Click);
			  // 
			  // textBox8
			  // 
			  this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
			  this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			  this.textBox8.Location = new System.Drawing.Point(1060, 540);
			  this.textBox8.Name = "textBox8";
			  this.textBox8.ReadOnly = true;
			  this.textBox8.Size = new System.Drawing.Size(130, 19);
			  this.textBox8.TabIndex = 86;
			  this.textBox8.Text = "Sort";
			  // 
			  // textBox7
			  // 
			  this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
			  this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			  this.textBox7.Location = new System.Drawing.Point(1060, 410);
			  this.textBox7.Name = "textBox7";
			  this.textBox7.ReadOnly = true;
			  this.textBox7.Size = new System.Drawing.Size(130, 19);
			  this.textBox7.TabIndex = 85;
			  this.textBox7.Text = "Functions";
			  // 
			  // textBox6
			  // 
			  this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			  this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			  this.textBox6.Location = new System.Drawing.Point(1060, 320);
			  this.textBox6.Name = "textBox6";
			  this.textBox6.ReadOnly = true;
			  this.textBox6.Size = new System.Drawing.Size(130, 19);
			  this.textBox6.TabIndex = 84;
			  this.textBox6.Text = "Clock";
			  // 
			  // textBox5
			  // 
			  this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			  this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			  this.textBox5.Location = new System.Drawing.Point(1060, 40);
			  this.textBox5.Name = "textBox5";
			  this.textBox5.ReadOnly = true;
			  this.textBox5.Size = new System.Drawing.Size(130, 19);
			  this.textBox5.TabIndex = 83;
			  this.textBox5.Text = "Picks:";
			  // 
			  // textBox4
			  // 
			  this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			  this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			  this.textBox4.Location = new System.Drawing.Point(420, 40);
			  this.textBox4.Name = "textBox4";
			  this.textBox4.ReadOnly = true;
			  this.textBox4.Size = new System.Drawing.Size(40, 19);
			  this.textBox4.TabIndex = 82;
			  this.textBox4.Text = "Up:";
			  this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			  // 
			  // PickRound
			  // 
			  this.PickRound.Text = "Rnd";
			  this.PickRound.Width = 38;
			  // 
			  // textBox2
			  // 
			  this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			  this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			  this.textBox2.Location = new System.Drawing.Point(640, 40);
			  this.textBox2.Name = "textBox2";
			  this.textBox2.ReadOnly = true;
			  this.textBox2.Size = new System.Drawing.Size(40, 19);
			  this.textBox2.TabIndex = 81;
			  this.textBox2.Text = "Next:";
			  this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			  // 
			  // PickTeam
			  // 
			  this.PickTeam.Text = "Team";
			  this.PickTeam.Width = 72;
			  // 
			  // RosterPos6
			  // 
			  this.RosterPos6.Text = "";
			  this.RosterPos6.Width = 160;
			  // 
			  // PickPlayer
			  // 
			  this.PickPlayer.Text = "Player";
			  this.PickPlayer.Width = 86;
			  // 
			  // textBox3
			  // 
			  this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			  this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			  this.textBox3.Location = new System.Drawing.Point(16, 222);
			  this.textBox3.Name = "textBox3";
			  this.textBox3.ReadOnly = true;
			  this.textBox3.Size = new System.Drawing.Size(170, 19);
			  this.textBox3.TabIndex = 80;
			  this.textBox3.Text = "Available Player List";
			  this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			  // 
			  // textComment
			  // 
			  this.textComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			  this.textComment.Location = new System.Drawing.Point(276, 222);
			  this.textComment.Name = "textComment";
			  this.textComment.Size = new System.Drawing.Size(774, 20);
			  this.textComment.TabIndex = 79;
			  // 
			  // textBox1
			  // 
			  this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			  this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			  this.textBox1.Location = new System.Drawing.Point(20, 40);
			  this.textBox1.Name = "textBox1";
			  this.textBox1.ReadOnly = true;
			  this.textBox1.Size = new System.Drawing.Size(130, 19);
			  this.textBox1.TabIndex = 78;
			  this.textBox1.Text = "Current Rosters";
			  this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			  // 
			  // PlayerPos2
			  // 
			  this.PlayerPos2.Text = "";
			  this.PlayerPos2.Width = 160;
			  // 
			  // PlayerPos1
			  // 
			  this.PlayerPos1.Text = "";
			  this.PlayerPos1.Width = 160;
			  // 
			  // btnStart
			  // 
			  this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			  this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
			  this.btnStart.Location = new System.Drawing.Point(1060, 350);
			  this.btnStart.Name = "btnStart";
			  this.btnStart.Size = new System.Drawing.Size(102, 41);
			  this.btnStart.TabIndex = 68;
			  this.btnStart.Text = "Start";
			  this.btnStart.UseVisualStyleBackColor = true;
			  this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			  // 
			  // lvwPlayer
			  // 
			  this.lvwPlayer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PlayerVal,
            this.PlayerPos1,
            this.PlayerPos2,
            this.PlayerPos3,
            this.PlayerPos4,
            this.PlayerPos5,
            this.PlayerPos6});
			  this.lvwPlayer.FullRowSelect = true;
			  this.lvwPlayer.GridLines = true;
			  this.lvwPlayer.Location = new System.Drawing.Point(10, 250);
			  this.lvwPlayer.MultiSelect = false;
			  this.lvwPlayer.Name = "lvwPlayer";
			  this.lvwPlayer.Size = new System.Drawing.Size(1034, 451);
			  this.lvwPlayer.TabIndex = 67;
			  this.lvwPlayer.UseCompatibleStateImageBehavior = false;
			  this.lvwPlayer.View = System.Windows.Forms.View.Details;
			  this.lvwPlayer.SelectedIndexChanged += new System.EventHandler(this.lvwPlayer_SelectedIndexChanged);
			  // 
			  // PlayerVal
			  // 
			  this.PlayerVal.Text = "Val";
			  this.PlayerVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			  this.PlayerVal.Width = 50;
			  // 
			  // lvwRoster
			  // 
			  this.lvwRoster.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RosterSpace,
            this.RosterPos1,
            this.RosterPos2,
            this.RosterPos3,
            this.RosterPos4,
            this.RosterPos5,
            this.RosterPos6});
			  this.lvwRoster.GridLines = true;
			  this.lvwRoster.Location = new System.Drawing.Point(10, 70);
			  this.lvwRoster.Name = "lvwRoster";
			  this.lvwRoster.Size = new System.Drawing.Size(1034, 130);
			  this.lvwRoster.TabIndex = 66;
			  this.lvwRoster.UseCompatibleStateImageBehavior = false;
			  this.lvwRoster.View = System.Windows.Forms.View.Details;
			  // 
			  // lvwPick
			  // 
			  this.lvwPick.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PickRound,
            this.PickTeam,
            this.PickPlayer});
			  this.lvwPick.FullRowSelect = true;
			  this.lvwPick.GridLines = true;
			  this.lvwPick.Location = new System.Drawing.Point(1050, 70);
			  this.lvwPick.MultiSelect = false;
			  this.lvwPick.Name = "lvwPick";
			  this.lvwPick.Size = new System.Drawing.Size(220, 230);
			  this.lvwPick.TabIndex = 64;
			  this.lvwPick.UseCompatibleStateImageBehavior = false;
			  this.lvwPick.View = System.Windows.Forms.View.Details;
			  // 
			  // cmbRoster
			  // 
			  this.cmbRoster.DropDownHeight = 200;
			  this.cmbRoster.FormattingEnabled = true;
			  this.cmbRoster.IntegralHeight = false;
			  this.cmbRoster.Location = new System.Drawing.Point(160, 40);
			  this.cmbRoster.Name = "cmbRoster";
			  this.cmbRoster.Size = new System.Drawing.Size(200, 21);
			  this.cmbRoster.TabIndex = 65;
			  this.cmbRoster.SelectedIndexChanged += new System.EventHandler(this.cmbRoster_SelectedIndexChanged);
			  // 
			  // menuStrip1
			  // 
			  this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.draftToolStripMenuItem,
            this.generalToolStripMenuItem1});
			  this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			  this.menuStrip1.Name = "menuStrip1";
			  this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
			  this.menuStrip1.TabIndex = 63;
			  this.menuStrip1.Text = "menuStrip1";
			  // 
			  // draftToolStripMenuItem
			  // 
			  this.draftToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDraftToolStripMenuItem,
            this.openDraftToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem1});
			  this.draftToolStripMenuItem.Name = "draftToolStripMenuItem";
			  this.draftToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			  this.draftToolStripMenuItem.Text = "Draft";
			  // 
			  // newDraftToolStripMenuItem
			  // 
			  this.newDraftToolStripMenuItem.Name = "newDraftToolStripMenuItem";
			  this.newDraftToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			  this.newDraftToolStripMenuItem.Text = "&New Draft";
			  this.newDraftToolStripMenuItem.Click += new System.EventHandler(this.newDraftToolStripMenuItem_Click);
			  // 
			  // openDraftToolStripMenuItem
			  // 
			  this.openDraftToolStripMenuItem.Name = "openDraftToolStripMenuItem";
			  this.openDraftToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			  this.openDraftToolStripMenuItem.Text = "&Open Draft...";
			  this.openDraftToolStripMenuItem.Click += new System.EventHandler(this.openDraftToolStripMenuItem_Click);
			  // 
			  // closeToolStripMenuItem
			  // 
			  this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			  this.closeToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			  this.closeToolStripMenuItem.Text = "&Close";
			  this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			  // 
			  // toolStripMenuItem1
			  // 
			  this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			  this.toolStripMenuItem1.Size = new System.Drawing.Size(137, 6);
			  // 
			  // saveToolStripMenuItem
			  // 
			  this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			  this.saveToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			  this.saveToolStripMenuItem.Text = "&Save";
			  this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			  // 
			  // saveAsToolStripMenuItem
			  // 
			  this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			  this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			  this.saveAsToolStripMenuItem.Text = "Save &As...";
			  this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			  // 
			  // toolStripMenuItem2
			  // 
			  this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			  this.toolStripMenuItem2.Size = new System.Drawing.Size(137, 6);
			  // 
			  // exitToolStripMenuItem1
			  // 
			  this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
			  this.exitToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
			  this.exitToolStripMenuItem1.Text = "E&xit";
			  this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
			  // 
			  // generalToolStripMenuItem1
			  // 
			  this.generalToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalInformationToolStripMenuItem,
            this.fTPInformationToolStripMenuItem,
            this.toolStripMenuItem3,
            this.scoringToolStripMenuItem,
            this.averagesToolStripMenuItem,
            this.toolStripMenuItem4,
            this.playersToolStripMenuItem1,
            this.teamsToolStripMenuItem,
            this.picksToolStripMenuItem,
            this.toolStripMenuItem5,
            this.rankingsToolStripMenuItem});
			  this.generalToolStripMenuItem1.Name = "generalToolStripMenuItem1";
			  this.generalToolStripMenuItem1.Size = new System.Drawing.Size(47, 20);
			  this.generalToolStripMenuItem1.Text = "Setup";
			  // 
			  // generalInformationToolStripMenuItem
			  // 
			  this.generalInformationToolStripMenuItem.Name = "generalInformationToolStripMenuItem";
			  this.generalInformationToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			  this.generalInformationToolStripMenuItem.Text = "&General Information...";
			  this.generalInformationToolStripMenuItem.Click += new System.EventHandler(this.generalInformationToolStripMenuItem_Click);
			  // 
			  // fTPInformationToolStripMenuItem
			  // 
			  this.fTPInformationToolStripMenuItem.Name = "fTPInformationToolStripMenuItem";
			  this.fTPInformationToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			  this.fTPInformationToolStripMenuItem.Text = "FTP Information...";
			  this.fTPInformationToolStripMenuItem.Click += new System.EventHandler(this.fTPInformationToolStripMenuItem_Click);
			  // 
			  // toolStripMenuItem3
			  // 
			  this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			  this.toolStripMenuItem3.Size = new System.Drawing.Size(179, 6);
			  // 
			  // scoringToolStripMenuItem
			  // 
			  this.scoringToolStripMenuItem.Name = "scoringToolStripMenuItem";
			  this.scoringToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			  this.scoringToolStripMenuItem.Text = "Scoring...";
			  this.scoringToolStripMenuItem.Click += new System.EventHandler(this.scoringToolStripMenuItem_Click);
			  // 
			  // averagesToolStripMenuItem
			  // 
			  this.averagesToolStripMenuItem.Name = "averagesToolStripMenuItem";
			  this.averagesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			  this.averagesToolStripMenuItem.Text = "Averages...";
			  this.averagesToolStripMenuItem.Click += new System.EventHandler(this.averagesToolStripMenuItem_Click_1);
			  // 
			  // toolStripMenuItem4
			  // 
			  this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			  this.toolStripMenuItem4.Size = new System.Drawing.Size(179, 6);
			  // 
			  // playersToolStripMenuItem1
			  // 
			  this.playersToolStripMenuItem1.Name = "playersToolStripMenuItem1";
			  this.playersToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
			  this.playersToolStripMenuItem1.Text = "&Players...";
			  this.playersToolStripMenuItem1.Click += new System.EventHandler(this.playersToolStripMenuItem1_Click);
			  // 
			  // teamsToolStripMenuItem
			  // 
			  this.teamsToolStripMenuItem.Name = "teamsToolStripMenuItem";
			  this.teamsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			  this.teamsToolStripMenuItem.Text = "&Teams...";
			  this.teamsToolStripMenuItem.Click += new System.EventHandler(this.teamsToolStripMenuItem_Click);
			  // 
			  // picksToolStripMenuItem
			  // 
			  this.picksToolStripMenuItem.Name = "picksToolStripMenuItem";
			  this.picksToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			  this.picksToolStripMenuItem.Text = "Picks...";
			  this.picksToolStripMenuItem.Click += new System.EventHandler(this.picksToolStripMenuItem_Click);
			  // 
			  // toolStripMenuItem5
			  // 
			  this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			  this.toolStripMenuItem5.Size = new System.Drawing.Size(179, 6);
			  // 
			  // rankingsToolStripMenuItem
			  // 
			  this.rankingsToolStripMenuItem.Name = "rankingsToolStripMenuItem";
			  this.rankingsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			  this.rankingsToolStripMenuItem.Text = "Rankings...";
			  this.rankingsToolStripMenuItem.Click += new System.EventHandler(this.rankingsToolStripMenuItem_Click);
			  // 
			  // btnClose
			  // 
			  this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			  this.btnClose.Location = new System.Drawing.Point(1200, 660);
			  this.btnClose.Name = "btnClose";
			  this.btnClose.Size = new System.Drawing.Size(70, 41);
			  this.btnClose.TabIndex = 90;
			  this.btnClose.Text = "Close";
			  this.btnClose.UseVisualStyleBackColor = true;
			  // 
			  // btnPost
			  // 
			  this.btnPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			  this.btnPost.Location = new System.Drawing.Point(1060, 660);
			  this.btnPost.Name = "btnPost";
			  this.btnPost.Size = new System.Drawing.Size(68, 41);
			  this.btnPost.TabIndex = 91;
			  this.btnPost.Text = "Post";
			  this.btnPost.UseVisualStyleBackColor = true;
			  this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
			  // 
			  // tmrClock
			  // 
			  this.tmrClock.Interval = 1000;
			  this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
			  // 
			  // btnCS
			  // 
			  this.btnCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			  this.btnCS.Location = new System.Drawing.Point(1060, 610);
			  this.btnCS.Name = "btnCS";
			  this.btnCS.Size = new System.Drawing.Size(100, 30);
			  this.btnCS.TabIndex = 92;
			  this.btnCS.Text = "CS";
			  this.btnCS.UseVisualStyleBackColor = true;
			  this.btnCS.Click += new System.EventHandler(this.btnCS_Click);
			  // 
			  // frmDraft
			  // 
			  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			  this.ClientSize = new System.Drawing.Size(1284, 715);
			  this.Controls.Add(this.btnCS);
			  this.Controls.Add(this.btnPost);
			  this.Controls.Add(this.btnClose);
			  this.Controls.Add(this.btnADP);
			  this.Controls.Add(this.textUp);
			  this.Controls.Add(this.btnClear);
			  this.Controls.Add(this.textNext);
			  this.Controls.Add(this.btnSave);
			  this.Controls.Add(this.btnPass);
			  this.Controls.Add(this.btnUndo);
			  this.Controls.Add(this.btnTrade);
			  this.Controls.Add(this.btnPause);
			  this.Controls.Add(this.btnAlpha);
			  this.Controls.Add(this.btnValue);
			  this.Controls.Add(this.textBox8);
			  this.Controls.Add(this.textBox7);
			  this.Controls.Add(this.textBox6);
			  this.Controls.Add(this.textBox5);
			  this.Controls.Add(this.textBox4);
			  this.Controls.Add(this.textBox2);
			  this.Controls.Add(this.textBox3);
			  this.Controls.Add(this.textComment);
			  this.Controls.Add(this.textBox1);
			  this.Controls.Add(this.btnStart);
			  this.Controls.Add(this.lvwPlayer);
			  this.Controls.Add(this.lvwRoster);
			  this.Controls.Add(this.lvwPick);
			  this.Controls.Add(this.cmbRoster);
			  this.Controls.Add(this.menuStrip1);
			  this.Name = "frmDraft";
			  this.Text = "Draft Manager";
			  this.menuStrip1.ResumeLayout(false);
			  this.menuStrip1.PerformLayout();
			  this.ResumeLayout(false);
			  this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader PlayerPos6;
        private System.Windows.Forms.ColumnHeader RosterPos2;
        private System.Windows.Forms.ColumnHeader RosterSpace;
        private System.Windows.Forms.Button btnADP;
        private System.Windows.Forms.ColumnHeader RosterPos1;
        private System.Windows.Forms.TextBox textUp;
		private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ColumnHeader PlayerPos5;
        private System.Windows.Forms.ColumnHeader RosterPos3;
        private System.Windows.Forms.ColumnHeader PlayerPos4;
        private System.Windows.Forms.TextBox textNext;
        private System.Windows.Forms.ColumnHeader PlayerPos3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnTrade;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.ColumnHeader RosterPos4;
        private System.Windows.Forms.Button btnAlpha;
        private System.Windows.Forms.ColumnHeader RosterPos5;
        private System.Windows.Forms.Button btnValue;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ColumnHeader PickRound;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ColumnHeader PickTeam;
        private System.Windows.Forms.ColumnHeader RosterPos6;
        private System.Windows.Forms.ColumnHeader PickPlayer;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textComment;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader PlayerPos2;
        private System.Windows.Forms.ColumnHeader PlayerPos1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListView lvwPlayer;
        private System.Windows.Forms.ColumnHeader PlayerVal;
        private System.Windows.Forms.ListView lvwRoster;
        private System.Windows.Forms.ListView lvwPick;
        private System.Windows.Forms.ComboBox cmbRoster;
        private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem draftToolStripMenuItem;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.ToolStripMenuItem newDraftToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openDraftToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem generalInformationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem teamsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem averagesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rankingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem scoringToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem fTPInformationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem picksToolStripMenuItem;
		private System.Windows.Forms.Button btnPost;
		private System.Windows.Forms.Timer tmrClock;
		private System.Windows.Forms.Button btnCS;
    }
}