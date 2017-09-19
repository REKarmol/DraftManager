namespace DraftManager
{
	partial class frmAverage
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
			this.button1 = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.xlvScores = new DraftManager.ListViewEx();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(20, 480);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 30);
			this.button1.TabIndex = 22;
			this.button1.Text = "Import Averages";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(482, 476);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(83, 30);
			this.buttonCancel.TabIndex = 21;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(393, 476);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(83, 30);
			this.buttonOK.TabIndex = 20;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// xlvScores
			// 
			this.xlvScores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
			this.xlvScores.FullRowSelect = true;
			this.xlvScores.GridLines = true;
			this.xlvScores.Location = new System.Drawing.Point(20, 20);
			this.xlvScores.Name = "xlvScores";
			this.xlvScores.Size = new System.Drawing.Size(545, 450);
			this.xlvScores.TabIndex = 0;
			this.xlvScores.UseCompatibleStateImageBehavior = false;
			this.xlvScores.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Slot";
			this.columnHeader1.Width = 40;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "";
			this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "";
			this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "";
			this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "";
			this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "";
			this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// frmAverage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(588, 525);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.xlvScores);
			this.Name = "frmAverage";
			this.Text = "Historical Average Scores by Slot";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private ListViewEx xlvScores;
	}
}