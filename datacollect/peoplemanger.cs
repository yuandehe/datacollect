using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class peoplemanger : Form
    {
        public peoplemanger()
        {
            InitializeComponent();
        }

        private void peoplemanger_Load(object sender, EventArgs e)
        {
            buildcomm(" pname like '%" + stext.Text + "%'");
            buildpeople();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioname.Checked)
            buildcomm(" pname like '%" + stext.Text + "%'");
            if (radiocode.Checked)
                buildcomm(" pname like '%" + stext.Text + "%'");
        }

        private   void   buildcomm(string  xx)
        {
            DataTable dt = DataOperation.ExecQuery("select  pname,Code  from commpany  where  "+xx);


            DataGridViewTextBoxColumn column0 = new DataGridViewTextBoxColumn();
            column0.DataPropertyName = "pname";//对应数据源的字段
            column0.Width = 200;
            column0.HeaderText = "单位名称";
            this.dataGridView2.Columns.Add(column0);


            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "Code";//对应数据源的字段
            column1.HeaderText = "单位代码";
            column1.Width = 200;
            this.dataGridView2.Columns.Add(column1);
            dataGridView2.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView2.SelectedRows[0].Index;  //得到当前选中行的索引

            if (rowIndex == 0)
            {
                MessageBox.Show("已经是第一行了!");
                return;
            }
            else
            {
                dataGridView2.Rows[rowIndex].Selected = false;
                dataGridView2.Rows[rowIndex - 1].Selected = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView2.SelectedRows[0].Index;
            if (rowIndex == dataGridView2.Rows.Count - 1)
            {
                MessageBox.Show("已经是最后一行了!");
                return;
            }
            else
            {
                dataGridView2.Rows[rowIndex].Selected = false;
                dataGridView2.Rows[rowIndex + 1].Selected = true;
            }
        }

        private void buildpeople()
        {
            DataTable dt = DataOperation.ExecQuery("select  *  from people   "  );

            DataGridViewTextBoxColumn column01 = new DataGridViewTextBoxColumn();
            column01.DataPropertyName = "id";//对应数据源的字段
            column01.Visible = false;
            this.dataGridView1.Columns.Add(column01);

            DataGridViewComboBoxColumn column1 = new DataGridViewComboBoxColumn();
            column1.DataPropertyName = "comname";//对应数据源的字段
            column1.Width = 200;
            column1.HeaderText = "单位名称";
            column1.DataSource= DataOperation.ExecQuery("select  pname  from commpany  order  by pname   ");
            column1.DisplayMember = "pname";
            column1.ValueMember = "pname";
            this.dataGridView1.Columns.Add(column1);

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.DataPropertyName = "pname";//对应数据源的字段
            column2.HeaderText = "姓名";
            column2.Width = 100;
            this.dataGridView1.Columns.Add(column2);

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.DataPropertyName = "birthday";//对应数据源的字段
            column3.HeaderText = "出生日期";
            column3.Width = 100;
            column3.DefaultCellStyle.Format = "yyy-M-d";
            this.dataGridView1.Columns.Add(column3);


            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.DataPropertyName = "tel";//对应数据源的字段
            column4.HeaderText = "办公电话";
            column4.Width = 200;
            this.dataGridView1.Columns.Add(column4);

            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            column5.DataPropertyName = "hometel";//对应数据源的字段
            column5.HeaderText = "家庭电话";
            column5.Width = 200;
            this.dataGridView1.Columns.Add(column5);

            DataGridViewTextBoxColumn column6 = new DataGridViewTextBoxColumn();
            column6.DataPropertyName = "mobile";//对应数据源的字段
            column6.HeaderText = "移动电话";
            column6.Width = 200;
            this.dataGridView1.Columns.Add(column6);

            DataGridViewTextBoxColumn column7 = new DataGridViewTextBoxColumn();
            column7.DataPropertyName = "email";//对应数据源的字段
            column7.HeaderText = "电子邮件";
            column7.Width = 200;
            this.dataGridView1.Columns.Add(column7);
            DataGridViewTextBoxColumn column8 = new DataGridViewTextBoxColumn();
            column8.DataPropertyName = "professional";//对应数据源的字段
            column8.HeaderText = "专业专长";
            column8.Width = 200;
            this.dataGridView1.Columns.Add(column8);




            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String sql = "";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString().Length > 0)
                {
                    sql = "update  people   set  comname='" + dataGridView1.Rows[i].Cells[1].Value + "',pname='" + dataGridView1.Rows[i].Cells[2].Value +
                        "',birthday='" + dataGridView1.Rows[i].Cells[3].Value + "',tel='" + dataGridView1.Rows[i].Cells[4].Value+ "',hometel='" + dataGridView1.Rows[i].Cells[5].Value +
                       "',mobile='" + dataGridView1.Rows[i].Cells[6].Value + "',email='" + dataGridView1.Rows[i].Cells[7].Value + "',professional='" + dataGridView1.Rows[i].Cells[8].Value +
                        "'  where Id=" + dataGridView1.Rows[i].Cells[0].Value;
                }
                else
                {
                    sql = "insert  into people(comname,pname,birthday,tel,hometel,mobile,email,professional)  values ('" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value +
                        "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value +
                       "','" + dataGridView1.Rows[i].Cells[6].Value + "','" + dataGridView1.Rows[i].Cells[7].Value + "','" + dataGridView1.Rows[i].Cells[8].Value+"')";
                }
                DataOperation.Execsql(sql);
            }
             
            buildpeople( );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable xx = (DataTable)dataGridView1.DataSource;
            DataRow dr = xx.NewRow();
            xx.Rows.Add(dr);
            dataGridView1.DataSource = xx;
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2];
            dataGridView1.BeginEdit(false);
            TextBox tb = (TextBox)dataGridView1.EditingControl;
            tb.SelectionStart = 0;
            dataGridView1.Enabled = true;
        }
    }
}
