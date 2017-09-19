namespace DraftManager
{
	partial class frmTeam
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
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.xlvConfidence = new DraftManager.ListViewEx();
			this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.xlvComments = new DraftManager.ListViewEx();
			this.columnHeader41 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader17 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader18 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader19 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader20 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader21 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader42 = new System.Windows.Forms.ColumnHeader();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.xlvWeight = new DraftManager.ListViewEx();
			this.columnHeader22 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader25 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader26 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader27 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader28 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.xlvTeams = new DraftManager.ListViewEx();
			this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader16 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(703, 721);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(83, 30);
			this.buttonCancel.TabIndex = 14;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(614, 721);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(83, 30);
			this.buttonOK.TabIndex = 13;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(24, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 13);
			this.label5.TabIndex = 33;
			this.label5.Text = "Select a Team:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.xlvConfidence);
			this.groupBox1.Location = new System.Drawing.Point(383, 20);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(117, 240);
			this.groupBox1.TabIndex = 34;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Pos Conf%";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 220);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 28;
			this.label1.Text = "0.5 = 50%\r\n";
			// 
			// xlvConfidence
			// 
			this.xlvConfidence.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader15});
			this.xlvConfidence.FullRowSelect = true;
			this.xlvConfidence.GridLines = true;
			this.xlvConfidence.Location = new System.Drawing.Point(8, 19);
			this.xlvConfidence.Name = "xlvConfidence";
			this.xlvConfidence.Size = new System.Drawing.Size(102, 191);
			this.xlvConfidence.TabIndex = 27;
			this.xlvConfidence.UseCompatibleStateImageBehavior = false;
			this.xlvConfidence.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader14
			// 
			this.columnHeader14.Text = "Pos";
			this.columnHeader14.Width = 35;
			// 
			// columnHeader15
			// 
			this.columnHeader15.Text = "Conf %";
			this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader15.Width = 45;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.xlvComments);
			this.groupBox2.Location = new System.Drawing.Point(24, 272);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(762, 443);
			this.groupBox2.TabIndex = 35;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Round Information for Selected Team";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 401);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(171, 26);
			this.label2.TabIndex = 30;
			this.label2.Text = "Enter position limits by round, if any\r\nEnter comment by round, if any";
			// 
			// xlvComments
			// 
			this.xlvComments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader41,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader42});
			this.xlvComments.FullRowSelect = true;
			this.xlvComments.GridLines = true;
			this.xlvComments.Location = new System.Drawing.Point(6, 21);
			this.xlvComments.Name = "xlvComments";
			this.xlvComments.Size = new System.Drawing.Size(750, 373);
			this.xlvComments.TabIndex = 29;
			this.xlvComments.UseCompatibleStateImageBehavior = false;
			this.xlvComments.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader41
			// 
			this.columnHeader41.Text = "Round";
			this.columnHeader41.Width = 51;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "";
			this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader10.Width = 40;
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "";
			this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader11.Width = 40;
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "";
			this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader12.Width = 40;
			// 
			// columnHeader13
			// 
			this.columnHeader13.Text = "";
			this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader13.Width = 40;
			// 
			// columnHeader17
			// 
			this.columnHeader17.Text = "";
			this.columnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader17.Width = 40;
			// 
			// columnHeader18
			// 
			this.columnHeader18.Text = "";
			this.columnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader18.Width = 40;
			// 
			// columnHeader19
			// 
			this.columnHeader19.Text = "";
			this.columnHeader19.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader19.Width = 40;
			// 
			// columnHeader20
			// 
			this.columnHeader20.Text = "";
			this.columnHeader20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader20.Width = 40;
			// 
			// columnHeader21
			// 
			this.columnHeader21.Text = "";
			this.columnHeader21.Width = 5;
			// 
			// columnHeader42
			// 
			this.columnHeader42.Text = "Comment";
			this.columnHeader42.Width = 349;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.xlvWeight);
			this.groupBox3.Location = new System.Drawing.Point(510, 20);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(270, 240);
			this.groupBox3.TabIndex = 37;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Group Weight by Depth (1st=Starters)";
			// 
			// xlvWeight
			// 
			this.xlvWeight.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader22,
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader27,
            this.columnHeader28,
            this.columnHeader1,
            this.columnHeader2});
			this.xlvWeight.FullRowSelect = true;
			this.xlvWeight.GridLines = true;
			this.xlvWeight.Location = new System.Drawing.Point(10, 20);
			this.xlvWeight.Name = "xlvWeight";
			this.xlvWeight.Size = new System.Drawing.Size(276, 190);
			this.xlvWeight.TabIndex = 29;
			this.xlvWeight.UseCompatibleStateImageBehavior = false;
			this.xlvWeight.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader22
			// 
			this.columnHeader22.Text = "Group";
			this.columnHeader22.Width = 42;
			// 
			// columnHeader25
			// 
			this.columnHeader25.Text = "1st";
			this.columnHeader25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader25.Width = 35;
			// 
			// columnHeader26
			// 
			this.columnHeader26.Text = "2nd";
			this.columnHeader26.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader26.Width = 35;
			// 
			// columnHeader27
			// 
			this.columnHeader27.Text = "3rd";
			this.columnHeader27.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader27.Width = 35;
			// 
			// columnHeader28
			// 
			this.columnHeader28.Text = "4th";
			this.columnHeader28.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader28.Width = 35;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "5th";
			this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader1.Width = 35;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "6th";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader2.Width = 35;
			// 
			// xlvTeams
			// 
			this.xlvTeams.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader6,
            this.columnHeader16,
            this.columnHeader3});
			this.xlvTeams.FullRowSelect = true;
			this.xlvTeams.GridLines = true;
			this.xlvTeams.Location = new System.Drawing.Point(24, 25);
			this.xlvTeams.MultiSelect = false;
			this.xlvTeams.Name = "xlvTeams";
			this.xlvTeams.Size = new System.Drawing.Size(353, 240);
			this.xlvTeams.TabIndex = 0;
			this.xlvTeams.UseCompatibleStateImageBehavior = false;
			this.xlvTeams.View = System.Windows.Forms.View.Details;
			this.xlvTeams.SelectedIndexChanged += new System.EventHandler(this.xlvTeams_SelectedIndexChanged);
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "#";
			this.columnHeader9.Width = 30;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Team";
			this.columnHeader6.Width = 78;
			// 
			// columnHeader16
			// 
			this.columnHeader16.Text = "Owner";
			this.columnHeader16.Width = 67;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Email";
			this.columnHeader3.Width = 171;
			// 
			// frmTeam
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(798, 767);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.xlvTeams);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Name = "frmTeam";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
		private ListViewEx xlvTeams;
        private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader9;
        private ListViewEx xlvConfidence;
        private System.Windows.Forms.ColumnHeader columnHeader14;
		private System.Windows.Forms.ColumnHeader columnHeader15;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ColumnHeader columnHeader16;
		private ListViewEx xlvComments;
		private System.Windows.Forms.ColumnHeader columnHeader41;
		private System.Windows.Forms.ColumnHeader columnHeader42;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ColumnHeader columnHeader12;
		private System.Windows.Forms.ColumnHeader columnHeader13;
		private System.Windows.Forms.ColumnHeader columnHeader17;
		private System.Windows.Forms.ColumnHeader columnHeader18;
		private System.Windows.Forms.ColumnHeader columnHeader19;
		private System.Windows.Forms.ColumnHeader columnHeader20;
		private System.Windows.Forms.ColumnHeader columnHeader21;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private ListViewEx xlvWeight;
		private System.Windows.Forms.ColumnHeader columnHeader22;
		private System.Windows.Forms.ColumnHeader columnHeader25;
		private System.Windows.Forms.ColumnHeader columnHeader26;
		private System.Windows.Forms.ColumnHeader columnHeader27;
		private System.Windows.Forms.ColumnHeader columnHeader28;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ColumnHeader columnHeader3;
	}
}