namespace DraftManager
{
	partial class frmRanking
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
			this.bnImport = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.listViewExRankings = new DraftManager.ListViewEx();
			this.columnHeader31 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader28 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader29 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader30 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader27 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader32 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.comboBoxFFL = new System.Windows.Forms.ComboBox();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonPoints = new System.Windows.Forms.Button();
			this.buttonRank = new System.Windows.Forms.Button();
			this.comboBoxPosition = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// bnImport
			// 
			this.bnImport.Location = new System.Drawing.Point(90, 530);
			this.bnImport.Name = "bnImport";
			this.bnImport.Size = new System.Drawing.Size(120, 30);
			this.bnImport.TabIndex = 21;
			this.bnImport.Text = "Import Rankings";
			this.bnImport.UseVisualStyleBackColor = true;
			this.bnImport.Click += new System.EventHandler(this.button1_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(530, 530);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(80, 30);
			this.buttonCancel.TabIndex = 23;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(440, 530);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(80, 30);
			this.buttonOK.TabIndex = 22;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// listViewExRankings
			// 
			this.listViewExRankings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader31,
            this.columnHeader28,
            this.columnHeader29,
            this.columnHeader30,
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader27,
            this.columnHeader7,
            this.columnHeader6,
            this.columnHeader32});
			this.listViewExRankings.FullRowSelect = true;
			this.listViewExRankings.GridLines = true;
			this.listViewExRankings.Location = new System.Drawing.Point(16, 40);
			this.listViewExRankings.Name = "listViewExRankings";
			this.listViewExRankings.Size = new System.Drawing.Size(594, 480);
			this.listViewExRankings.TabIndex = 1;
			this.listViewExRankings.UseCompatibleStateImageBehavior = false;
			this.listViewExRankings.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader31
			// 
			this.columnHeader31.Text = "Pos";
			this.columnHeader31.Width = 42;
			// 
			// columnHeader28
			// 
			this.columnHeader28.Text = "Last";
			this.columnHeader28.Width = 97;
			// 
			// columnHeader29
			// 
			this.columnHeader29.Text = "First";
			// 
			// columnHeader30
			// 
			this.columnHeader30.Text = "NFL";
			this.columnHeader30.Width = 40;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Line#";
			this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader1.Width = 40;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "ADP";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// columnHeader27
			// 
			this.columnHeader27.Text = "Rank";
			this.columnHeader27.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader27.Width = 40;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Tier";
			this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader7.Width = 40;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Points";
			this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// columnHeader32
			// 
			this.columnHeader32.Text = "PPG";
			this.columnHeader32.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader32.Width = 53;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Risk";
			this.columnHeader2.Width = 40;
			// 
			// comboBoxFFL
			// 
			this.comboBoxFFL.FormattingEnabled = true;
			this.comboBoxFFL.Location = new System.Drawing.Point(20, 10);
			this.comboBoxFFL.Name = "comboBoxFFL";
			this.comboBoxFFL.Size = new System.Drawing.Size(354, 21);
			this.comboBoxFFL.TabIndex = 24;
			this.comboBoxFFL.SelectedIndexChanged += new System.EventHandler(this.comboBoxFFL_SelectedIndexChanged);
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(20, 530);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(60, 30);
			this.buttonClear.TabIndex = 25;
			this.buttonClear.Text = "Clear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonPoints
			// 
			this.buttonPoints.Location = new System.Drawing.Point(220, 530);
			this.buttonPoints.Name = "buttonPoints";
			this.buttonPoints.Size = new System.Drawing.Size(80, 30);
			this.buttonPoints.TabIndex = 26;
			this.buttonPoints.Text = "Points>PPG";
			this.buttonPoints.UseVisualStyleBackColor = true;
			this.buttonPoints.Click += new System.EventHandler(this.buttonPoints_Click);
			// 
			// buttonRank
			// 
			this.buttonRank.Location = new System.Drawing.Point(310, 530);
			this.buttonRank.Name = "buttonRank";
			this.buttonRank.Size = new System.Drawing.Size(70, 30);
			this.buttonRank.TabIndex = 27;
			this.buttonRank.Text = "Rank>PPG";
			this.buttonRank.UseVisualStyleBackColor = true;
			this.buttonRank.Click += new System.EventHandler(this.buttonRank_Click);
			// 
			// comboBoxPosition
			// 
			this.comboBoxPosition.FormattingEnabled = true;
			this.comboBoxPosition.Location = new System.Drawing.Point(380, 10);
			this.comboBoxPosition.Name = "comboBoxPosition";
			this.comboBoxPosition.Size = new System.Drawing.Size(234, 21);
			this.comboBoxPosition.TabIndex = 28;
			this.comboBoxPosition.SelectedIndexChanged += new System.EventHandler(this.comboBoxPosition_SelectedIndexChanged);
			// 
			// frmRanking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(627, 580);
			this.Controls.Add(this.comboBoxPosition);
			this.Controls.Add(this.buttonRank);
			this.Controls.Add(this.buttonPoints);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.comboBoxFFL);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.bnImport);
			this.Controls.Add(this.listViewExRankings);
			this.Name = "frmRanking";
			this.Text = "Team Rankings";
			this.ResumeLayout(false);

		}

		#endregion

		private ListViewEx listViewExRankings;
		private System.Windows.Forms.ColumnHeader columnHeader28;
		private System.Windows.Forms.ColumnHeader columnHeader29;
		private System.Windows.Forms.ColumnHeader columnHeader30;
		private System.Windows.Forms.ColumnHeader columnHeader31;
		private System.Windows.Forms.ColumnHeader columnHeader27;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader32;
        private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.Button bnImport;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ComboBox comboBoxFFL;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonPoints;
		private System.Windows.Forms.Button buttonRank;
		private System.Windows.Forms.ComboBox comboBoxPosition;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
	}
}