using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseUIManager
{
    class AskPgSQL
    {

        private static NpgsqlConnection conn=null;
        private static string connString= "Host=127.0.0.1;Username=fsfgfbfhty ;Password=fsfgfbfhty";
        private static NpgsqlCommand cmd=null;
        private static string nowdtb;

        public static NpgsqlConnection connection()
        {   
             conn = new NpgsqlConnection(connString);
             conn.Open();
            return conn;

        }

        public static NpgsqlConnection connection(string dbName)
        {
            nowdtb = dbName;
            conn = new NpgsqlConnection(connString+";Database="+dbName);
            conn.Open();
            return conn;
        }

        public static NpgsqlDataReader Fullinq(string tblName,string constraints)
        {
            string command = "SELECT * FROM " + tblName;
            if (constraints.Length != 0) command = command + " WHERE " + constraints;
            cmd = new NpgsqlCommand(command, connection(nowdtb));
            var reader = executeSqlReadCommand(command);
            return reader;
        }

        public static NpgsqlDataReader tableNameinq()
        {
            string command = "SELECT tableName FROM pg_tables WHERE tableowner = 'postgres'";
            return executeSqlReadCommand(command);
        }
        public static NpgsqlDataReader dbNameinq()
        {
            cmd = new NpgsqlCommand("SELECT datname FROM pg_database", connection());
            return cmd.ExecuteReader();
        }

        public static void creatTable(string sqlCmd)
        {
            executeSqlCommand(sqlCmd);
        }

        public static int insertRow(string tblName, string key, string value,bool is_numeric)
        {
            if (!is_numeric)
                value = '\'' + value + '\'';
            string command = "INSERT INTO " + tblName + " ";
            command = command + "(" + key + ")" + " VALUES " + " " + "(" + value + ")";
            return executeSqlCommand(command);
        }

        public static int deleteCol(string tblName, string colName)
        {
            string command = "ALTER TABLE " + tblName + " DROP COLUMN " + colName;
            return executeSqlCommand(command);
        }

        public static int deleteRow(string tblName,string constraints)
        {
            string command = "DELETE FROM " + tblName + " ";

            if (constraints.Length != 0)
                command = command + " WHERE " + constraints;
            return executeSqlCommand(command);
        }

        public static int updateCell(string tblName,string constraints, string colName, string value,bool is_numeric = false)
        {
            if (!is_numeric)
                value = '\'' + value + '\'';
            string command = "UPDATE " + tblName + " SET " + colName + " = " + value;

            if (constraints.Length != 0)
                command = command + " WHERE " + constraints;
            return executeSqlCommand(command);
        }
        public static int dropTable(string tblName)
        {
            string command = "DROP TABLE " + tblName;
            return executeSqlCommand(command);
        }

        public static int addColumn(string tblName,string colName,string colType)
        {
            string command = "ALTER TABLE " + tblName + " ADD COLUMN " + colName +" "+ colType;
            return executeSqlCommand(command);
        }

        public static int altetColType(string tblName,string colName,string alterType)
        {
            string command = "ALTER TABLE " + tblName + " ALTER COLUMN " + colName + " TYPE " + alterType;
            return executeSqlCommand(command);
        }

        public static int copyFrom(string tblName,string filedir)
        {
            string command = "COPY "+tblName +" FROM " +"'"+filedir+" '" ;
            if (filedir.Substring(filedir.Length - 4) == ".csv") command += " DELIMITER AS \',\'";
            return executeSqlCommand(command);
            
        }
        private static int executeSqlCommand(string command)
        {
            cmd = new NpgsqlCommand(command, connection(nowdtb));
            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (PostgresException e)
            {
                System.Windows.Forms.MessageBox.Show(e.MessageText);
                return -1;
            }
        }
        private static NpgsqlDataReader executeSqlReadCommand(string command)
        {
            cmd = new NpgsqlCommand(command, connection(nowdtb));
            try
            {
                return cmd.ExecuteReader();
            }
            catch(PostgresException e)
            {
                System.Windows.Forms.MessageBox.Show(e.MessageText);
                return null;
            }
        }
       }
}
