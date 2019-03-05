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
    public partial class inputdata : Form
    {
        private string  dataid=null;
        public inputdata(string  idataid)
        {
            InitializeComponent();
            dataid = idataid;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if  (DataOperation.ExecQuery("select  *  from   commpany   where code='" + code.Text + "'").Rows.Count>0)
            {
                MessageBox.Show("单位库里已经有相同代码的单位信息了，请不要重复添加");
            }
            else
            {
              int i= DataOperation.Execsql("insert  into   commpany(code,pname) values('" + code.Text + "','" + pname.Text + "')");
                i=i+DataOperation.Execsql("insert into  new_id_supply(DATA_ID,COMP_NUM,COMP_NAME)   values ('" + dataid + "', '" + code.Text + "','" + pname.Text + "')");
                if (i == 2)
                {
                    MessageBox.Show("单位信息已经添加，同声进入了单位库");
                    Close();
                }
            }
        }
    }
}
