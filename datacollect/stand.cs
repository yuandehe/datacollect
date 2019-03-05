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
    public partial class stand : Form
    {
        DataTable dt = null;
        int rows = 0;
        int addtag = 0;
        public stand()
        {
            InitializeComponent();
        }

        private void stand_Load(object sender, EventArgs e)
        {
            bulidstand();
        }

        private void add_Click(object sender, EventArgs e)
        {
            standardno.Text = "";
            standardname.Text = "";
            standardtext.Text = "";
            standardmemo.Text = "";
            addtag = 1;
            standardno.Focus();
        }

        private void bulidstand()
        {
            dt = DataOperation.ExecQuery("Select *  from  standard  where  STANDARD_NUM like   '%" + instandno.Text + "%'  " + " order  by STANDARD_NUM ");
            if (dt.Rows.Count == 0) return;
            no.Text = "序号" + "1/" + dt.Rows.Count;
            standardno.Text = dt.Rows[0][1].ToString();
            standardname.Text = dt.Rows[0][2].ToString();
            standardtext.Text = dt.Rows[0][3].ToString();
            standardmemo.Text = dt.Rows[0][4].ToString();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if ((DataOperation.ExecQuery("Select *  from  standard  where  STANDARD_NUM ='" + standardno.Text + "'").Rows.Count > 0) && (addtag == 1))
            {
                MessageBox.Show("已经添加此标准文件了！");
                return  ;
            }
            if ((DataOperation.ExecQuery("Select *  from  standard  where  STANDARD_NUM ='" + standardno.Text + "'").Rows.Count == 0) && (addtag == 1))
            {  
                DataOperation.Execsql("insert  into standard(STANDARD_NUM,STANDARD_NAME,STANDARD_text,MTEXT) values('" + standardno.Text + "','" + standardname.Text + "','" +
                 standardtext.Text + "','" + standardmemo.Text + "')");
            }
            if ((DataOperation.ExecQuery("Select *  from  standard  where  STANDARD_NUM ='" + standardno.Text + "'").Rows.Count > 0) && (addtag == 0))
            {
                DataOperation.Execsql(" update standard  set STANDARD_NUM='"+ standardno.Text + "',STANDARD_NAME='" + standardname.Text+"',STANDARD_text='" + standardtext.Text+"', MTEXT=" + standardmemo.Text + "'   where  id ="+dt.Rows[rows][0].ToString());

            }
        }

        private void instandno_TextChanged(object sender, EventArgs e)
        {
            bulidstand();
        }

        private void prev1()
        {
            if (rows == 0)
            { MessageBox.Show("已经到头了");
                return;
            }
            else
            {
                rows = rows - 1;
                no.Text = "序号" + (rows+1)+ "/" + dt.Rows.Count;
                standardno.Text = dt.Rows[rows][1].ToString();
                standardname.Text = dt.Rows[rows][2].ToString();
                standardtext.Text = dt.Rows[rows][3].ToString();
                standardmemo.Text = dt.Rows[rows][4].ToString();
            }
        }
        private void next1()
        {
            if (rows == dt.Rows.Count - 1)
            {
                MessageBox.Show("已经到尾了");
                return;
            }
            else
            {
                rows = rows + 1;
                no.Text = "序号" + (rows + 1) + "/" + dt.Rows.Count;
                standardno.Text = dt.Rows[rows][1].ToString();
                standardname.Text = dt.Rows[rows][2].ToString();
                standardtext.Text = dt.Rows[rows][3].ToString();
                standardmemo.Text = dt.Rows[rows][4].ToString();
            }
        }
        private void end()
        {
            rows = dt.Rows.Count - 1;


            
            no.Text = "序号" +( rows+1)+" /" + dt.Rows.Count;
            standardno.Text = dt.Rows[rows][1].ToString();
            standardname.Text = dt.Rows[rows][2].ToString();
            standardtext.Text = dt.Rows[rows][3].ToString();
            standardmemo.Text = dt.Rows[rows][4].ToString();
        }
    
    private void head()
    {
        rows = 0;
        no.Text = "序号" + "1/" + dt.Rows.Count;
        standardno.Text = dt.Rows[rows][1].ToString();
        standardname.Text = dt.Rows[rows][2].ToString();
        standardtext.Text = dt.Rows[rows][3].ToString();
        standardmemo.Text = dt.Rows[rows][4].ToString();
       }

        private void prev_Click(object sender, EventArgs e)
        {
            prev1();
        }

        private void next_Click(object sender, EventArgs e)
        {
            next1();
        }

        private void head1_Click(object sender, EventArgs e)
        {
            head();
        }

        private void bperv_Click(object sender, EventArgs e)
        {
            prev1();
        }

        private void bnext_Click(object sender, EventArgs e)
        {
            next1();
        }

        private void bend_Click(object sender, EventArgs e)
        {
            end();
        }

        private void del_Click(object sender, EventArgs e)
        {
            DataOperation.Execsql("delete  from standard where id="+ dt.Rows[rows][0].ToString());
            bulidstand();
        }
    }
}
