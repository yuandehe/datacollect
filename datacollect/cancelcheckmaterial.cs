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
    public partial class cancelcheckmaterial : Form
    {
        DataTable dt = null;
        public cancelcheckmaterial()
        {
            InitializeComponent();
        }

        private void prev_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedRows[0].Index;  //得到当前选中行的索引

            if (rowIndex == 0)
            {
                MessageBox.Show("已经是第一行了!");
                return;
            }
            else
            {
                dataGridView1.Rows[rowIndex].Selected = false;
                dataGridView1.Rows[rowIndex - 1].Selected = true;
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedRows[0].Index;
            if (rowIndex == dataGridView1.Rows.Count - 1)
            {
                MessageBox.Show("已经是最后一行了!");
                return;
            }
            else
            {
                dataGridView1.Rows[rowIndex].Selected = false;
                dataGridView1.Rows[rowIndex + 1].Selected = true;
            }
        }

        private void datano_TextChanged(object sender, EventArgs e)
        {
            bulidcancelmaterial();
        }

        private void bulidcancelmaterial()
            {
                dt = DataOperation.ExecQuery("select  DATA_ID,DATA_SORT1NAME,DATA_SORT2NAME, DATA_SERIESNAME,AUDITING_NAME, AUDITING_YEAR&'-'&AUDITING_MONTH&'-'&Auditing_day as  AUDITINGtime from [materialbase]   where checked=1  and  DATA_ID  Like  '%" + datano.Text + "%'");
            this.dataGridView1.Columns.Clear();
            DataGridViewTextBoxColumn column0 = new DataGridViewTextBoxColumn();
            column0.DataPropertyName = "DATA_ID";//对应数据源的字段
            column0.Name = "DATA_ID";
            column0.HeaderText = "材料牌号";
            column0.Width = 200;
            this.dataGridView1.Columns.Add(column0);


            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "DATA_SORT1NAME";//对应数据源的字段
            column1.HeaderText = "材料类别";
            column1.Width = 150;
            this.dataGridView1.Columns.Add(column1);

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.DataPropertyName = "DATA_SORT2NAME";//对应数据源的字段
            column2.HeaderText = "材料种类";
            column2.Width = 200;
            this.dataGridView1.Columns.Add(column2);

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.DataPropertyName = "DATA_SERIESNAME";//对应数据源的字段
            column3.HeaderText = "材料种类";
            column3.Width = 200;
            this.dataGridView1.Columns.Add(column3);

            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.DataPropertyName = "AUDITING_NAME";//对应数据源的字段
            column4.HeaderText = "审核人";
            column4.Width = 200;
            this.dataGridView1.Columns.Add(column4);

            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            column5.DataPropertyName = "AUDITINGtime";//对应数据源的字段
            column5.HeaderText = "审核日期";
            column5.Width = 200;
            this.dataGridView1.Columns.Add(column5);



            DataGridViewCheckBoxColumn column6 = new DataGridViewCheckBoxColumn();
            column6.HeaderText = "取消审核？";
            column6.Name = "Select";
            column6.DataPropertyName = "Select";
            column6.ReadOnly = false;
            column6.TrueValue = true;
            column6.FalseValue = false;

            this.dataGridView1.Columns.Add(column6);
            this.dataGridView1.DataSource = dt;
         
    }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < this.dataGridView1.RowCount; i++)
            {
                this.dataGridView1.Rows[i].Cells["select"].Value = "true";//如果为true则为选中,false未选中
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < this.dataGridView1.RowCount; i++)
            {
                this.dataGridView1.Rows[i].Cells["select"].Value = "false";//如果为true则为选中,false未选中
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < this.dataGridView1.RowCount; i++)
            {
                if (this.dataGridView1.Rows[i].Cells["Select"].Value == null) continue;

                if (Convert.ToBoolean(this.dataGridView1.Rows[i].Cells["Select"].Value))
                {
                    DataOperation.Execsql("update   materialbase  set checked=0  where  DATA_ID='" + dataGridView1.Rows[i].Cells["DATA_ID"].Value + "'");
                }
            }

            bulidcancelmaterial();
        }

        private void cancelcheckmaterial_Load(object sender, EventArgs e)
        {
            bulidcancelmaterial();
        }
    }
}
