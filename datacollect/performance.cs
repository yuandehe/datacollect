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
    public partial class performance : Form
    {
        public performance()
        {
            InitializeComponent();
        }

        private void performance_Load(object sender, EventArgs e)
        {
            label2.Text = "快速查询材料牌号信息\n" + "模糊查询";
           DataTable dt = DataOperation.ExecQuery("select  DATA_ID,DATA_SORT1NAME,DATA_SORT2NAME, DATA_SERIESNAME from [materialbase]");
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
                dataGridView1.Rows[rowIndex].Selected = false;
                dataGridView1.Rows[rowIndex - 1].Selected = true;
            }
        }

        private void datano_TextChanged(object sender, EventArgs e)
        {
           
            DataTable dt     = DataOperation.ExecQuery("select  DATA_ID,DATA_SORT1NAME,DATA_SORT2NAME, DATA_SERIESNAME from [materialbase]   where DATA_ID  Like  '%" + datano.Text + "%'");
            this.dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string xx = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            performancecoll fm = new performancecoll(xx);
            fm.ShowDialog();
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
    }
}
