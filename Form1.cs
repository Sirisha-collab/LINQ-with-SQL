using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSql3Feb
{
	public partial class Form1 : Form
	{
		EmpDataContextDataContext dml = new EmpDataContextDataContext();
		public Form1()
		{
			InitializeComponent();
		}
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		private void ShowEmp()
		{
			var empTab = from e1 in dml.Employees
						 select e1;
			dataGridView1.DataSource = empTab;
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			ShowEmp();
			//var empTab = dml.Employees.Where(e1 => e1.EmpName.StartsWith("S") && e1.Salary>1000)
			//	.OrderByDescending(e1=>e1.EmpName);
			//dataGridView1.DataSource = empTab;
		}

		private void btnId_Click(object sender, EventArgs e)
		{
			var empDetails = dml.Sp_EmpDetails(Convert.ToInt32(textBox1.Text));
			dataGridView1.DataSource = empDetails;
		}

		private void btnEmp_Click(object sender, EventArgs e)
		{
			int? count = 0;
			dml.sp_WithOutput(ref count);
			lblCount.Text += count.ToString();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			var delemp = dml.Employees.Single(p => p.Eid == Convert.ToInt32(textBox1.Text));
			dml.Employees.DeleteOnSubmit(delemp);
			//imp to write as it will change in db else done locally only 
			dml.SubmitChanges();
			ShowEmp();
		}

		private void btnInsert_Click(object sender, EventArgs e)
		{
			var insemp = dml.Sp_InsertEmp(Convert.ToString(txtInsert.Text),
				Convert.ToSingle(txtSal.Text), Convert.ToInt32(txtdeptno.Text));
			dataGridView1.DataSource = insemp;
			ShowEmp();
		}

		private void lblId_Click(object sender, EventArgs e)
		{
			
		}

		private void btnUpd_Click(object sender, EventArgs e)
		{
			var updatemp = dml.Sp_UpdateEmp(Convert.ToInt32(txtIds.Text), Convert.ToString(txtNames.Text),
				Convert.ToSingle(txtSals.Text), Convert.ToInt32(txtDepts.Text));
			dataGridView1.DataSource = updatemp;		
			ShowEmp();

		}
	}
}
