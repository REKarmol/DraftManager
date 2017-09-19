namespace DraftManager
{
	partial class frmScoring
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
			this.listViewEx1 = new DraftManager.ListViewEx();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listViewEx1
			// 
			this.listViewEx1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.listViewEx1.FullRowSelect = true;
			this.listViewEx1.GridLines = true;
			this.listViewEx1.Location = new System.Drawing.Point(12, 12);
			this.listViewEx1.Name = "listViewEx1";
			this.listViewEx1.Size = new System.Drawing.Size(204, 545);
			this.listViewEx1.TabIndex = 0;
			this.listViewEx1.UseCompatibleStateImageBehavior = false;
			this.listViewEx1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Category";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Position";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Value";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(133, 563);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(83, 30);
			this.buttonCancel.TabIndex = 16;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(44, 563);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(83, 30);
			this.buttonOK.TabIndex = 15;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// frmScoring
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(235, 619);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.listViewEx1);
			this.Name = "frmScoring";
			this.Text = "Scoring Categories";
			this.ResumeLayout(false);

		}

		#endregion

		private ListViewEx listViewEx1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
	}
}