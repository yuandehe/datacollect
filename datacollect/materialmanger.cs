using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp1
{
    public partial class materialmanger : Form
    {
       private DataTable dt = null;
        public materialmanger()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label4.Text = "快速查询材料牌号信息：\n(模糊查询)";
            label6.Text = "注意在输入上下标时，如n\x00B2,请以n<sup>2</sup>代替";
            label3.Text = "共有未审核牌号" + DataOperation.ExecQuery("select id  from materialbase  where checked=0 ").Rows.Count + "个" + "已审核牌号" + DataOperation.ExecQuery("select id  from materialbase  where checked=1 ").Rows.Count + "个";
            dt = DataOperation.ExecQuery("select  DATA_ID,DATA_SORT1NAME,DATA_SORT2NAME, DATA_SERIESNAME from [materialbase]");
            this.dataGridView1.DataSource = dt;
            //  this.dataGridView1.DataMember = "T_Class";
            this.dataGridView1.Columns[0].HeaderCell.Value = "材料牌号";
            this.dataGridView1.Columns[0].Width = 200;
            this.dataGridView1.Columns[1].HeaderCell.Value = "材料类别";
            this.dataGridView1.Columns[1].Width = 150;
            this.dataGridView1.Columns[2].HeaderCell.Value = "材料种类";
            this.dataGridView1.Columns[2].Width = 150;
            this.dataGridView1.Columns[3].HeaderCell.Value = "材料系列";
            this.dataGridView1.Columns[3].Width = 200;
            //  导入特殊符号数据
           StreamReader st = new StreamReader("tools.txt", Encoding.GetEncoding("utf-8"));
            string str = st.ReadLine();
            string specstr = null;
            while (str != null)
            {
                
                string yyy = str.Substring(0, 2);

                if (str.Substring(0,2).Equals("//"))
               
                    specstr = specstr + "   " + str.Substring(2);
                str = st.ReadLine();
            }
            textBox2.Text = specstr;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void datano_TextChanged(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            dt = DataOperation.ExecQuery("select  DATA_ID,DATA_SORT1NAME,DATA_SORT2NAME, DATA_SERIESNAME from [materialbase]   where DATA_ID  Like  '%" + datano.Text + "%'");
            this.dataGridView1.DataSource = dt;


            //  this.dataGridView1.DataMember = "T_Class";

        }

        private void datano_Leave(object sender, EventArgs e)
        {
            if (dt.Rows.Count == 0)
            {
                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show("添加该号牌数据?", "取消", messButton);
                if (dr == DialogResult.OK)//如果点击“确定”按钮
                {
                    DataOperation.Execsql("insert  into [materialbase]([DATA_ID])  values   ('" + datano.Text + "')");


                    dt.Rows.Clear();
                    dt = DataOperation.ExecQuery("select  DATA_ID,DATA_SORT1,DATA_SORT2, DATA_SERIES from [materialbase]   where DATA_ID  Like  '%" + datano.Text + "%'");
                    this.dataGridView1.DataSource = dt;
                }
                else//如果点击“取消”按钮
                {

                }
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X,
        e.RowBounds.Location.Y,
        dataGridView1.RowHeadersWidth - 4,
        e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dataGridView1.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dataGridView1.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void datano_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (dt.Rows.Count == 0)
                {
                    MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                    DialogResult dr = MessageBox.Show("添加该号牌数据?", "取消", messButton);
                    if (dr == DialogResult.OK)//如果点击“确定”按钮
                    {
                        DataOperation.Execsql("insert  into [materialbase]([DATA_ID])  values   ('" + datano.Text + "')");
                        dt.Rows.Clear();
                        dt = DataOperation.ExecQuery("select  DATA_ID,DATA_SORT1,DATA_SORT2, DATA_SERIES from [materialbase]   where DATA_ID  Like  '%" + datano.Text + "%'");
                        this.dataGridView1.DataSource = dt;
                    }
                    else//如果点击“取消”按钮
                    {

                    }
                }
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
                dataGridView1.Rows[rowIndex ].Selected = false;
                dataGridView1.Rows[rowIndex-1].Selected = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string xx = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            materialedit fm = new materialedit(xx);
            fm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            dt = DataOperation.ExecQuery("select  DATA_ID,DATA_SORT1NAME,DATA_SORT2NAME, DATA_SERIESNAME from [materialbase]   where DATA_ID  Like  '%" + searchtext.Text + "%'");
            this.dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string xx = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            materialedit fm = new materialedit(xx);
            fm.ShowDialog();
        }
    }
}
