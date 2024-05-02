namespace AlternativeMedicineFinder
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
			this.textBoxMedicine = new System.Windows.Forms.TextBox();
			this.label1Medicine = new System.Windows.Forms.Label();
			this.label2Medicine = new System.Windows.Forms.Label();
			this.buttonMedicine = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxMedicine
			// 
			this.textBoxMedicine.Location = new System.Drawing.Point(215, 90);
			this.textBoxMedicine.Name = "textBoxMedicine";
			this.textBoxMedicine.Size = new System.Drawing.Size(351, 31);
			this.textBoxMedicine.TabIndex = 0;
			// 
			// label1Medicine
			// 
			this.label1Medicine.AutoSize = true;
			this.label1Medicine.Location = new System.Drawing.Point(48, 90);
			this.label1Medicine.Name = "label1Medicine";
			this.label1Medicine.Size = new System.Drawing.Size(161, 25);
			this.label1Medicine.TabIndex = 1;
			this.label1Medicine.Text = "Medicine Name";
			this.label1Medicine.Click += new System.EventHandler(this.label1Medicine_Click);
			// 
			// label2Medicine
			// 
			this.label2Medicine.AutoSize = true;
			this.label2Medicine.BackColor = System.Drawing.SystemColors.Info;
			this.label2Medicine.Location = new System.Drawing.Point(43, 43);
			this.label2Medicine.Name = "label2Medicine";
			this.label2Medicine.Size = new System.Drawing.Size(534, 25);
			this.label2Medicine.TabIndex = 2;
			this.label2Medicine.Text = "Please write the medicine name to find the alternatives";
			this.label2Medicine.Click += new System.EventHandler(this.label2Medicine_Click);
			// 
			// buttonMedicine
			// 
			this.buttonMedicine.Location = new System.Drawing.Point(319, 137);
			this.buttonMedicine.Name = "buttonMedicine";
			this.buttonMedicine.Size = new System.Drawing.Size(149, 54);
			this.buttonMedicine.TabIndex = 3;
			this.buttonMedicine.Text = "FIND";
			this.buttonMedicine.UseVisualStyleBackColor = true;
			this.buttonMedicine.Click += new System.EventHandler(this.buttonMedicine_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(48, 228);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 82;
			this.dataGridView1.RowTemplate.Height = 33;
			this.dataGridView1.Size = new System.Drawing.Size(870, 620);
			this.dataGridView1.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1346, 815);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.buttonMedicine);
			this.Controls.Add(this.label2Medicine);
			this.Controls.Add(this.label1Medicine);
			this.Controls.Add(this.textBoxMedicine);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxMedicine;
		private System.Windows.Forms.Label label1Medicine;
		private System.Windows.Forms.Label label2Medicine;
		private System.Windows.Forms.Button buttonMedicine;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}

