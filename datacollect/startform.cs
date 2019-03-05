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
    public partial class startform : Form
    {
        public startform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         string xx=   DataOperation.GetMD5(password.Text.Trim());

            if (DataOperation.ExecQuery("select  *  from   system  where  username='" + username.Text + "'  and  password='" + xx + "'").Rows.Count == 1)
            {
                this.DialogResult = DialogResult.OK;    //返回一个登录成功的对话框状态
                this.Close();    //关闭登录窗口
            }
            else
            {
                MessageBox.Show("账号密码错误！！");
            }
        }
    }
}
