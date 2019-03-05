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
    public partial class commpanymanger : Form
    {
        DataTable dt = null;
        int rowindex = 0;
        private  int   addtag=0;
        private int selectid = 0;
        public commpanymanger()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == (rowindex + 1))
            {
                MessageBox.Show("已经到末尾了");
            }
            else
            {
                rowindex = rowindex + 1;
                bulidcomm(rowindex);
            }
            listno.Text = "序号" + (rowindex + 1) + "/" + dt.Rows.Count + "条";
        }

        private void commpanymanger_Load(object sender, EventArgs e)
        {
            dt = DataOperation.ExecQuery("select   *   from commpany  where pname like '%"+ serachname.Text+ "%'");

            listno.Text = "序号"+( rowindex+1)+"/" + dt.Rows.Count + "条";
            bulidcomm(rowindex);

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void head1_Click(object sender, EventArgs e)
        {
            rowindex = 0;
            bulidcomm(rowindex);
            listno.Text = "序号" + (rowindex + 1) + "/" + dt.Rows.Count + "条";
        }

        private void listno_Click(object sender, EventArgs e)
        {

        }

       private    void bulidcomm (int  indexrow)
        {
            pcode.Text = dt.Rows[indexrow]["code"].ToString();
            pname.Text = dt.Rows[indexrow]["pname"].ToString();
            pname1.Text = dt.Rows[indexrow]["pname1"].ToString();
            address.Text = dt.Rows[indexrow]["ADDRESS"].ToString();
             postcode.Text = dt.Rows[indexrow]["POSTALCODE"].ToString();

            tel.Text = dt.Rows[indexrow]["TEL"].ToString();
            homepage.Text = dt.Rows[indexrow]["HOMEPAGE"].ToString();
            email.Text = dt.Rows[indexrow]["EMAIL"].ToString();
            fax.Text = dt.Rows[indexrow]["fax"].ToString();

         
            intro.Text = dt.Rows[indexrow]["INTRO"].ToString();
            memo.Text = dt.Rows[indexrow]["memo"].ToString();
            selectid =  int.Parse(dt.Rows[indexrow]["id"].ToString());
        }

        private void serachname_TextChanged(object sender, EventArgs e)
        {
             dt.Rows.Clear();
            dt = DataOperation.ExecQuery(" select   *   from commpany  where pname like '%" + serachname.Text + "%'");
            listno.Text = "序号" + (rowindex + 1) + "/" + dt.Rows.Count + "条";
            if  (dt.Rows.Count  ==0) return;
            rowindex = 0;
          
            bulidcomm(rowindex);
        }

        private void bnext_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count == (rowindex + 1))
            {
                MessageBox.Show("已经到末尾了");
            }
            else
            {
                rowindex = rowindex + 1;
                bulidcomm(rowindex);
            }
            listno.Text = "序号" + (rowindex + 1) + "/" + dt.Rows.Count + "条";
        }

        private void bperv_Click(object sender, EventArgs e)
        {
            
            if (-1 == (rowindex-1))
            {
                MessageBox.Show("已经到头了");
            }
            else
            {
                rowindex = rowindex - 1;
                bulidcomm(rowindex);
            }
            listno.Text = "序号" + (rowindex + 1) + "/" + dt.Rows.Count + "条";
        }

        private void bend_Click(object sender, EventArgs e)
        {
            if  (dt.Rows.Count == 0)  return;
            rowindex = dt.Rows.Count-1;
            bulidcomm(rowindex);
            listno.Text = "序号" + (rowindex + 1) + "/" + dt.Rows.Count + "条";
        }

        private void add_Click(object sender, EventArgs e)
        {
            
            pcode.Text = "";
            pname.Text = "";
            pname1.Text = "";
            address.Text = "";
            postcode.Text = "";
            tel.Text = "";
            homepage.Text = "";
            email.Text = "";
            fax.Text = "";
            email.Text = "";
            intro.Text = "";
            memo.Text = "";
            pcode.Focus();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if  ( DataOperation.ExecQuery(" select   *   from commpany  where  code ='"+pcode.Text+"'").Rows.Count>0)
            {
                DataOperation.Execsql("update [commpany]  set Code='" + pcode.Text + "',pname='" + pname.Text + "',pname1='" + pname1.Text + "',address='" + address.Text+
                  "',POSTALCODE='" + postcode.Text+"',tel='"+tel.Text+"',fax='"+fax.Text+ "',HOMEPAGE='"+ homepage.Text+ "',EMAIL='" + email.Text+ "',intro='"+ intro.Text+
                  "',[memo]='"+ memo.Text+"'  where   id ="+selectid);
                dt = DataOperation.ExecQuery("select   *   from commpany  where pname like '%" + serachname.Text + "%'");
                bulidcomm(rowindex);
            }
            else
            {
                DataOperation.Execsql("insert  into [commpany]([Code],pname,pname1,address,POSTALCODE,tel,fax,HOMEPAGE,EMAIL,intro,[memo])  values('" + pcode.Text + "','" + pname.Text + "','" + pname1.Text + "','" + address.Text +
                    "','" + postcode.Text + "','" + tel.Text + "','" + fax.Text + "','" + homepage.Text + "','" + email.Text + "','" + intro.Text +
                    "','" + memo.Text + "')");
                dt = DataOperation.ExecQuery("select   *   from commpany  where pname like '%" + serachname.Text + "%'");
                rowindex = dt.Rows.Count-1;
                listno.Text = "序号" + (rowindex ) + "/" + dt.Rows.Count + "条";
                bulidcomm(rowindex);



            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            DataOperation.Execsql("delete    from commpany  where id=" + selectid);
            dt = DataOperation.ExecQuery("select   *   from commpany  where pname like '%" + serachname.Text + "%'");
            rowindex = 0;
            listno.Text = "序号" + (rowindex + 1) + "/" + dt.Rows.Count + "条";
            bulidcomm(rowindex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (-1 == (rowindex - 1))
            {
                MessageBox.Show("已经到头了");
            }
            else
            {
                rowindex = rowindex - 1;
                bulidcomm(rowindex);
            }
            listno.Text = "序号" + (rowindex + 1) + "/" + dt.Rows.Count + "条";
        }
    }
}
