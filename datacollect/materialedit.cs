using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class materialedit : Form
    {
        private string dataid = null;
        private DataTable dt = null;
    private    int processid=0;  //制备方法与工艺数据id
        private int prepationid = 0;//加工方法与工艺
        private int applyid = 0;//
        public materialedit(string mdataid)
        {
            InitializeComponent();
            dataid = mdataid;
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void DATA_SORT1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DATA_SORT2.DataSource = DataOperation.ExecQuery("Select DISTINCT  [SecondLevelCode],iif([SecondLevelCode]='00','无分类',[SecondLevelname]) as  SecondLevelname1   from  [materialSystem]  where  firstLevelCode='" + DATA_SORT1.SelectedValue + "'");
            DATA_SORT2.DisplayMember = "secondLevelName1";
            DATA_SORT2.ValueMember = "SecondLevelCode";

            DATA_SERIES.DataSource = DataOperation.ExecQuery("Select DISTINCT  [thirdLevelCode],iif([thirdLevelCode]='00','无分类',[thirdLevelname]) as  thirdLevelname1   from  [materialSystem] where  SecondLevelCode='" + DATA_SORT2.SelectedValue + "'");
            DATA_SERIES.DisplayMember = "thirdLevelName1";
            DATA_SERIES.ValueMember = "thirdLevelCode";
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {


        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label3.Text = "注意在输入上下标时，如n\x00B2,请以n<sup>2</sup>代替";
            DATA_SORT1.DataSource = DataOperation.ExecQuery("Select DISTINCT  [firstLevelCode],[firstLevelName]  from  [materialSystem] ");
            DATA_SORT1.DisplayMember = "firstLevelName";
            DATA_SORT1.ValueMember = "firstLevelCode";

            DATA_SORT2.DataSource = DataOperation.ExecQuery("Select DISTINCT  [SecondLevelCode],iif([SecondLevelCode]='00','无分类',[SecondLevelname]) as  SecondLevelname1   from  [materialSystem]  where  firstLevelCode='" + DATA_SORT1.SelectedValue + "'");
            DATA_SORT2.DisplayMember = "secondLevelName1";
            DATA_SORT2.ValueMember = "SecondLevelCode";

            DATA_SERIES.DataSource = DataOperation.ExecQuery("Select DISTINCT  [thirdLevelCode],iif([thirdLevelCode]='00','无分类',[thirdLevelname]) as  thirdLevelname1   from  [materialSystem] where  SecondLevelCode='" + DATA_SORT2.SelectedValue + "'");
            DATA_SERIES.DisplayMember = "thirdLevelName1";
            DATA_SERIES.ValueMember = "thirdLevelCode";

            GATHER_COMPANY.DataSource = DataOperation.ExecQuery("Select DISTINCT  [code], [pname]  from  [commpany]  order  by pname ");
            GATHER_COMPANY.DisplayMember = "pname";
            GATHER_COMPANY.ValueMember = "pname";

            dt = DataOperation.ExecQuery("select   DATA_NAME,DATA_FOREIGN,DATA_SORT1,DATA_SORT1NAME,DATA_SORT2NAME,DATA_SERIESNAME" +
                            ",DATA_SORT2,DATA_SERIES,GATHER_NAME,GATHER_COMPANY,GATHER_YEAR,GATHER_MONTH,GATHER_DAY  from materialbase  where DATA_ID='" + dataid + "'");
            DATA_NAME.Text = dt.Rows[0]["DATA_NAME"].ToString();
            DATA_FOREIGN.Text = dt.Rows[0]["DATA_FOREIGN"].ToString();
            DATA_SORT1.Text = dt.Rows[0]["DATA_SORT1Name"].ToString();
            DATA_SORT2.Text = dt.Rows[0]["DATA_SORT2NAME"].ToString();
            DATA_SERIES.Text = dt.Rows[0]["DATA_SERIESNAME"].ToString();
            GATHER_NAME.Text = dt.Rows[0]["GATHER_NAME"].ToString();
            GATHER_COMPANY.Text = dt.Rows[0]["GATHER_COMPANY"].ToString();
            GATHER_YEAR.Text = dt.Rows[0]["GATHER_YEAR"].ToString();
            GATHER_MONTH.Text = dt.Rows[0]["GATHER_MONTH"].ToString();
            GATHER_DAY.Text = dt.Rows[0]["GATHER_DAY"].ToString();
            //研制生产单位信息设定
            buildsupply();
            //生成 研制单位信息
            bulidcomm("");
            buliddgvcom(dataid);
            bulidbreed(dataid);
            bulidmdgvstand(dataid);
            buliddgvstand();
            buildpatent(dataid);
            buildprocess(dataid);
            buildpprepation(dataid);

            //应用情况
            applyarea.DataSource = DataOperation.ExecQuery("select firstLevelCode, firstLevelName  from   applicationArea");
            applyarea.DisplayMember = "firstLevelName";
            applyarea.ValueMember= "firstLevelCode";
            buildapply(dataid);

            checkcommpany.DataSource = DataOperation.ExecQuery("select pname  from   commpany");
            checkcommpany.ValueMember = "pname";
            checkcommpany.DisplayMember = "pname";

            checkname.DataSource = DataOperation.ExecQuery("select pname  from   people");
            checkname.ValueMember = "pname";
            checkname.DisplayMember = "pname";
            label1.Text = label1.Text + dataid+"("+ DATA_SORT1.Text+"-"+ DATA_SORT2.Text+"-"+ DATA_SERIES.Text+")";


            buildcheck(dataid);

            //  导入特殊符号数据
            StreamReader st = new StreamReader("tools.txt", Encoding.GetEncoding("utf-8"));
            string str = st.ReadLine();
            string specstr = null;
            while (str != null)
            {

                string yyy = str.Substring(0, 2);

                if (str.Substring(0, 2).Equals("//"))

                    specstr = specstr + "   " + str.Substring(2);
                str = st.ReadLine();
            }
            textBox1.Text = specstr;
            atten1.Text = "1、研制生产单位为多个\n时，只填写一个项目牵头\n单位或主要研制单位";
            atten2.Text = "2、生产单位可根据实际\n情况填写多个";

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DATA_SORT2_SelectedIndexChanged(object sender, EventArgs e)
        {


            DATA_SERIES.DataSource = DataOperation.ExecQuery("Select DISTINCT  [thirdLevelCode],iif([thirdLevelCode]='00','无分类',[thirdLevelname])  as  thirdLevelname1 from  [materialSystem] where  SecondLevelCode='" + DATA_SORT2.SelectedValue + "'");
            DATA_SERIES.DisplayMember = "thirdLevelName1";
            DATA_SERIES.ValueMember = "thirdLevelCode";
        }

        private void DATA_SORT2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DATA_SORT1_SizeChanged(object sender, EventArgs e)
        {

        }



        private void GATHER_COMPANY_TextChanged(object sender, EventArgs e)
        {



        }

        private void GATHER_COMPANY_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GATHER_COMPANY_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void GATHER_YEAR_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar != '\b')//这是允许输入退格键  
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字  
                {
                    e.Handled = true;
                }
            }
        }

        private void GATHER_MONTH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键  
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字  
                {
                    e.Handled = true;
                }
            }
        }

        private void GATHER_DAY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键  
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字  
                {
                    e.Handled = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            st1.Text = "";
            if ( ( string.IsNullOrEmpty(DATA_SORT1.Text) )   || (string.IsNullOrEmpty(DATA_SORT2.Text)) || (string.IsNullOrEmpty(DATA_SERIES.Text)) || (string.IsNullOrEmpty(GATHER_NAME.Text)) || (string.IsNullOrEmpty(GATHER_COMPANY.Text)))
            {
                MessageBox.Show("有必填项未填写！");
                st1.Text = "系统状态："+ "数据保存失败，请填写必要数据";
                return;
            }
            if ((string.IsNullOrEmpty(GATHER_YEAR.Text)) || (string.IsNullOrEmpty(GATHER_MONTH.Text)) || (string.IsNullOrEmpty(GATHER_DAY.Text))  )
            {
                MessageBox.Show("有必填项未填写！");
                st1.Text = "系统状态：" + "数据保存失败，请填写必要数据";
                return;
            }
            

               String Updatesql = "update  materialbase  set DATA_NAME='" + DATA_NAME.Text + "',DATA_FOREIGN='" + DATA_FOREIGN.Text + "',DATA_SORT1='" +
                             DATA_SORT1.SelectedValue + "',DATA_SORT1NAME='" + DATA_SORT1.Text + "',DATA_SORT2NAME='" + DATA_SORT2.Text + "',DATA_SERIESNAME='" + DATA_SERIES.Text +
                             "',DATA_SORT2='" + DATA_SORT2.SelectedValue + "',DATA_SERIES='" + DATA_SERIES.SelectedValue + "',GATHER_NAME='" +
                             GATHER_NAME.Text + "',GATHER_COMPANY='" + GATHER_COMPANY.SelectedValue + "',GATHER_YEAR='" + GATHER_YEAR.Text + "',GATHER_MONTH='" +
                             GATHER_MONTH.Text + "',GATHER_DAY='" + GATHER_DAY.Text + "'   where   DATA_ID='" + dataid + "'";

           if ( DataOperation.Execsql(Updatesql)>0) st1.Text = "系统状态：" + "数据保存成功";
            //清空相关性能数据  然后把
            DataOperation.Execsql("delete  from NEW_ID_CAPABILITY_HEAD where DATA_ID='"+ dataid+"'");
            DataTable dt=  DataOperation.ExecQuery("select   pcode,pname from  pfeature  where mcode='" + DATA_SERIES.SelectedValue + "'");
            for (int i=0;i<dt.Rows.Count;i++)
            {
                DataOperation.Execsql("insert  into NEW_ID_CAPABILITY_HEAD(DATA_ID,pcode,[CHARACTER]) values('"+ dataid+"','"+ dt.Rows[i][0].ToString()+"','"+ dt.Rows[i][1].ToString()+"')");
            }
            DataOperation.Execsql("delete  from NEW_ID_CAPABILITY where DATA_ID='" + dataid + "'");
            dt = DataOperation.ExecQuery("select  firstLevelCode,secondLevelCode,thirdLevelCode,firstLevelName,secondLevelName, thirdLevelName from  Performance  where  code='" + DATA_SERIES.SelectedValue + "'");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataOperation.Execsql("insert  into NEW_ID_CAPABILITY(DATA_ID,CAPA1code,CAPA2code,CAPA3code,CAPA1,CAPA2,CAPA3) values('" + dataid + "','" + dt.Rows[i][0].ToString() + "','" + dt.Rows[i][1].ToString() + "','" + dt.Rows[i][2].ToString()+"','" + dt.Rows[i][3].ToString()+"','" + dt.Rows[i][4].ToString()+"','" + dt.Rows[i][5].ToString()+ "')");
            }
            st1.Text = "系统状态：" + "数据保存成功；性能数据填写项已经生成，请及时完善！";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 5) || (e.ColumnIndex == 6))
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Equals("√"))
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "-";
                }
                else
                {

                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "√";
                }
                    if (e.ColumnIndex == 5)
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            dataGridView1.Rows[i].Cells[e.ColumnIndex].Value = "-";
                        }
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "√";
                    }
                
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {

                    if (dataGridView1.Rows[i].Cells[5].Value.ToString().Equals("√") && dataGridView1.Rows[i].Cells[6].Value.ToString().Equals("√"))
                    {
                        dataGridView1.Rows[i].Cells[4].Value = 'A';
                        dataGridView1.Rows[i].Cells[2].Value = "研制生产单位";

                    }
                    else if (dataGridView1.Rows[i].Cells[5].Value.ToString().Equals("√") && dataGridView1.Rows[i].Cells[6].Value.ToString().Equals("-"))
                    {
                        dataGridView1.Rows[i].Cells[4].Value = 'R';
                        dataGridView1.Rows[i].Cells[2].Value = "研制单位";
                    }
                    else if (dataGridView1.Rows[i].Cells[5].Value.ToString().Equals("-") && dataGridView1.Rows[i].Cells[6].Value.ToString().Equals("√"))
                    {
                        dataGridView1.Rows[i].Cells[4].Value = 'P';
                        dataGridView1.Rows[i].Cells[2].Value = "生产单位";
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[2].Value = "未设定";
                        dataGridView1.Rows[i].Cells[4].Value = "";
                    }
                }



            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells[3].Value;
                st1.Text = "该牌号的厂商数据已经删除：" + DataOperation.Execsql("delete  from  new_id_supply  where  id=" + id) + "条";
                buildsupply();
            }
        }
        private void bulidcomm(string sqls)
        {
            DataTable dw = DataOperation.ExecQuery("select   pname,code  from   commpany  " + sqls + "   order  by  pname");
            this.dataGridView2.DataSource = dw;
            if (dw != null)
            {
                //  this.dataGridView1.DataMember = "T_Class";
                this.dataGridView2.Columns[0].HeaderCell.Value = " 单位名称";
                this.dataGridView2.Columns[0].Width = 300;
                this.dataGridView2.Columns[1].HeaderCell.Value = "单位代码";
                this.dataGridView2.Columns[1].Width = 150;
            }
        }
        private void buildsupply()
        {
            //研制生产单位信息设定
            // DataTable yzdw = DataOperation.ExecQuery("select  COMP_NUM, COMP_NAME,COMP_SIGN from [NEW_ID_SUPPLY]   WHERE  DATA_ID='" + dataid + "'");
            DataTable yzdw = DataOperation.ExecQuery("SELECT  comp_name, comp_num, iif(comp_sign = 'R', '研制单位', iif(comp_sign = 'P', '生产单位', iif(comp_sign = 'A', '研制生产单位', '未设定'))) as comp_signname,id,comp_sign from  new_id_supply   WHERE  DATA_ID='" + dataid + "'");
            yzdw.Columns.Add();
            yzdw.Columns.Add();

            for (int i = 0; i < yzdw.Rows.Count; i++)
            {
                if (((DataRow)yzdw.Rows[i])[4].ToString() == "A")
                {
                    yzdw.Rows[i][5] = "√";
                    yzdw.Rows[i][6] = "√";
                }
                else if (((DataRow)yzdw.Rows[i])[4].ToString() == "R")
                {
                    yzdw.Rows[i][5] = "√";
                    yzdw.Rows[i][6] = "-";
                }
                else if (((DataRow)yzdw.Rows[i])[4].ToString() == "P")
                {
                    yzdw.Rows[i][5] = "-";
                    yzdw.Rows[i][6] = "√";
                }
                else
                {
                    yzdw.Rows[i][5] = "-";
                    yzdw.Rows[i][6] = "-";
                }
            }

            this.dataGridView1.DataSource = yzdw;
            //  this.dataGridView1.DataMember = "T_Class";
            this.dataGridView1.Columns[0].HeaderCell.Value = "研制/生产单位名称";
            this.dataGridView1.Columns[0].Width = 300;
            this.dataGridView1.Columns[1].HeaderCell.Value = "研制/生产单位代码";
            this.dataGridView1.Columns[1].Width = 140;
            this.dataGridView1.Columns[2].HeaderCell.Value = "单位情况";
            this.dataGridView1.Columns[2].Width = 80;
            this.dataGridView1.Columns[3].Visible = false;
            this.dataGridView1.Columns[4].Visible = false;

            this.dataGridView1.Columns[5].HeaderCell.Value = "研制单位";
            this.dataGridView1.Columns[5].ReadOnly = true;
            this.dataGridView1.Columns[5].Width = 80;
            this.dataGridView1.Columns[6].HeaderCell.Value = "生产单位";
            this.dataGridView1.Columns[6].ReadOnly = true;
            this.dataGridView1.Columns[6].Width = 80;

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataOperation.ExecQuery("select  *  from  new_id_supply  where  DATA_ID='" + dataid + "' and  COMP_NUM='" + dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString() + "'").Rows.Count > 0)
            { st1.Text = "请不要重复添加"; }
            else
            {
                st1.Text = "添加厂商" + dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString() + "到库中：" + DataOperation.Execsql("insert into  new_id_supply(DATA_ID,COMP_NUM,COMP_NAME)   values ('" + dataid + "', '" + dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString() + "','" + dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString() + "')");
                buildsupply();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataOperation.Execsql("update   new_id_supply   set COMP_SIGN='" + dataGridView1.Rows[i].Cells[4].Value.ToString() + "'  where  id=" + dataGridView1.Rows[i].Cells[3].Value.ToString());
            }
            buildsupply();
            st1.Text = "数据已经更新成功！";
        }

        private void add_Click(object sender, EventArgs e)
        {
            inputdata fm = new inputdata(dataid);
            fm.ShowDialog();
            buildsupply();


        }

        private void button6_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
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

        private void seltext_TextChanged(object sender, EventArgs e)
        {
            if (select1.Checked)
            {
                bulidcomm("where pname like '%" + seltext.Text + "%' ");
            }
            else
            {
                bulidcomm("where code  like '%" + seltext.Text + "%' ");

            }

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void compentsave_Click(object sender, EventArgs e)
        {
            decimal dec = 0;

            String sql = "";
            for (int i = 0; i < dgvCOMPONET.Rows.Count; i++)
            {
                if (!decimal.TryParse(dgvCOMPONET.Rows[i].Cells[4].Value.ToString(), out Decimal n) || n < 0)
                {

                    MessageBox.Show(" 必须输入数据！");
                    return;
                }
                else
                    dec = dec + n;
            }
            if (dec > 100)
            {
                MessageBox.Show("超过  100");
                return;
            }
            for (int i = 0; i < dgvCOMPONET.Rows.Count; i++)
            {
                if (dgvCOMPONET.Rows[i].Cells[0].Value.ToString().Length > 1)
                {
                    sql = "update  NEW_ID_COMPONET   set  COMPONET='" + dgvCOMPONET.Rows[i].Cells[2].Value + "',MINI_SIGN='" + dgvCOMPONET.Rows[i].Cells[3].Value + "',MINI_VALUE=" +
                          dgvCOMPONET.Rows[i].Cells[4].Value + ",MINI_EXPONENTIAL=" + dgvCOMPONET.Rows[i].Cells[5].Value + ",MAX_SIGN='" + dgvCOMPONET.Rows[i].Cells[6].Value + "',MAX_VALUE=" +
                           dgvCOMPONET.Rows[i].Cells[7].Value + ",MAX_EXPONENTIAL=" + dgvCOMPONET.Rows[i].Cells[8].Value + ",MTEXT='" + dgvCOMPONET.Rows[i].Cells[9].Value + "'" +
                           "  where Id=" + dgvCOMPONET.Rows[i].Cells[0].Value;
                }
                else
                {
                    sql = "insert  into NEW_ID_COMPONET(DATA_ID,COMPONET,MINI_SIGN,MINI_VALUE,MINI_EXPONENTIAL,MAX_SIGN,MAX_VALUE,MAX_EXPONENTIAL,MTEXT)  values ('" +
                              dataid + "','" + dgvCOMPONET.Rows[i].Cells[2].Value + "','" + dgvCOMPONET.Rows[i].Cells[3].Value + "'," +
                          dgvCOMPONET.Rows[i].Cells[4].Value + "," + dgvCOMPONET.Rows[i].Cells[5].Value + ",'" +
                          dgvCOMPONET.Rows[i].Cells[6].Value + "'," + dgvCOMPONET.Rows[i].Cells[7].Value + "," +
                          dgvCOMPONET.Rows[i].Cells[8].Value + ",'" + dgvCOMPONET.Rows[i].Cells[9].Value + "')";
                }
                DataOperation.Execsql(sql);
            }
            this.compentsave.Enabled = false;
            buliddgvcom(dataid);
            st1.Text = "数据已经保存成功";
        }

        private void dgvCOMPONET_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void buliddgvcom(string idataid)
        {
            dgvCOMPONET.DataSource = null;
            dgvCOMPONET.Columns.Clear();



            DataTable dt = DataOperation.ExecQuery("select * from NEW_ID_COMPONET where data_id='" + idataid + "'");
             if (dt != null)
            {
                //  this.dataGridView1.DataMember = "T_Class";
                DataGridViewTextBoxColumn column0 = new DataGridViewTextBoxColumn();
                column0.DataPropertyName = "id";//对应数据源的字段
                this.dgvCOMPONET.Columns.Add(column0);
                this.dgvCOMPONET.Columns[0].Visible = false;

                DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
                column1.DataPropertyName = "DATA_ID";//对应数据源的字段
                this.dgvCOMPONET.Columns.Add(column1);
                this.dgvCOMPONET.Columns[1].Visible = false;
                DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
                column2.HeaderText = "成分（组分）";
                column2.DataPropertyName = "COMPONET";//对应数据源的字段
                this.dgvCOMPONET.Columns.Add(column2);

                List<string> ListData = new List<string> { ">=", ">", "=" };
                DataGridViewComboBoxColumn column3 = new DataGridViewComboBoxColumn();
                column3.Name = "Name";
                column3.DataPropertyName = "MINI_SIGN";//对应数据源的字段
                column3.HeaderText = "下界符号";
                column3.Width = 80;
                this.dgvCOMPONET.Columns.Add(column3);
                column3.DataSource = ListData;

                DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
                column4.DataPropertyName = "MINI_VALUE";//对应数据源的字段
                column4.Name = "MINI_VALUE";
                column4.DataPropertyName = "MINI_VALUE";//对应数据源的字段
                column4.HeaderText = "下界值";
                column4.Width = 80;
                this.dgvCOMPONET.Columns.Add(column4);

                DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();

                column5.DataPropertyName = "MINI_EXPONENTIAL";//对应数据源的字段
                column5.Name = "MINI_EXPONENTIAL";
                column5.DataPropertyName = "MINI_EXPONENTIAL";//对应数据源的字段
                column5.HeaderText = "幂次";

                column5.Width = 80;
                this.dgvCOMPONET.Columns.Add(column5);

                List<string> ListData1 = new List<string> { "<=", "<", "=" };
                DataGridViewComboBoxColumn column6 = new DataGridViewComboBoxColumn();
                column6.Name = "MAX_SIGN";
                column6.DataPropertyName = "MAX_SIGN";//对应数据源的字段
                column6.HeaderText = "上界符号";
                column6.Width = 80;
                this.dgvCOMPONET.Columns.Add(column6);
                column6.DataSource = ListData1;

                DataGridViewTextBoxColumn column7 = new DataGridViewTextBoxColumn();
                column7.DataPropertyName = "MAX_VALUE";//对应数据源的字段
                column7.Name = "MAX_VALUE";
                column7.DataPropertyName = "MAX_VALUE";//对应数据源的字段
                column7.HeaderText = "上界值";
                column7.Width = 80;
                this.dgvCOMPONET.Columns.Add(column7);

                DataGridViewTextBoxColumn column8 = new DataGridViewTextBoxColumn();
                column8.DataPropertyName = "MAX_EXPONENTIAL";//对应数据源的字段
                column8.Name = "MAX_EXPONENTIAL";
                column8.DataPropertyName = "MAX_EXPONENTIAL";//对应数据源的字段
                column8.HeaderText = "幂次";
                column8.Width = 80;
                this.dgvCOMPONET.Columns.Add(column8);

                DataGridViewTextBoxColumn column9 = new DataGridViewTextBoxColumn();
                column9.DataPropertyName = "MINI_EXPONENTIAL";//对应数据源的字段
                column9.Name = "MTEXT";
                column9.DataPropertyName = "MTEXT";//对应数据源的字段
                column9.HeaderText = "定性描述";
                column9.Width = 300;
                this.dgvCOMPONET.Columns.Add(column9);

                dgvCOMPONET.DataSource = dt;


            }


        }

        private void dgvCOMPONET_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == 8) || (e.ColumnIndex == 5))
            {
                if (e.Value == null)
                {
                    e.Value = "E";
                }
                else
                {
                    e.Value = "E" + e.Value;
                }

            }

        }

        private void compentadd_Click(object sender, EventArgs e)
        {
            DataTable xx = (DataTable)dgvCOMPONET.DataSource;
            DataRow dr = xx.NewRow();
            xx.Rows.Add(dr);
            dgvCOMPONET.DataSource = xx;
            // dgvCOMPONET.Rows[this.dgvCOMPONET.Rows.Count - 1].Selected = true;
            // dgvCOMPONET.FirstDisplayedScrollingRowIndex = dgvCOMPONET.Rows.Count - 1;
            dgvCOMPONET.CurrentCell = dgvCOMPONET.Rows[dgvCOMPONET.Rows.Count - 1].Cells[2];
            dgvCOMPONET.BeginEdit(false);
            TextBox tb = (TextBox)dgvCOMPONET.EditingControl;
            tb.SelectionStart = 0;
            compentsave.Enabled = true;
            st1.Text = "已经增加一条空数据，请填入各种数据值！";




        }

        private void dgvCOMPONET_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void dgvCOMPONET_RowValidated(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgvCOMPONET_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                DataGridView grid = (DataGridView)sender;
                grid.Rows[e.RowIndex].ErrorText = "";

                if( (grid.Columns[e.ColumnIndex].Name == "MINI_VALUE") || (grid.Columns[e.ColumnIndex].Name == "MINI_EXPONENTIAL") || (grid.Columns[e.ColumnIndex].Name == "MAX_VALUE") || (grid.Columns[e.ColumnIndex].Name == "MAX_EXPONENTIAL"))
                {
                    try
                    {
                        Convert.ToDecimal(e.FormattedValue);
                    }
                    catch
                    {
                        e.Cancel = true;
                        grid.Rows[e.RowIndex].ErrorText = "请输入数值";
                        MessageBox.Show("这不是数值，请输入数值!");
                        return;
                    }
                }
            }
        }

        private void dgvCOMPONET_RowLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCOMPONET_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            compentsave.Enabled = true;
        }

        private void dgvCOMPONET_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCOMPONET_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            compentsave.Enabled = true;
        }

        private void compentdel_Click(object sender, EventArgs e)
        {
            if (this.dgvCOMPONET.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvCOMPONET.SelectedRows.Count; i++)
                {
                    DataOperation.Execsql("delete  from NEW_ID_COMPONET  where  id=" + dgvCOMPONET.SelectedRows[i].Cells[0].Value);

                }
                buliddgvcom(dataid);
                st1.Text = "已经删除数据：" + dgvCOMPONET.SelectedRows.Count + " 条";
            }
        }
        private void bulidbreed(string idataid)
        {
            DataTable dt = DataOperation.ExecQuery("select * from NEW_ID_BREED where data_id='" + idataid + "'");
            if (dt != null)
            {
                this.dgvbreed.DataSource = dt;
                this.dgvbreed.Columns[0].Visible = false;
                this.dgvbreed.Columns[1].Visible = false;
                this.dgvbreed.Columns[2].HeaderText = "品种与供应/供货状态";
                this.dgvbreed.Columns[2].Width = 300;
                this.dgvbreed.Columns[3].HeaderText = "规格";
                this.dgvbreed.Columns[3].Width = 300;

            }
        }
        private void breedadd_Click(object sender, EventArgs e)
        {
            DataTable xx = (DataTable)dgvbreed.DataSource;
            DataRow dr = xx.NewRow();
            xx.Rows.Add(dr);
            dgvbreed.DataSource = xx;
            dgvbreed.CurrentCell = dgvbreed.Rows[dgvbreed.Rows.Count - 1].Cells[2];
            dgvbreed.BeginEdit(false);
            TextBox tb = (TextBox)dgvbreed.EditingControl;
            tb.SelectionStart = 0;
            breedsave.Enabled = true;
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void breeddel_Click(object sender, EventArgs e)
        {
            if (this.dgvbreed.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvbreed.SelectedRows.Count; i++)
                {
                    DataOperation.Execsql("delete  from  NEW_ID_BREED  where  id=" + dgvbreed.Rows[i].Cells[0].Value);
                }
                bulidbreed(dataid);
            }
        }

        private void breedsave_Click(object sender, EventArgs e)
        {
            String sql = "";
            for (int i = 0; i < dgvbreed.Rows.Count; i++)
            {
                if (dgvbreed.Rows[i].Cells[0].Value.ToString().Length > 0)
                {
                    sql = "update  NEW_ID_BREED   set  STATUS='" + dgvbreed.Rows[i].Cells[2].Value + "',SPEC='" + dgvbreed.Rows[i].Cells[3].Value +
                        "'  where Id=" + dgvbreed.Rows[i].Cells[0].Value;
                }
                else
                {
                    sql = "insert  into NEW_ID_BREED(DATA_ID,STATUS,SPEC)  values ('" +
                              dataid + "','" + dgvbreed.Rows[i].Cells[2].Value + "','" + dgvbreed.Rows[i].Cells[3].Value + "')";
                }
                DataOperation.Execsql(sql);
            }
            this.breedsave.Enabled = false;
            bulidbreed(dataid);
            st1.Text = "品种规格数据已经保存";

        }

        private void dgvbreed_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            breedsave.Enabled = true;
        }

        private void mdgvstand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private   void   bulidmdgvstand(string idataid)
        {
            DataTable dt = DataOperation.ExecQuery("select * from NEW_ID_TECHNIQUE where data_id='" + idataid + "'");
            if (dt != null)
            {
                this.mdgvstand.DataSource = dt;
                this.mdgvstand.Columns[0].Visible = false;
                this.mdgvstand.Columns[1].Visible = false;
                this.mdgvstand.Columns[2].HeaderText = "标准/技术文件号";
                this.mdgvstand.Columns[2].Width = 300;
                this.mdgvstand.Columns[3].HeaderText = "标准/技术文件名称";
                this.mdgvstand.Columns[3].Width = 300;

            }
        }

        private void buliddgvstand( )
        {
            DataTable dt = DataOperation.ExecQuery("select STANDARD_NUM,STANDARD_NAME from  standard");
            if (dt != null)
            {
                this.dgvstand.DataSource = dt;
             
                this.dgvstand.Columns[0].HeaderText = "技术标准号";
                this.dgvstand.Columns[0].Width = 300;
                this.dgvstand.Columns[1].HeaderText = "技术标准名称";
                this.dgvstand.Columns[1].Width = 300;

            }
        }

        private void standadd_Click(object sender, EventArgs e)
        {
            DataTable xx = (DataTable)mdgvstand.DataSource;
            
            DataRow dr = xx.NewRow();
            xx.Rows.Add(dr);
            mdgvstand.DataSource = xx;
            mdgvstand.CurrentCell = mdgvstand.Rows[mdgvstand.Rows.Count - 1].Cells[2];
            mdgvstand.BeginEdit(false);
            TextBox tb = (TextBox)mdgvstand.EditingControl;
            tb.SelectionStart = 0;
          
            standsave.Enabled = true;

        }

        private void dgvstand_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if  (DataOperation.ExecQuery("select  *  from NEW_ID_TECHNIQUE  where  DATA_ID='" + dataid + "' and  STANDARD_NUM='" + dgvstand.Rows[e.RowIndex].Cells[0].Value + "'").Rows.Count==0) 
            DataOperation.Execsql("insert  into NEW_ID_TECHNIQUE(DATA_ID,STANDARD_NUM,STANDARD_NAME) values('"+ dataid+"','"+dgvstand.Rows[e.RowIndex].Cells[0].Value + "','"+ dgvstand.Rows[e.RowIndex].Cells[1].Value+"')" );
            bulidmdgvstand(dataid);
        }

        private void dgvstand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void standdel_Click(object sender, EventArgs e)
        {
            if (this.mdgvstand.SelectedRows.Count > 0)
            {
                for (int i = 0; i < mdgvstand.SelectedRows.Count; i++)
                {
                    DataOperation.Execsql("delete  from  NEW_ID_TECHNIQUE  where  id=" + mdgvstand.Rows[i].Cells[0].Value);
                }
                bulidmdgvstand(dataid);
            }
        }

        private void standsave_Click(object sender, EventArgs e)
        {
            String sql = "";
            for (int i = 0; i < mdgvstand.Rows.Count; i++)
            {
                if (mdgvstand.Rows[i].Cells[0].Value.ToString().Length > 0)
                {
                    sql = "update  NEW_ID_TECHNIQUE   set  STANDARD_NUM='" + mdgvstand.Rows[i].Cells[2].Value + "',STANDARD_NAME='" + mdgvstand.Rows[i].Cells[3].Value +
                        "'  where Id=" + mdgvstand.Rows[i].Cells[0].Value;
                }
                else
                {
                    sql = "insert  into NEW_ID_TECHNIQUE(DATA_ID,STANDARD_NUM,STANDARD_NAME)  values ('" +
                              dataid + "','" + mdgvstand.Rows[i].Cells[2].Value + "','" + mdgvstand.Rows[i].Cells[3].Value + "')";
                }
                DataOperation.Execsql(sql);
            }
            this.standsave.Enabled = false;
            bulidmdgvstand(dataid);
            st1.Text = "技术标准数据已经保存";
        }

        private void mdgvstand_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            standsave.Enabled = true;
        }

      private void  buildpatent(string   idataid)
        {
            DataTable dt = DataOperation.ExecQuery("select * from  NEW_ID_PATENT  where    data_id='" + idataid + "'");
            if (dt != null)
            {
                this.dgvpatent.DataSource = dt;
                this.dgvpatent.Columns[0].Visible = false;
                this.dgvpatent.Columns[1].Visible = false;
                this.dgvpatent.Columns[2].HeaderText = "专利授权号";
                this.dgvpatent.Columns[2].Width = 300;
                this.dgvpatent.Columns[3].HeaderText = "专利名称";
                this.dgvpatent.Columns[3].Width = 300;

            }
        }

        private void patentadd_Click(object sender, EventArgs e)
        {
            DataTable xx = (DataTable)dgvpatent.DataSource;
            DataRow dr = xx.NewRow();
            xx.Rows.Add(dr);
            dgvpatent.DataSource = xx;
            dgvpatent.CurrentCell = dgvpatent.Rows[dgvbreed.Rows.Count - 1].Cells[2];
            dgvpatent.BeginEdit(false);
            TextBox tb = (TextBox)dgvpatent.EditingControl;
            tb.SelectionStart = 0;
            patentsave.Enabled = true;
        }

        private void patentsave_Click(object sender, EventArgs e)
        {
            String sql = "";
            for (int i = 0; i < dgvpatent.Rows.Count; i++)
            {
                if (dgvpatent.Rows[i].Cells[0].Value.ToString().Length > 0)
                {
                    sql = "update  NEW_ID_PATENT   set  PATENT_NUM='" + dgvpatent.Rows[i].Cells[2].Value + "',PATENT_NAME='" + dgvpatent.Rows[i].Cells[3].Value +
                        "'  where Id=" + dgvpatent.Rows[i].Cells[0].Value;
                }
                else
                {
                    sql = "insert  into NEW_ID_PATENT(DATA_ID,PATENT_NUM,PATENT_NAME)  values ('" +
                              dataid + "','" + dgvpatent.Rows[i].Cells[2].Value + "','" + dgvpatent.Rows[i].Cells[3].Value + "')";
                }
                DataOperation.Execsql(sql);
            }
            this.patentsave.Enabled = false;
            buildpatent(dataid);
            st1.Text = "专利数据已经保存";
        }

        private void patentdel_Click(object sender, EventArgs e)
        {
            if (this.dgvpatent.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvpatent.SelectedRows.Count; i++)
                {
                    DataOperation.Execsql("delete  from  NEW_ID_PATENT  where  id=" + dgvpatent.Rows[i].Cells[0].Value);
                }
                buildpatent(dataid);
            }
        }

        private void dgvpatent_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            patentsave.Enabled = true;
        }

        private void dgvpatent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void processadd_Click(object sender, EventArgs e)
        {
            processid = 0;
            processmethod.Focus();
            processmethod.Text = "";
            processart.Text = "";
            processsave.Enabled = true;
        }

        private void buildprocess(string idataid)
        {
            DataTable dt = DataOperation.ExecQuery("select * from  NEW_ID_PROCESS  where    data_id='" + idataid + "'");
           
            if ((dt != null)  && (dt.Rows.Count>0))
            {
                processmethod.Text = dt.Rows[dt.Rows.Count-1][2].ToString();
                processart.Text = dt.Rows[dt.Rows.Count - 1][3].ToString();
                processid = int.Parse(dt.Rows[dt.Rows.Count - 1][0].ToString());

            }
            else
            {
                processmethod.Text = "";
                processart.Text = "";
            }
        }

        private void processdel_Click(object sender, EventArgs e)
        {

           
                DataOperation.ExecQuery("delete * from  NEW_ID_PROCESS  where     id=" + processid );

                buildprocess(dataid);
            
        }

        private void processsave_Click(object sender, EventArgs e)
        {
            if (processmethod.Text.Length == 0)
            {
                MessageBox.Show("制备方法不能为空！");
                processmethod.Focus();
                return;
            }
            if (DataOperation.ExecQuery("select  *  from NEW_ID_PROCESS  where  DATA_ID='" + dataid + "' and  METHOD='" + processmethod.Text + "'").Rows.Count == 0   && processid==0 )
            {
              
                string sql = "insert  into NEW_ID_PROCESS(DATA_ID,METHOD,ART)  values ('" + dataid + "','" + processmethod.Text + "','" + processart.Text + "')";
                DataOperation.Execsql(sql);
                
            }
            else 
            if ( processid >0)
            {
                String sql = "update  NEW_ID_PROCESS   set  METHOD='" + processmethod.Text + "',ART='" + processart.Text + "'  where Id=" + processid;
                DataOperation.Execsql(sql);
            }
            else
                  
            {
                MessageBox.Show("不能重复添加");
            }


            buildprocess(dataid);
            st1.Text = "制备方法与工艺数据已经保存";


        }

        private void prepationadd_Click(object sender, EventArgs e)
        {
            prepationid = 0;
            prepationmethod.Focus();
            prepationmethod.Text = "";
            prepationart.Text = "";
       
        }

        private void buildpprepation(string idataid)
        {
            DataTable dt = DataOperation.ExecQuery("select * from  NEW_ID_PREPARATION  where    data_id='" + idataid + "'");

            if ((dt != null) && (dt.Rows.Count > 0))
            {
                prepationmethod.Text = dt.Rows[dt.Rows.Count - 1][2].ToString();
                prepationart.Text = dt.Rows[dt.Rows.Count - 1][3].ToString();
                prepationid = int.Parse(dt.Rows[dt.Rows.Count - 1][0].ToString());

            }
            else
            {
                prepationmethod.Text = "";
                prepationart.Text = "";
            }
        }

        private void prepationsave_Click(object sender, EventArgs e)
        {
            if (prepationmethod.Text.Length == 0)
            {
                MessageBox.Show("制备方法不能为空！");
                prepationmethod.Focus();
                return;
            }
            if (DataOperation.ExecQuery("select  *  from NEW_ID_PREPARATION  where  DATA_ID='" + dataid + "' and  METHOD='" + prepationmethod.Text + "'").Rows.Count == 0 && prepationid == 0)
            {

                string sql = "insert  into NEW_ID_PREPARATION(DATA_ID,METHOD,ART)  values ('" + dataid + "','" + prepationmethod.Text + "','" + prepationart.Text + "')";
                DataOperation.Execsql(sql);

            }
            else         
            if (prepationid > 0)
            {
                String sql = "update  NEW_ID_PREPARATION   set  METHOD='" + prepationmethod.Text + "',ART='" + prepationart.Text + "'  where Id=" + prepationid;
                DataOperation.Execsql(sql);
            }
            else
            {
                MessageBox.Show("不能重复添加");
            }

            buildpprepation(dataid);
            st1.Text = "加工方法与工艺已经保存";
        }

        private void prepationdel_Click(object sender, EventArgs e)
        {
            DataOperation.ExecQuery("delete * from  NEW_ID_PREPARATION  where     id=" + prepationid);

            buildpprepation(dataid);
        }

        private void processmethod_TextChanged(object sender, EventArgs e)
        {

        }

        private void applyarea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void applyareaadd_Click(object sender, EventArgs e)
        {
             applyid = 0;
            applyarea.Focus();
            equipment.Text = "";
            equipmenttype.Text = "";
            equipmentpart.Text = "";
            applycontent.Text = "";
        }
        private void buildapply(string idataid)
        {
            DataTable dt = DataOperation.ExecQuery("select * from  NEW_ID_APPLY  where    data_id='" + idataid + "'");

            if ((dt != null) && (dt.Rows.Count > 0))
            {
                applyarea.Text = dt.Rows[dt.Rows.Count - 1][2].ToString();
                equipment.Text = dt.Rows[dt.Rows.Count - 1][3].ToString();
                equipmenttype.Text = dt.Rows[dt.Rows.Count - 1][4].ToString();
                equipmentpart.Text = dt.Rows[dt.Rows.Count - 1][5].ToString();
                applycontent.Text = dt.Rows[dt.Rows.Count - 1][6].ToString();
                applyid = int.Parse(dt.Rows[dt.Rows.Count - 1][0].ToString());

            }
            else
            {
                equipment.Text = "";
                equipmenttype.Text = "";
                equipmentpart.Text = "";
                applycontent.Text = "";
            }
        }

        private void applyareasave_Click(object sender, EventArgs e)
        {
            if ( (equipmentpart.Text.Length == 0)|| (equipment.Text.Length == 0))
            {
                MessageBox.Show("请填写必填字段！");
                applyarea.Focus();
                return;
            }
            if (prepationid == 0)
            {

                string sql = "insert  into NEW_ID_APPLY(DATA_ID,FIELD,WEAPON,BACKGROUMD,PART,RESULT)  values ('" + dataid + "','" + applyarea.ValueMember + "','" + equipment.Text + "','" +
                    equipmenttype.Text + "','" + equipmentpart.Text + "','" + applycontent.Text + "')";
     
                DataOperation.Execsql(sql);

            }
            else
            
            {
                String sql = "update  NEW_ID_APPLY   set  FIELD='" + applyarea.ValueMember + "',WEAPON='" + equipment.Text + "',BACKGROUMD=" + equipmenttype.Text + "',PART=" +
                          equipmentpart.Text + "',RESULT='" + applycontent.Text + "'  where Id=" + applyid;
                DataOperation.Execsql(sql);
            }


            buildapply(dataid);
            st1.Text =  "应用方法已经保存";
        }

        private void applyareadel_Click(object sender, EventArgs e)
        {
            DataOperation.ExecQuery("delete * from  NEW_ID_APPLY  where     id=" + applyid);

            buildapply(dataid);
        }

        private void datacheck_Click(object sender, EventArgs e)
        {
            String sql = "update  materialbase   set  AUDITING_NAME='" + checkname.Text + "',AUDITING_COMPANY='" + checkcommpany.Text + "',AUDITING_YEAR=" + checkyear.Text + ",AUDITING_MONTH=" +
                          checkmonth.Text + ",Auditing_day=" + checkday.Text + "  where    data_id='" + dataid + "'";
            if (DataOperation.Execsql(sql) == 1)
                st1.Text = "审核数据保存成功";

        }

       private  void   buildcheck(string   idataid)
        {
            DataTable dt = DataOperation.ExecQuery("select AUDITING_NAME,AUDITING_COMPANY,AUDITING_YEAR,AUDITING_MONTH,Auditing_day from  materialbase  where    data_id='" + idataid + "'");

            if ((dt != null) && (dt.Rows.Count > 0))
            {
                checkname.Text = dt.Rows[dt.Rows.Count - 1][0].ToString();
                checkcommpany.Text = dt.Rows[dt.Rows.Count - 1][1].ToString();
                checkyear.Text = dt.Rows[dt.Rows.Count - 1][2].ToString();
                checkmonth.Text = dt.Rows[dt.Rows.Count - 1][3].ToString();
                checkday.Text = dt.Rows[dt.Rows.Count - 1][4].ToString();
               

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvCOMPONET_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X,
       e.RowBounds.Location.Y,
       dgvCOMPONET.RowHeadersWidth - 4,
       e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dgvCOMPONET.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dgvCOMPONET.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void checkcommpany_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GATHER_YEAR_TextChanged(object sender, EventArgs e)
        {
            if  (!ValidateUtil.IsNumber(GATHER_YEAR.Text))
            {
                MessageBox.Show("请输入数字！");
                GATHER_YEAR.Focus();

            }
        }

        private void dataGridView2_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void dataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X,
     e.RowBounds.Location.Y,
     dataGridView2.RowHeadersWidth - 4,
     e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dataGridView2.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dataGridView2.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
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
