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
    public partial class performancecoll : Form
    {
        private string dataid = null;
        private string dataseries = null;
        public performancecoll(string mdataid )
        {
            InitializeComponent();
            dataid = mdataid;
         //   dataseries = idataseries;
            label2.Text = label2.Text + dataid;
        }

        private void performancecoll_Load(object sender, EventArgs e)
        {
            bulidcapabilityhead(dataid);
            bulidperformance(dataid);
            bulidpexam(dataid);
        }

        private void bulidcapabilityhead(string idataid)
        {
            DataTable dt = DataOperation.ExecQuery("select *   from NEW_ID_CAPABILITY_HEAD where data_id='" + idataid + "'");
            dgvdcapabilityhead.DataSource = null;
            if (dt != null)
            {
                DataGridViewTextBoxColumn column0 = new DataGridViewTextBoxColumn();
                column0.DataPropertyName = "id";//对应数据源的字段
                this.dgvdcapabilityhead.Columns.Add(column0);
                this.dgvdcapabilityhead.Columns[0].Visible = false;

                DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
                column1.DataPropertyName = "DATA_ID";//对应数据源的字段
                this.dgvdcapabilityhead.Columns.Add(column1);
                this.dgvdcapabilityhead.Columns[1].Visible = false;

                DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
                column2.HeaderText = "性能项目";
                column2.DataPropertyName = "CHARACTER";//对应数据源的字段
                column2.ReadOnly = true;
                this.dgvdcapabilityhead.Columns.Add(column2);

                List<string> ListData = new List<string> { ">=", ">", "=" };
                DataGridViewComboBoxColumn column3 = new DataGridViewComboBoxColumn();
                column3.Name = "Name";
                column3.DataPropertyName = "MINI_SIGN";//对应数据源的字段
                column3.HeaderText = " ";
                column3.Width = 40;
                this.dgvdcapabilityhead.Columns.Add(column3);
                column3.DataSource = ListData;

                DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
                column4.Name = "MINI_VALUE";
                column4.DataPropertyName = "MINI_VALUE";//对应数据源的字段
                column4.HeaderText = "下界数据";
                column4.Width = 80;
                this.dgvdcapabilityhead.Columns.Add(column4);

                DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
                column5.Name = "MINI_EXPONENTIAL";
                column5.DataPropertyName = "MINI_EXPONENTIAL";//对应数据源的字段
                column5.HeaderText = "幂次";

                column5.Width = 80;
                this.dgvdcapabilityhead.Columns.Add(column5);

                List<string> ListData1 = new List<string> { "<=", "<", "=" };
                DataGridViewComboBoxColumn column6 = new DataGridViewComboBoxColumn();
                column6.Name = "MAX_SIGN";
                column6.DataPropertyName = "MAX_SIGN";//对应数据源的字段
                column6.HeaderText = " ";
                column6.Width = 40;
                this.dgvdcapabilityhead.Columns.Add(column6);
                column6.DataSource = ListData1;

                DataGridViewTextBoxColumn column7 = new DataGridViewTextBoxColumn();
                column7.Name = "MAX_VALUE";
                column7.DataPropertyName = "MAX_VALUE";//对应数据源的字段
                column7.HeaderText = "上界数据";
                column7.Width = 80;
                this.dgvdcapabilityhead.Columns.Add(column7);

                DataGridViewTextBoxColumn column8 = new DataGridViewTextBoxColumn();
                column8.Name = "MAX_EXPONENTIAL";
                column8.DataPropertyName = "MAX_EXPONENTIAL";//对应数据源的字段
                column8.HeaderText = "幂次";
                column8.Width = 80;
                this.dgvdcapabilityhead.Columns.Add(column8);

                DataGridViewTextBoxColumn column9 = new DataGridViewTextBoxColumn();
                column9.Name = "MTEXT";
                column9.DataPropertyName = "MTEXT";//对应数据源的字段
                column9.HeaderText = "定性指标";
                column9.Width = 300;
                this.dgvdcapabilityhead.Columns.Add(column9);

                DataGridViewTextBoxColumn column10 = new DataGridViewTextBoxColumn();
                column10.Name = "备注";
                column10.DataPropertyName = "comments1";//对应数据源的字段
                column10.HeaderText = "备注";
                column10.Width = 300;
                this.dgvdcapabilityhead.Columns.Add(column10);
               

                DataGridViewTextBoxColumn column11 = new DataGridViewTextBoxColumn();
                column11.Name = "特征代码";
                column11.DataPropertyName = "pcode";//对应数据源的字段
                column11.HeaderText = "特征代码";
                column11.Visible=true;
                this.dgvdcapabilityhead.Columns.Add(column11);

                DataGridViewTextBoxColumn column12 = new DataGridViewTextBoxColumn();
                column12.DataPropertyName = "status";//对应数据源的字段
                column12.Name = "特征代码";
                column12.HeaderText = "状态码";
                column12.Visible = true;
                this.dgvdcapabilityhead.Columns.Add(column12);

                dgvdcapabilityhead.DataSource = dt;

            }
        }

        private void add_Click(object sender, EventArgs e)
        {

            if (tabControl1.SelectedIndex == 0)
            {
                String x1 = dgvdcapabilityhead.SelectedRows[0].Cells[2].Value.ToString();
                String x2 = dgvdcapabilityhead.SelectedRows[0].Cells[11].Value.ToString();
                DataTable xx = (DataTable)dgvdcapabilityhead.DataSource;
                DataRow dr = xx.NewRow();
                xx.Rows.Add(dr);
                dgvdcapabilityhead.DataSource = xx;
                ;

                dgvdcapabilityhead.Rows[dgvdcapabilityhead.Rows.Count - 1].Cells[2].Value = x1;
                dgvdcapabilityhead.Rows[dgvdcapabilityhead.Rows.Count - 1].Cells[11].Value = x2;
                dgvdcapabilityhead.Rows[dgvdcapabilityhead.Rows.Count - 1].Cells[12].Value = 1;
                dgvdcapabilityhead.CurrentCell = dgvdcapabilityhead.Rows[dgvdcapabilityhead.Rows.Count - 1].Cells[3];
                dgvdcapabilityhead.BeginEdit(false);
                ComboBox tb = (ComboBox)dgvdcapabilityhead.EditingControl;
                tb.SelectionStart = 0;
                save.Enabled = true;
            }
            if (tabControl1.SelectedIndex == 1)
            {
                String cap1 = dgvperformance.SelectedRows[0].Cells[2].Value.ToString();
                String cap2 = dgvperformance.SelectedRows[0].Cells[3].Value.ToString();
                String cap3 = dgvperformance.SelectedRows[0].Cells[4].Value.ToString();
                String cap1code= dgvperformance.SelectedRows[0].Cells[13].Value.ToString();
                String cap2code = dgvperformance.SelectedRows[0].Cells[14].Value.ToString();
                String cap3code = dgvperformance.SelectedRows[0].Cells[15].Value.ToString();
                DataTable xx = (DataTable)dgvperformance.DataSource;
                DataRow dr = xx.NewRow();
                dr[2] = cap1;
                dr[3] = cap2;
                dr[4] = cap3;
                dr[13] = cap1code;
                dr[14] = cap2code;
                dr[15] = cap3code;
                xx.Rows.InsertAt(dr, dgvperformance.SelectedRows[0].Index+1);
               int   yy= dgvperformance.SelectedRows[0].Index + 1;
                dgvperformance.DataSource = xx;
                dgvperformance.Rows[yy].Selected = true;
                dgvperformance.CurrentCell = dgvperformance.SelectedRows[0].Cells[5];
                dgvperformance.BeginEdit(false);
                ComboBox tb = (ComboBox)dgvperformance.EditingControl;
                tb.SelectionStart = 0;
                save.Enabled = true;
            }

        }

        private void dgvdcapabilityhead_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X,
       e.RowBounds.Location.Y,
       dgvdcapabilityhead.RowHeadersWidth - 4,
       e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dgvdcapabilityhead.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dgvdcapabilityhead.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void dgvdcapabilityhead_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            string sql = null;
            if (tabControl1.SelectedIndex == 0)
            {
                for (int i = 0; i < dgvdcapabilityhead.Rows.Count; i++)
                {
                    if (dgvdcapabilityhead.Rows[i].Cells[0].Value.ToString().Length > 0)
                    {
                        sql = "update  NEW_ID_CAPABILITY_HEAD   set [CHARACTER]='" + dgvdcapabilityhead.Rows[i].Cells[2].Value + "',MINI_SIGN='" + dgvdcapabilityhead.Rows[i].Cells[3].Value + "',MINI_VALUE=" + dgvdcapabilityhead.Rows[i].Cells[4].Value
                           + ",MINI_EXPONENTIAL=" + dgvdcapabilityhead.Rows[i].Cells[5].Value + ",MAX_SIGN='" + dgvdcapabilityhead.Rows[i].Cells[6].Value + "',MAX_VALUE=" +
                               dgvdcapabilityhead.Rows[i].Cells[7].Value + ",MAX_EXPONENTIAL=" + dgvdcapabilityhead.Rows[i].Cells[8].Value + ",MTEXT='" + dgvdcapabilityhead.Rows[i].Cells[9].Value + "'" + ",COMMENTS1='" + dgvdcapabilityhead.Rows[i].Cells[10].Value + "'" +
                                ",pcode='" + dgvdcapabilityhead.Rows[i].Cells[11].Value + "'" + "  where Id=" + dgvdcapabilityhead.Rows[i].Cells[0].Value;
                    }
                    else
                    {
                        sql = "insert  into NEW_ID_CAPABILITY_HEAD(DATA_ID,[CHARACTER],MINI_SIGN,MINI_VALUE,MINI_EXPONENTIAL,MAX_SIGN,MAX_VALUE,MAX_EXPONENTIAL,MTEXT,COMMENTS1,pcode,status)  values('" +
                                  dataid + "','" + dgvdcapabilityhead.Rows[i].Cells[2].Value + "','" + dgvdcapabilityhead.Rows[i].Cells[3].Value + "'," +
                              dgvdcapabilityhead.Rows[i].Cells[4].Value + "," + dgvdcapabilityhead.Rows[i].Cells[5].Value + ",'" +
                              dgvdcapabilityhead.Rows[i].Cells[6].Value + "'," + dgvdcapabilityhead.Rows[i].Cells[7].Value + "," +
                              dgvdcapabilityhead.Rows[i].Cells[8].Value + ",'" + dgvdcapabilityhead.Rows[i].Cells[9].Value + "','" + dgvdcapabilityhead.Rows[i].Cells[10].Value + "','" + dgvdcapabilityhead.Rows[i].Cells[11].Value + "',1)";
                    }
                    DataOperation.Execsql(sql);
                }
                bulidcapabilityhead(dataid);
            }
            if (tabControl1.SelectedIndex == 1)
                {
                    for (int i = 0; i < dgvperformance.Rows.Count; i++)
                    {
                        if (dgvperformance.Rows[i].Cells[0].Value.ToString().Length > 0)
                        {
                            sql = "update  NEW_ID_CAPABILITY   set  CAPA1='" + dgvperformance.Rows[i].Cells[2].Value + "',CAPA2='" + dgvperformance.Rows[i].Cells[3].Value + "',CAPA3='" + dgvperformance.Rows[i].Cells[4].Value+
                                    "',MIN_SIGN = '" + dgvperformance.Rows[i].Cells[5].Value + "',MIN_VALUE=" + dgvperformance.Rows[i].Cells[6].Value + ",MIN_EXPONENTIAL=" + dgvperformance.Rows[i].Cells[7].Value+
                                   ",MAX_SIGN = '" + dgvperformance.Rows[i].Cells[8].Value + "',MAX_VALUE=" + dgvperformance.Rows[i].Cells[9].Value + ",MAX_EXPONENTIAL=" + dgvperformance.Rows[i].Cells[10].Value +
                                   ",TEST_METHOD='" + dgvperformance.Rows[i].Cells[11].Value + "',TEST_CONDITION='" + dgvperformance.Rows[i].Cells[12].Value + "',MTEXT='" + dgvperformance.Rows[i].Cells[13].Value 
                                   + "'  where Id=" + dgvperformance.Rows[i].Cells[0].Value;
                        }
                        else
                        {
                            sql = "insert  into NEW_ID_CAPABILITY(DATA_ID,CAPA1,CAPA2,CAPA3,MIN_SIGN,MIN_VALUE,MIN_EXPONENTIAL,MAX_SIGN,MAX_VALUE,MAX_EXPONENTIAL,TEST_METHOD,TEST_CONDITION,MTEXT,[status],CAPA1code,CAPA2code,CAPA3code)  " +
                            "values('" +  dataid + "','" + dgvperformance.Rows[i].Cells[2].Value + "','" + dgvperformance.Rows[i].Cells[3].Value + "','" + dgvperformance.Rows[i].Cells[4].Value + "','" + dgvperformance.Rows[i].Cells[5].Value + "'," +
                                  dgvperformance.Rows[i].Cells[6].Value + "," + dgvperformance.Rows[i].Cells[7].Value + ",'" + dgvperformance.Rows[i].Cells[8].Value + "'," + dgvperformance.Rows[i].Cells[9].Value + "," +
                                  dgvperformance.Rows[i].Cells[10].Value + ",'" + dgvperformance.Rows[i].Cells[11].Value +"','"+ dgvperformance.Rows[i].Cells[12].Value + "','" +    dgvperformance.Rows[i].Cells[13].Value

                                  + "',1,'" + dgvperformance.Rows[i].Cells[15].Value+ "','"+dgvperformance.Rows[i].Cells[16].Value + "','" + dgvperformance.Rows[i].Cells[17].Value + "')";
                        }
                    DataOperation.Execsql(sql);
                     }
                bulidperformance(dataid);

            }

            if (tabControl1.SelectedIndex == 2)
            {
                
                    if ( DataOperation.ExecQuery("select * from  NEW_ID_EXAMINE_NEW  where DATA_ID='"+ dataid+"'").Rows.Count>0)
                    {
                    sql = "update  NEW_ID_EXAMINE_NEW   set  TESTTYPE='" + TESTTYPE.Text + "',TESTNAME='" + TESTNAME.Text + "',METHOD='" + METHOD.Text +
                            "',CONDITION = '" + CONDITION.Text + "',RESULT='" + PRESULT.Text + "'"
                           + "  where DATA_ID='" + dataid + "'";; 
                    }
                    else
                    {
                        sql = "insert  into NEW_ID_EXAMINE_NEW(DATA_ID,TESTTYPE,TESTNAME,METHOD,CONDITION,RESULT)  " +
                        "values('" + dataid + "','" + TESTTYPE.Text + "','" + TESTNAME.Text + "','" + METHOD.Text + "','" + CONDITION.Text + "','" +
                              PRESULT.Text+ "')";
                    }
                    DataOperation.Execsql(sql);
                
                bulidpexam(dataid);

            }


        }


        private  void bulidpexam(string idataid)
        {
          DataTable dt=  DataOperation.ExecQuery("select * from  NEW_ID_EXAMINE_NEW  where DATA_ID='" + dataid + "'");
            if  (dt.Rows.Count>0)
            {
                TESTTYPE.Text = dt.Rows[0]["TESTTYPE"].ToString();
                TESTNAME.Text = dt.Rows[0]["TESTNAME"].ToString();
                METHOD.Text = dt.Rows[0]["METHOD"].ToString();
                CONDITION.Text = dt.Rows[0]["CONDITION"].ToString();
                PRESULT.Text = dt.Rows[0]["RESULT"].ToString();
            }


        }
        private void del_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                if (this.dgvdcapabilityhead.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < dgvdcapabilityhead.SelectedRows.Count; i++)
                    {
                        if (!int.TryParse(dgvdcapabilityhead.SelectedRows[i].Cells[0].Value.ToString(), out int x))
                        {
                            dgvdcapabilityhead.Rows.RemoveAt(dgvdcapabilityhead.SelectedRows[i].Index);
                        }
                        else
                        {
                            if ((int)dgvdcapabilityhead.SelectedRows[i].Cells[12].Value == 1)
                            {
                                DataOperation.Execsql("delete   from  NEW_ID_CAPABILITY_HEAD  where id=" + x);
                                bulidcapabilityhead(dataid);
                            }
                            else
                            {
                                MessageBox.Show("非新增项目，不能删除！");
                            }
                        }

                    }

                }
            }
            if (tabControl1.SelectedIndex == 1)
            {
                if (this.dgvperformance.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < dgvperformance.SelectedRows.Count; i++)
                    {
                        if (!int.TryParse(dgvperformance.SelectedRows[i].Cells[0].Value.ToString(), out int x))
                        {
                            dgvperformance.Rows.RemoveAt(dgvperformance.SelectedRows[i].Index);
                        }
                        else
                        {
                            if ((int)dgvperformance.SelectedRows[i].Cells[14].Value == 1)
                            {
                                DataOperation.Execsql("delete   from  NEW_ID_CAPABILITY  where id=" + x);
                                bulidperformance(dataid);
                            }
                            else
                            {
                                MessageBox.Show("非新增项目，不能删除！");
                            }
                        }

                    }

                }
            }
        }

        private void dgvdcapabilityhead_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void bulidperformance(string idataid)
        {

            DataTable dt = DataOperation.ExecQuery("select id,DATA_ID,CAPA1,CAPA2,CAPA3,MIN_SIGN,MIN_VALUE,MIN_EXPONENTIAL,MAX_SIGN,MAX_VALUE,MAX_EXPONENTIAL,TEST_METHOD,TEST_CONDITION,MTEXT,status,CAPA1code,CAPA2code,CAPA3code       from NEW_ID_CAPABILITY where data_id='" + idataid + "'");
            dgvperformance.DataSource = null;
            if (dt != null)
            {
                DataGridViewTextBoxColumn column0 = new DataGridViewTextBoxColumn();
                column0.DataPropertyName = "id";//对应数据源的字段
                this.dgvperformance.Columns.Add(column0);
                this.dgvperformance.Columns[0].Visible = false;

                DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
                column1.DataPropertyName = "DATA_ID";//对应数据源的字段
                this.dgvperformance.Columns.Add(column1);
                this.dgvperformance.Columns[1].Visible = false;


                DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
                column2.HeaderText = "一级性能";
                column2.DataPropertyName = "CAPA1";//对应数据源的字段
                column2.ReadOnly = true;
                this.dgvperformance.Columns.Add(column2);

                DataGridViewTextBoxColumn column21 = new DataGridViewTextBoxColumn();
                column21.HeaderText = "二级性能";
                column21.ReadOnly = true;
                column21.DataPropertyName = "CAPA2";//对应数据源的字段
                this.dgvperformance.Columns.Add(column21);

                DataGridViewTextBoxColumn column22 = new DataGridViewTextBoxColumn();
                column22.HeaderText = "三级性能";
                column22.ReadOnly = true;
                column22.DataPropertyName = "CAPA3";//对应数据源的字段
                this.dgvperformance.Columns.Add(column22);

                List<string> ListData = new List<string> { ">=", ">", "=" };
                DataGridViewComboBoxColumn column3 = new DataGridViewComboBoxColumn();
                column3.Name = "Name";
                column3.DataPropertyName = "MIN_SIGN";//对应数据源的字段
                column3.HeaderText = " ";
                column3.Width = 40;
                this.dgvperformance.Columns.Add(column3);
                column3.DataSource = ListData;

                DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
                column4.Name = "MIN_VALUE";
                column4.DataPropertyName = "MIN_VALUE";//对应数据源的字段
                column4.HeaderText = "下界数据";
                column4.Width = 80;
                this.dgvperformance.Columns.Add(column4);

                DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
                column5.Name = "MIN_EXPONENTIAL";
                column5.DataPropertyName = "MIN_EXPONENTIAL";//对应数据源的字段
                column5.HeaderText = "幂次";

                column5.Width = 80;
                this.dgvperformance.Columns.Add(column5);

                List<string> ListData1 = new List<string> { "<=", "<", "=" };
                DataGridViewComboBoxColumn column6 = new DataGridViewComboBoxColumn();
                column6.Name = "MAX_SIGN";
                column6.DataPropertyName = "MAX_SIGN";//对应数据源的字段
                column6.HeaderText = " ";
                column6.Width = 40;
                this.dgvperformance.Columns.Add(column6);
                column6.DataSource = ListData1;

                DataGridViewTextBoxColumn column7 = new DataGridViewTextBoxColumn();
                column7.Name = "MAX_VALUE";
                column7.DataPropertyName = "MAX_VALUE";//对应数据源的字段
                column7.HeaderText = "上界数据";
                column7.Width = 80;
                this.dgvperformance.Columns.Add(column7);

                DataGridViewTextBoxColumn column8 = new DataGridViewTextBoxColumn();
                column8.Name = "MAX_EXPONENTIAL";
                column8.DataPropertyName = "MAX_EXPONENTIAL";//对应数据源的字段
                column8.HeaderText = "幂次";
                column8.Width = 80;
                this.dgvperformance.Columns.Add(column8);

                DataGridViewTextBoxColumn column9 = new DataGridViewTextBoxColumn();
                column9.Name = "TEST_METHOD";
                column9.DataPropertyName = "TEST_METHOD";//对应数据源的字段
                column9.HeaderText = "测试方法";
                column9.Width = 300;
                this.dgvperformance.Columns.Add(column9);

                DataGridViewTextBoxColumn column10 = new DataGridViewTextBoxColumn();
                column10.Name = "测试条件";
                column10.DataPropertyName = "TEST_CONDITION";//对应数据源的字段
                column10.HeaderText = "测试条件";
                column10.Width = 300;
                this.dgvperformance.Columns.Add(column10);


                DataGridViewTextBoxColumn column11 = new DataGridViewTextBoxColumn();
                column11.Name = "MTEXT";
                column11.DataPropertyName = "MTEXT";//对应数据源的字段
                column11.HeaderText = "备注";
                column11.Visible = true;
                this.dgvperformance.Columns.Add(column11);

                DataGridViewTextBoxColumn column12 = new DataGridViewTextBoxColumn();
                column12.DataPropertyName = "status";//对应数据源的字段
                column12.Name = "状态";
                column12.HeaderText = "状态";
                column12.Visible = false;
                this.dgvperformance.Columns.Add(column12);

                DataGridViewTextBoxColumn column13 = new DataGridViewTextBoxColumn();
                column13.DataPropertyName = "CAPA1code";//对应数据源的字段
                column13.Name = "状态";
                column13.HeaderText = "状态";
                column13.Visible = false;
                this.dgvperformance.Columns.Add(column13);

                DataGridViewTextBoxColumn column14= new DataGridViewTextBoxColumn();
                column14.DataPropertyName = "CAPA2code";//对应数据源的字段
                column14.Name = "状态";
                column14.HeaderText = "状态";
                column14.Visible = false;

                this.dgvperformance.Columns.Add(column14);

                DataGridViewTextBoxColumn column15 = new DataGridViewTextBoxColumn();
                column15.DataPropertyName = "CAPA3code";//对应数据源的字段
                column15.Name = "状态";
                column15.HeaderText = "状态";
                column15.Visible = false;
                this.dgvperformance.Columns.Add(column15);

                dgvperformance.DataSource = dt;
            }
        }

        private void dgvperformance_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X,
       e.RowBounds.Location.Y,
       dgvperformance.RowHeadersWidth - 4,
       e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dgvperformance.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dgvperformance.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void dgvperformance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            String x = e.Value.ToString().TrimEnd();

            if (  e.ColumnIndex == 2 && e.Value != null &&x.Substring(x.Length-1,1).Equals("：") )
            {
                e.CellStyle.ForeColor = Color.Red;
                
            }
            if ((e.ColumnIndex == 7) || (e.ColumnIndex == 10))
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

        private void dgvperformance_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 2) return;
            String x = dgvperformance.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            if ( x.Substring(x.Length - 1, 1).Equals("："))
            {
                InputDialog frm = new InputDialog();
                if (frm.ShowDialog() == DialogResult.OK)
                {

                    dgvperformance.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = dgvperformance.Rows[e.RowIndex].Cells[e.ColumnIndex].Value + frm.Result;
                    dgvperformance.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor= Color.Red;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
             
        }

        private void dgvperformance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
