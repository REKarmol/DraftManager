namespace DraftManager
{
	partial class frmBasic
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
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
		private void InitializeComponent ()
		{
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.comboBoxStyle = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxTeams = new System.Windows.Forms.TextBox();
			this.textBoxRounds = new System.Windows.Forms.TextBox();
			this.textBoxTimer = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxMin = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxCap = new System.Windows.Forms.TextBox();
			this.xlvNFL = new DraftManager.ListViewEx();
			this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
			this.xlvPOS = new DraftManager.ListViewEx();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "# Teams:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "# Rounds:";
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(627, 560);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(83, 25);
			this.buttonCancel.TabIndex = 11;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(538, 560);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(83, 25);
			this.buttonOK.TabIndex = 10;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(8, 77);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(67, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Timer (secs):";
			// 
			// comboBoxStyle
			// 
			this.comboBoxStyle.FormattingEnabled = true;
			this.comboBoxStyle.Location = new System.Drawing.Point(80, 100);
			this.comboBoxStyle.Name = "comboBoxStyle";
			this.comboBoxStyle.Size = new System.Drawing.Size(160, 21);
			this.comboBoxStyle.TabIndex = 31;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 103);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(33, 13);
			this.label6.TabIndex = 32;
			this.label6.Text = "Style:";
			// 
			// textBoxTeams
			// 
			this.textBoxTeams.Location = new System.Drawing.Point(80, 24);
			this.textBoxTeams.Name = "textBoxTeams";
			this.textBoxTeams.Size = new System.Drawing.Size(32, 20);
			this.textBoxTeams.TabIndex = 37;
			this.textBoxTeams.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBoxRounds
			// 
			this.textBoxRounds.Location = new System.Drawing.Point(80, 48);
			this.textBoxRounds.Name = "textBoxRounds";
			this.textBoxRounds.Size = new System.Drawing.Size(32, 20);
			this.textBoxRounds.TabIndex = 38;
			this.textBoxRounds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBoxTimer
			// 
			this.textBoxTimer.Location = new System.Drawing.Point(80, 74);
			this.textBoxTimer.Name = "textBoxTimer";
			this.textBoxTimer.Size = new System.Drawing.Size(32, 20);
			this.textBoxTimer.TabIndex = 41;
			this.textBoxTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.textBoxMin);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.textBoxCap);
			this.groupBox1.Controls.Add(this.comboBoxStyle);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.textBoxTimer);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.textBoxRounds);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.textBoxTeams);
			this.groupBox1.Location = new System.Drawing.Point(16, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(246, 184);
			this.groupBox1.TabIndex = 44;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "General Information";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 156);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(69, 13);
			this.label9.TabIndex = 56;
			this.label9.Text = "Minimum Bid:";
			// 
			// textBoxMin
			// 
			this.textBoxMin.Location = new System.Drawing.Point(80, 153);
			this.textBoxMin.Name = "textBoxMin";
			this.textBoxMin.Size = new System.Drawing.Size(49, 20);
			this.textBoxMin.TabIndex = 55;
			this.textBoxMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(14, 130);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(61, 13);
			this.label8.TabIndex = 54;
			this.label8.Text = "Salary Cap:";
			// 
			// textBoxCap
			// 
			this.textBoxCap.Location = new System.Drawing.Point(80, 127);
			this.textBoxCap.Name = "textBoxCap";
			this.textBoxCap.Size = new System.Drawing.Size(49, 20);
			this.textBoxCap.TabIndex = 53;
			this.textBoxCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// xlvNFL
			// 
			this.xlvNFL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
			this.xlvNFL.FullRowSelect = true;
			this.xlvNFL.GridLines = true;
			this.xlvNFL.Location = new System.Drawing.Point(16, 200);
			this.xlvNFL.MultiSelect = false;
			this.xlvNFL.Name = "xlvNFL";
			this.xlvNFL.Size = new System.Drawing.Size(694, 348);
			this.xlvNFL.TabIndex = 43;
			this.xlvNFL.UseCompatibleStateImageBehavior = false;
			this.xlvNFL.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "NFL";
			this.columnHeader11.Width = 40;
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "City";
			this.columnHeader12.Width = 80;
			// 
			// columnHeader13
			// 
			this.columnHeader13.Text = "Team";
			this.columnHeader13.Width = 80;
			// 
			// columnHeader14
			// 
			this.columnHeader14.Text = "Bye";
			this.columnHeader14.Width = 40;
			// 
			// columnHeader15
			// 
			this.columnHeader15.Text = "Matches (for imports)";
			this.columnHeader15.Width = 430;
			// 
			// xlvPOS
			// 
			this.xlvPOS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader3});
			this.xlvPOS.FullRowSelect = true;
			this.xlvPOS.GridLines = true;
			this.xlvPOS.Location = new System.Drawing.Point(268, 12);
			this.xlvPOS.MultiSelect = false;
			this.xlvPOS.Name = "xlvPOS";
			this.xlvPOS.Size = new System.Drawing.Size(442, 171);
			this.xlvPOS.TabIndex = 42;
			this.xlvPOS.UseCompatibleStateImageBehavior = false;
			this.xlvPOS.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Tag = "";
			this.columnHeader1.Text = "Pos";
			this.columnHeader1.Width = 40;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Group";
			this.columnHeader6.Width = 50;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Grp #";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 45;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Min #";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader4.Width = 45;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Max #";
			this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader5.Width = 45;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Matches (for imports)";
			this.columnHeader3.Width = 195;
			// 
			// frmBasic
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(725, 603);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.xlvNFL);
			this.Controls.Add(this.xlvPOS);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Name = "frmBasic";
			this.Text = "General Information, Positions, and NFL Teams";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comboBoxStyle;
        private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxTeams;
        private System.Windows.Forms.TextBox textBoxRounds;
		private System.Windows.Forms.TextBox textBoxTimer;
        private ListViewEx xlvPOS;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private ListViewEx xlvNFL;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBoxMin;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBoxCap;
		private System.Windows.Forms.ColumnHeader columnHeader6;
	}
}