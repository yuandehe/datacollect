using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static    class DataOperation
    {
        // string strConn = " Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = Database11.mdb";
        private static OleDbConnection connection;  //连接字符串
      
        private static OleDbDataAdapter da=new OleDbDataAdapter();   //查询适配器
       

        public static OleDbConnection Connection
        {
            get
            {
                string connectionstring = " Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = Database11.mdb";
                if (connection == null)
                {
                    connection = new OleDbConnection(connectionstring);
                    connection.Open();
                }
                    else if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();

                }
                else if (connection.State == System.Data.ConnectionState.Broken)
                {
                    connection.Close();
                    connection.Open();
                }
                return connection;
            }
        }

      public static int Execsql (String   sql)
        {
                OleDbCommand comm = new OleDbCommand(sql,Connection);       //命令
        int resultrow = 0;
            try
            {         
              comm.CommandText =sql;
              resultrow= comm.ExecuteNonQuery();
                return resultrow;
                
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        public static DataTable ExecQuery(String sql)
        {
            OleDbCommand comm = new OleDbCommand(sql, Connection);
            OleDbDataAdapter da = new OleDbDataAdapter(sql, Connection);
            DataSet ds = new DataSet();
            try
            {
                comm.CommandText = sql;
                da.SelectCommand = comm;
                da.Fill(ds);
                return ds.Tables[0];

            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static string GetMD5(string sDataIn)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bytValue, bytHash;
            bytValue = System.Text.Encoding.UTF8.GetBytes(sDataIn);
            bytHash = md5.ComputeHash(bytValue);
            md5.Clear();
            string sTemp = "";
            for (int i = 0; i < bytHash.Length; i++)
            {
                sTemp += bytHash[i].ToString("X").PadLeft(2, '0');
            }
            return sTemp.ToLower();
        }


    }
}
