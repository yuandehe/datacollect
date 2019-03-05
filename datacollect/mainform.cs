using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class mainform : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        string strConn = " Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = Database11.mdb";

        public mainform()
        {
            InitializeComponent();
            openFileDialog.InitialDirectory = "e:\\";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "文本文件|*.*|C#文件|*.cs|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_LeftToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_BottomToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void Inputbaseinfo()
        {
            System.IO.Stream myStream;
            int allResult = 0;
            int allResult1 = 0;
            string sql;
            if (!(MessageBox.Show("确认导入数据，将会清空以前的数据？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK))
            {
                return;
            }
            DataOperation.Execsql("delete   from [commpany]");
            DataOperation.Execsql("delete   from [applicationArea]");
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        StreamReader st = new StreamReader(openFileDialog.FileName, Encoding.GetEncoding("utf-8"));
                        string str = st.ReadLine();
                        while (str != null)
                        {

                            string[] sArray1 = str.Split(new string[] { "#$&" }, StringSplitOptions.RemoveEmptyEntries);
                            int xx = sArray1.Length;
                            //导入单位数据
                            if ((sArray1.Length == 4) && sArray1[3].Equals("######"))
                            {
                                sql = "insert  into [commpany]([Code],[pname],[memo])  values ('" + sArray1[0] + "','" + sArray1[1] + "','" + sArray1[2] + "')";
                                try
                                {
                                    int inResult = DataOperation.Execsql(sql);
                                    if (inResult > 0)
                                    {
                                        allResult = allResult + 1;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("添加异常：" + ex.Message, "提示");
                                }
                            }
                            //导入应用领域数据
                            //导入单位数据
                            if ((sArray1.Length == 5) && sArray1[4].Equals("######"))
                            {
                                sql = "insert  into [applicationArea]([firstLevelCode],[secondLevelCode],[firstLevelName],[secondLevelName])  values ('" + sArray1[0] + "','" + sArray1[1] + "','" + sArray1[2] + "','" + sArray1[3] + "')";
                                try
                                {
                                    int inResult = DataOperation.Execsql(sql);
                                    if (inResult > 0)
                                    {
                                        allResult1 = allResult1 + 1;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("添加异常：" + ex.Message, "提示");
                                }
                            }
                            str = st.ReadLine();
                        }

                        MessageBox.Show("导入单位数据" + allResult + "条/13" + "导入应用领域数据" + allResult1 + "条", "数据添加成功");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("打开文件出错：" + ex.Message);
                }

            }
          //  datainput fm = new datainput();
            //fm.ShowDialog();
        }
        //导入性能数据
        private void Inputperformance()
        {
            System.IO.Stream myStream;
            int allResult = 0;
            int allResult1 = 0;
            string sql;
            if (!(MessageBox.Show("确认导入数据，将会清空以前的数据？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK))
            {
                return;
            }
            //清空原始表
            DataOperation.Execsql("delete   from  [Performance]");
            DataOperation.Execsql("delete   from  [pfeature]");
            DataOperation.Execsql("ALTER TABLE [Performance] ALTER COLUMN [sid] COUNTER (1, 1)");
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        StreamReader st = new StreamReader(openFileDialog.FileName, Encoding.GetEncoding("utf-8"));
                        string str = st.ReadLine();
                        while (str != null)
                        {
                            string[] sArray1 = str.Split(new string[] { "#$&" }, StringSplitOptions.None);
                            int xx = sArray1.Length;
                            //导入单位数据
                            if ((sArray1.Length == 11) && sArray1[10].Equals("######"))
                            {
                                if (sArray1[8].Equals("特征指标"))
                                {
                                    sql = "insert  into [pfeature]([mCode],[pcode],[mname],[pname],[mtext])  values ('";
                                    sql = sql + sArray1[0] + "','" + sArray1[1] + "','" + sArray1[4] + "','" + sArray1[5]  + "','" + sArray1[8] + "')";

                                }
                                else
                                {
                                    sql = "insert  into [performance]([Code],[firstLevelCode],[secondLevelCode],[thirdLevelCode],[pname],[firstLevelName],[secondLevelName],[thirdLevelName],[memo])  values ('";
                                    sql = sql + sArray1[0] + "','" + sArray1[1] + "','" + sArray1[2] + "','" + sArray1[3] + "','" + sArray1[4] + "','" + sArray1[5] + "','" + sArray1[6] + "','" + sArray1[7] + "','" + sArray1[8] + "')";
                                }
                                    try
                                {
                                    int inResult = DataOperation.Execsql(sql);
                                    if (inResult > 0)
                                    {
                                        allResult = allResult + 1;
                                        status.Text = "成功导入性能数据:" + allResult + "条";
                                    }
                                    else
                                    {
                                        status.Text = "失败导入性能数据:" + allResult1 + "条";
                                        allResult1 = allResult1 + 1;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("添加异常：" + ex.Message, "提示");
                                }
                            }
                          
                            str = st.ReadLine();
                        }

                        MessageBox.Show("导入性能数据" + allResult + "条", "数据添加成功");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("打开文件出错：" + ex.Message);
                }

            }

        }
        //导入材料体系数据
        private void Inputsystem()
        {
            System.IO.Stream myStream;
            int allResult = 0;
            int allResult1 = 0;
            string sql = "" ;
            if (!(MessageBox.Show("确认导入数据，将会清空以前的数据？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK))
            {
                return;
            }
            //清空原始表
            DataOperation.Execsql("delete   from  [materialsystem]");
                  DataOperation.Execsql("ALTER TABLE [materialsystem] ALTER COLUMN [sid] COUNTER (1, 1)");
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        StreamReader st = new StreamReader(openFileDialog.FileName, Encoding.GetEncoding("utf-8"));
                        string str = st.ReadLine();
                        while (str != null)
                        {
                            string[] sArray1 = str.Split(new string[] { "#$&" }, StringSplitOptions.None);
                            int xx = sArray1.Length;
                            //导入单位数据
                            if ((sArray1.Length == 9) && sArray1[8].Equals("######"))
                            {
                                sql = "insert  into [materialSystem]([firstLevelCode],[secondLevelCode],[thirdLevelCode],[firstLevelName],[secondLevelName],[thirdLevelName],[memo])  values ('";
                                sql = sql + sArray1[0] + "','" + sArray1[1] + "','" + sArray1[2] + "','" + sArray1[3] + "','" + sArray1[4] + "','" + sArray1[5] + "','" + sArray1[6] + "')";
                                try
                                {
                                    int inResult = DataOperation.Execsql(sql);
                                    if (inResult > 0)
                                    {
                                        allResult = allResult + 1;
                                        status.Text = "成功导入材料体系数据:" + allResult + "条";
                                    }
                                    else
                                    {
                                        status.Text = "失败导入材料体系数据:" + allResult1 + "条";
                                        allResult1 = allResult1 + 1;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("添加异常：" + ex.Message, "提示");
                                }
                            }

                            str = st.ReadLine();
                        }
                    }
                    MessageBox.Show("导入材料体系数据" + allResult + "条", "数据添加成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("打开文件出错：" + ex.Message);
                }

            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Inputbaseinfo();
        }

        private void 牌号基础信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inputbaseinfo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inputperformance();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Inputsystem();
        }

        private void 性能条目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inputperformance();
        }

        private void 数据维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datainput fm = new datainput();
            fm.ShowDialog();
        }

        private void 材料体系ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inputsystem();
        }

        private void 主菜单ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 导入数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            materialmanger fm = new materialmanger();
            fm.ShowDialog();
        }

        private void 技术标准信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stand fm = new stand();
            fm.Show();
        }

        private void 表2材料性能数据采集表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            performance fm = new performance();
            fm.ShowDialog();
        }

        private void 表3单位信息采集表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commpanymanger fm = new commpanymanger();
            fm.ShowDialog();
        }

        private void 人员信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            peoplemanger fm = new peoplemanger();
            fm.ShowDialog();
        }

        private void 数据删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delmaterial  fm = new delmaterial();
            fm.ShowDialog();
        }

        private void 数据审核ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkmaterial fm = new checkmaterial();
            fm.ShowDialog();
        }

        private void 取消审核ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cancelcheckmaterial fm = new cancelcheckmaterial();
            fm.ShowDialog(); 

        }

        private void 数据上报ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string separator = "#$&"; //分隔符标签
            string datetag = "@@@";//日期标签
            string headtag = "&&&&&&";//p牌号标签
            string tabletag = "******";//表标签
            string datatag = "######";//数据标签
            DataTable dt = null;

            try
              {
                     FileStream fs = new FileStream("output.txt", FileMode.Create);
                        StreamWriter sw = new StreamWriter(fs);
                      sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ms")+ datetag);
                      dt = DataOperation.ExecQuery("Select *  from materialbase where checked=1");
                       sw.WriteLine(dt.Rows.Count.ToString());
               //输出牌号列表
                     for  (int i=0;i<dt.Rows.Count;i++)            
                       {
                    sw.WriteLine(dt.Rows[i]["DATA_ID"].ToString() + separator + headtag);
                        }
                 //输出各各个数据表
                sw.WriteLine("new_head" + tabletag);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sw.WriteLine(dt.Rows[i]["DATA_ID"].ToString() + separator+ dt.Rows[i]["DATA_ID"].ToString() + separator + dt.Rows[i]["DATA_NAME"].ToString() + separator+ dt.Rows[i]["DATA_FOREIGN"].ToString()+
                    dt.Rows[i]["DATA_SORT1"].ToString() + separator + dt.Rows[i]["DATA_SORT2"].ToString() + separator + dt.Rows[i]["DATA_SERIES"].ToString() + separator + dt.Rows[i]["GATHER_NAME"].ToString() +
                    dt.Rows[i]["GATHER_COMPANY"].ToString() + separator + dt.Rows[i]["GATHER_YEAR"].ToString() + separator + dt.Rows[i]["GATHER_MONTH"].ToString() + separator + dt.Rows[i]["GATHER_DAY"].ToString() +
                     dt.Rows[i]["INPUT_NAME"].ToString() + separator+
                    dt.Rows[i]["INPUT_COMPANY"].ToString() + separator + dt.Rows[i]["INPUT_YEAR"].ToString() + separator + dt.Rows[i]["INPUT_MONTH"].ToString() + separator + dt.Rows[i]["INPUT_DAY"].ToString() +
                    dt.Rows[i]["AUDITING_NAME"].ToString() + separator + dt.Rows[i]["AUDITING_COMPANY"].ToString() + separator + dt.Rows[i]["AUDITING_YEAR"].ToString() + separator + dt.Rows[i]["AUDITING_MONTH"].ToString() + 
                    dt.Rows[i]["Auditing_day"].ToString() + separator + dt.Rows[i]["checked"].ToString() + separator + datatag);
                }

                sw.WriteLine("NEW_ID_APPLY" + tabletag);
                dt = DataOperation.ExecQuery("select *   from  NEW_ID_APPLY  where DATA_ID in  (Select DATA_ID  from materialbase where checked=1) order  by  DATA_ID");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sw.WriteLine(dt.Rows[i]["DATA_ID"].ToString() + separator + dt.Rows[i]["FIELD"].ToString() + separator + dt.Rows[i]["WEAPON"].ToString() + separator + dt.Rows[i]["BACKGROUMD"].ToString() +
                    dt.Rows[i]["PART"].ToString() + separator + dt.Rows[i]["RESULT"].ToString() + separator + datatag);
                }
                
                 sw.WriteLine("NEW_ID_BREED" + tabletag);
                dt = DataOperation.ExecQuery("select *   from  NEW_ID_BREED  where DATA_ID in  (Select DATA_ID  from materialbase where checked=1) order  by  DATA_ID");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sw.WriteLine(dt.Rows[i]["DATA_ID"].ToString() + separator + dt.Rows[i]["STATUS"].ToString() + separator + dt.Rows[i]["SPEC"].ToString() + separator + datatag);
                }

                sw.WriteLine("NEW_ID_CAPABILITY" + tabletag);
                dt = DataOperation.ExecQuery("select *   from  NEW_ID_CAPABILITY  where DATA_ID in  (Select DATA_ID  from materialbase where checked=1) order  by  DATA_ID");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (( int.Parse(dt.Rows[i]["MIN_VALUE"].ToString()) ==0) &&(int.Parse(dt.Rows[i]["MAX_VALUE"].ToString()) == 0))    continue;  //如果上下限为0  表示数据没填
                    sw.WriteLine(dt.Rows[i]["DATA_ID"].ToString() + separator + dt.Rows[i]["CAPA1"].ToString() + separator + dt.Rows[i]["CAPA2"].ToString() + separator + dt.Rows[i]["CAPA3"].ToString() +
                    dt.Rows[i]["TEST_METHOD"].ToString() + separator + dt.Rows[i]["TEST_CONDITION"].ToString() + separator + dt.Rows[i]["MIN_SIGN"].ToString()+
                    dt.Rows[i]["MIN_VALUE"].ToString() + separator + dt.Rows[i]["MIN_EXPONENTIAL"].ToString() + separator + dt.Rows[i]["MAX_SIGN"].ToString() + separator + dt.Rows[i]["MAX_VALUE"].ToString() +
                    dt.Rows[i]["MAX_EXPONENTIAL"].ToString() + separator + dt.Rows[i]["MTEXT"].ToString() + separator + datatag);
                }
                sw.WriteLine("NEW_ID_CAPABILITY_HEAD" + tabletag);
                dt = DataOperation.ExecQuery("select *   from  NEW_ID_CAPABILITY_HEAD  where DATA_ID in  (Select DATA_ID  from materialbase where checked=1) order  by  DATA_ID");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if ((int.Parse(dt.Rows[i]["MINI_VALUE"].ToString()) == 0) && (int.Parse(dt.Rows[i]["MAX_VALUE"].ToString()) == 0)) continue;  //如果上下限为0  表示数据没填
                    sw.WriteLine(dt.Rows[i]["DATA_ID"].ToString() + separator + dt.Rows[i]["CHARACTER"].ToString() + separator + dt.Rows[i]["MINI_SIGN"].ToString() + separator + dt.Rows[i]["MINI_VALUE"].ToString() +
                    dt.Rows[i]["MINI_EXPONENTIAL"].ToString() + separator + dt.Rows[i]["MAX_SIGN"].ToString() + separator + dt.Rows[i]["MAX_VALUE"].ToString() +
                    dt.Rows[i]["MAX_EXPONENTIAL"].ToString() + separator + dt.Rows[i]["MTEXT"].ToString() + separator + dt.Rows[i]["COMMENTS1"].ToString() + separator + datatag);
                }

                sw.WriteLine("NEW_ID_COMPONET" + tabletag);
                dt = DataOperation.ExecQuery("select *   from  NEW_ID_COMPONET  where DATA_ID in  (Select DATA_ID  from materialbase where checked=1) order  by  DATA_ID");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                   
                    sw.WriteLine(dt.Rows[i]["DATA_ID"].ToString() + separator + dt.Rows[i]["COMPONET"].ToString() + separator + dt.Rows[i]["MINI_SIGN"].ToString() + separator + dt.Rows[i]["MINI_VALUE"].ToString() +
                    dt.Rows[i]["MINI_EXPONENTIAL"].ToString() + separator + dt.Rows[i]["MAX_SIGN"].ToString() + separator + dt.Rows[i]["MAX_VALUE"].ToString() +
                    dt.Rows[i]["MAX_EXPONENTIAL"].ToString() + separator + dt.Rows[i]["MTEXT"].ToString() + separator +datatag);
                }

                sw.WriteLine("NEW_ID_EXAMINE_NEW" + tabletag);
                dt = DataOperation.ExecQuery("select *   from  NEW_ID_EXAMINE_NEW  where DATA_ID in  (Select DATA_ID  from materialbase where checked=1) order  by  DATA_ID");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sw.WriteLine(dt.Rows[i]["DATA_ID"].ToString() + separator + dt.Rows[i]["TESTTYPE"].ToString() + separator + dt.Rows[i]["TESTNAME"].ToString() + separator + dt.Rows[i]["METHOD"].ToString() +
                    dt.Rows[i]["CONDITION"].ToString() + separator + dt.Rows[i]["RESULT"].ToString() + separator + datatag);
                }

                sw.WriteLine("NEW_ID_PATENT" + tabletag);
                dt = DataOperation.ExecQuery("select *   from  NEW_ID_PATENT  where DATA_ID in  (Select DATA_ID  from materialbase where checked=1) order  by  DATA_ID");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sw.WriteLine(dt.Rows[i]["DATA_ID"].ToString() + separator + dt.Rows[i]["PATENT_NUM"].ToString() + separator + dt.Rows[i]["PATENT_NAME"].ToString() + separator + datatag);
                }

                sw.WriteLine("NEW_ID_PREPARATION" + tabletag);
                dt = DataOperation.ExecQuery("select *   from  NEW_ID_PREPARATION  where DATA_ID in  (Select DATA_ID  from materialbase where checked=1) order  by  DATA_ID");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sw.WriteLine(dt.Rows[i]["DATA_ID"].ToString() + separator + dt.Rows[i]["METHOD"].ToString() + separator + dt.Rows[i]["ART"].ToString() + separator + datatag);
                }

                sw.WriteLine("NEW_ID_PREPARATION" + tabletag);
                dt = DataOperation.ExecQuery("select *   from  NEW_ID_PREPARATION  where DATA_ID in  (Select DATA_ID  from materialbase where checked=1) order  by  DATA_ID");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sw.WriteLine(dt.Rows[i]["DATA_ID"].ToString() + separator + dt.Rows[i]["METHOD"].ToString() + separator + dt.Rows[i]["ART"].ToString() + separator + datatag);
                }
                sw.WriteLine("NEW_ID_PROCESS" + tabletag);
                dt = DataOperation.ExecQuery("select *   from  NEW_ID_PROCESS  where DATA_ID in  (Select DATA_ID  from materialbase where checked=1) order  by  DATA_ID");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sw.WriteLine(dt.Rows[i]["DATA_ID"].ToString() + separator + dt.Rows[i]["METHOD"].ToString() + separator + dt.Rows[i]["ART"].ToString() + separator + datatag);
                }

                sw.WriteLine("NEW_ID_SUPPLY" + tabletag);
                dt = DataOperation.ExecQuery("select *   from  NEW_ID_SUPPLY  where DATA_ID in  (Select DATA_ID  from materialbase where checked=1) order  by  DATA_ID");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sw.WriteLine(dt.Rows[i]["DATA_ID"].ToString() + separator + dt.Rows[i]["COMP_NUM"].ToString() + separator + dt.Rows[i]["COMP_NAME"].ToString() + dt.Rows[i]["COMP_SIGN"].ToString() + separator + datatag);
                }

                sw.WriteLine("NEW_ID_TECHNIQUE" + tabletag);
                dt = DataOperation.ExecQuery("select *   from  NEW_ID_TECHNIQUE  where DATA_ID in  (Select DATA_ID  from materialbase where checked=1) order  by  DATA_ID");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sw.WriteLine(dt.Rows[i]["DATA_ID"].ToString() + separator + dt.Rows[i]["STANDARD_NUM"].ToString() + separator + dt.Rows[i]["STANDARD_NAME"].ToString()  + separator + datatag);
                }
                

                sw.Close();
                  }
                        catch (Exception)
             {
                                throw;
                            }
            }
    }
       
    }
