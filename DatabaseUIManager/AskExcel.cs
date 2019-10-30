using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseUIManager
{
    class AskExcel
    {
        public static DataSet getData()
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Excel(*.xlsx)|*.xlsx|Excel(*.xls)|*.xls";
            file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            file.Multiselect = false;
            if (file.ShowDialog() == DialogResult.Cancel)
                return null;
            var path = file.FileName;
            string fileSuffix = System.IO.Path.GetExtension(path);
            if (string.IsNullOrEmpty(fileSuffix))
                return null;
            using (DataSet ds = new DataSet())
            {
                //判断Excel文件是2003版本还是2007版本
                string connString = "";
                if (fileSuffix == ".xls")
                    connString = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + path + ";" + ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"";
                else
                    connString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + path + ";" + ";Extended Properties=\"Excel 12.0;HDR=YES;IMEX=1\"";
                //读取文件
                string sql_select = " SELECT * FROM [appstore_games$]";
                using (OleDbConnection conn = new OleDbConnection(connString))
                using (OleDbDataAdapter cmd = new OleDbDataAdapter(sql_select, conn))
                {
                    conn.Open();
                    cmd.Fill(ds);
                }
                if (ds == null || ds.Tables.Count <= 0) return null;
                return ds;
            }
        }
        static OdbcConnection mConn;
        public static OdbcDataReader getODBC()
        {
            string strConn = @"Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};ReadOnly=False;Dbq=";//Driver驱动程序,ReadOnly=False必须有，否则插入数据会报错,Dbq
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Excel(*.xlsx)|*.xlsx|Excel(*.xls)|*.xls";
            file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            file.Multiselect = false;
            if (file.ShowDialog() == DialogResult.Cancel)
                return null;
            var path = file.FileName;
            strConn += path;
            System.Data.Odbc.OdbcConnection odbcConn = new System.Data.Odbc.OdbcConnection(strConn);//ODBC连接
            try
            {
                odbcConn.Open();//打开连接
                string sSQL = "SELECT * FROM [appstore_games$]";//注意格式，SQL语句查询表格所有的数据
                System.Data.Odbc.OdbcCommand command = new System.Data.Odbc.OdbcCommand(sSQL, odbcConn);//初始化ODBC命令
                mConn = odbcConn;
               // comm.ExecuteNonQuery();//执行SQL语句
                return command.ExecuteReader();

            }
            catch (Exception excp)
            {
                throw excp;
            }
        }
        public static void Add()
        {
            int value = new Random().Next();
            OdbcCommand command = new OdbcCommand("INSERT INTO [appstore_games$] (URL) VALUES (123456)",mConn);
            command.ExecuteNonQuery();
        }
    }
}
