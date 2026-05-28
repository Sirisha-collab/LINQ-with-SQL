namespace LinqToSql3Feb
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.lblId = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnId = new System.Windows.Forms.Button();
			this.lblCount = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnEmp = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnInsert = new System.Windows.Forms.Button();
			this.txtInsert = new System.Windows.Forms.TextBox();
			this.txtdeptno = new System.Windows.Forms.TextBox();
			this.txtSal = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnUpd = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtIds = new System.Windows.Forms.TextBox();
			this.txtNames = new System.Windows.Forms.TextBox();
			this.txtSals = new System.Windows.Forms.TextBox();
			this.txtDepts = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(145, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(523, 192);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Location = new System.Drawing.Point(634, 269);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(62, 13);
			this.lblId.TabIndex = 1;
			this.lblId.Text = "EmployeeId";
			this.lblId.Click += new System.EventHandler(this.lblId_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(735, 269);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 2;
			// 
			// btnId
			// 
			this.btnId.Location = new System.Drawing.Point(327, 401);
			this.btnId.Name = "btnId";
			this.btnId.Size = new System.Drawing.Size(183, 37);
			this.btnId.TabIndex = 3;
			this.btnId.Text = "ShowDetails";
			this.btnId.UseVisualStyleBackColor = true;
			this.btnId.Click += new System.EventHandler(this.btnId_Click);
			// 
			// lblCount
			// 
			this.lblCount.AutoSize = true;
			this.lblCount.Location = new System.Drawing.Point(22, 95);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(56, 13);
			this.lblCount.TabIndex = 4;
			this.lblCount.Text = "CountEmp";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(83, 222);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Name";
			// 
			// btnEmp
			// 
			this.btnEmp.Location = new System.Drawing.Point(12, 27);
			this.btnEmp.Name = "btnEmp";
			this.btnEmp.Size = new System.Drawing.Size(120, 37);
			this.btnEmp.TabIndex = 6;
			this.btnEmp.Text = "NoOfEmployee";
			this.btnEmp.UseVisualStyleBackColor = true;
			this.btnEmp.Click += new System.EventHandler(this.btnEmp_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(653, 349);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(118, 32);
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "DeleteEmp";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnInsert
			// 
			this.btnInsert.Location = new System.Drawing.Point(98, 349);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(135, 32);
			this.btnInsert.TabIndex = 8;
			this.btnInsert.Text = "InsertEmp";
			this.btnInsert.UseVisualStyleBackColor = true;
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// txtInsert
			// 
			this.txtInsert.Location = new System.Drawing.Point(205, 215);
			this.txtInsert.Name = "txtInsert";
			this.txtInsert.Size = new System.Drawing.Size(100, 20);
			this.txtInsert.TabIndex = 9;
			// 
			// txtdeptno
			// 
			this.txtdeptno.Location = new System.Drawing.Point(205, 303);
			this.txtdeptno.Name = "txtdeptno";
			this.txtdeptno.Size = new System.Drawing.Size(100, 20);
			this.txtdeptno.TabIndex = 10;
			// 
			// txtSal
			// 
			this.txtSal.Location = new System.Drawing.Point(205, 259);
			this.txtSal.Name = "txtSal";
			this.txtSal.Size = new System.Drawing.Size(100, 20);
			this.txtSal.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(83, 259);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Salary";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(83, 306);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "DeptNo";
			// 
			// btnUpd
			// 
			this.btnUpd.Location = new System.Drawing.Point(346, 349);
			this.btnUpd.Name = "btnUpd";
			this.btnUpd.Size = new System.Drawing.Size(149, 32);
			this.btnUpd.TabIndex = 14;
			this.btnUpd.Text = "UpdateEmp";
			this.btnUpd.UseVisualStyleBackColor = true;
			this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(392, 219);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "EmployeeId";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(392, 255);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 13);
			this.label5.TabIndex = 16;
			this.label5.Text = "Name";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(392, 289);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 13);
			this.label6.TabIndex = 17;
			this.label6.Text = "Salary";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(392, 319);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(44, 13);
			this.label7.TabIndex = 18;
			this.label7.Text = "DeptNo";
			// 
			// txtIds
			// 
			this.txtIds.Location = new System.Drawing.Point(482, 219);
			this.txtIds.Name = "txtIds";
			this.txtIds.Size = new System.Drawing.Size(100, 20);
			this.txtIds.TabIndex = 19;
			// 
			// txtNames
			// 
			this.txtNames.Location = new System.Drawing.Point(482, 252);
			this.txtNames.Name = "txtNames";
			this.txtNames.Size = new System.Drawing.Size(100, 20);
			this.txtNames.TabIndex = 20;
			// 
			// txtSals
			// 
			this.txtSals.Location = new System.Drawing.Point(482, 289);
			this.txtSals.Name = "txtSals";
			this.txtSals.Size = new System.Drawing.Size(100, 20);
			this.txtSals.TabIndex = 21;
			// 
			// txtDepts
			// 
			this.txtDepts.Location = new System.Drawing.Point(482, 323);
			this.txtDepts.Name = "txtDepts";
			this.txtDepts.Size = new System.Drawing.Size(100, 20);
			this.txtDepts.TabIndex = 22;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(847, 450);
			this.Controls.Add(this.txtDepts);
			this.Controls.Add(this.txtSals);
			this.Controls.Add(this.txtNames);
			this.Controls.Add(this.txtIds);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnUpd);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtSal);
			this.Controls.Add(this.txtdeptno);
			this.Controls.Add(this.txtInsert);
			this.Controls.Add(this.btnInsert);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEmp);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblCount);
			this.Controls.Add(this.btnId);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnId;
		private System.Windows.Forms.Label lblCount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnEmp;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.TextBox txtInsert;
		private System.Windows.Forms.TextBox txtdeptno;
		private System.Windows.Forms.TextBox txtSal;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnUpd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtIds;
		private System.Windows.Forms.TextBox txtNames;
		private System.Windows.Forms.TextBox txtSals;
		private System.Windows.Forms.TextBox txtDepts;
	}
}

