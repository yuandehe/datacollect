using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class datainput : Form
    {
        
        public datainput()
        {
            InitializeComponent();


           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void datainput_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            //使用DataSet绑定时，必须同时指明DateMember ，
            //
            //也可以直接用DataTable来绑定 this.dataGridView1.DataSource = Ds.Tables["T_Class"];
            DataTable dt = DataOperation.ExecQuery("select  *   from [commpany]");
            this.dataGridView1.DataSource = dt;
            //  this.dataGridView1.DataMember = "T_Class";
            this.dataGridView1.Columns[0].HeaderCell.Value = "序号";
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[1].HeaderCell.Value = "单位编码";
            this.dataGridView1.Columns[2].HeaderCell.Value = "单位名称";
            this.dataGridView1.Columns[3].HeaderCell.Value = "单位备注";
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            bindingNavigator1.BindingSource = bs;
             
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
