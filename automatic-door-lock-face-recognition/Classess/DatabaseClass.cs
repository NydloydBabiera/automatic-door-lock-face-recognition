using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace automatic_door_lock_face_recognition.Classess
{
    public class DatabaseClass
    {
        private SqlConnection c_Connection = new SqlConnection(@"Data Source=DESKTOP-MV4LUQ6;Initial Catalog=DB_POS_w_Points;User ID=user_thesis;Password=123456");
        private SqlCommand c_Command = new SqlCommand();
        private SqlDataAdapter c_DataAdapter = new SqlDataAdapter();
        private DataTable c_DataTable = new DataTable();

        private string c_Columname;
        private string c_Values;

        private string c_UpdateColumn;
        private string c_WhereClause;

        public DataTable getdata(string databaseTable, string tableId)
        {
            c_DataTable = new DataTable();

            c_Connection.Open();
            c_DataAdapter = new SqlDataAdapter("Select * from " + databaseTable + " ORDER BY " + tableId + " DESC ", c_Connection);
            c_DataAdapter.SelectCommand.ExecuteNonQuery();
            c_DataAdapter.Fill(c_DataTable);
            c_Connection.Close();

            return c_DataTable;
        }

        public void AddRecord(string databaseTable)
        {
            string sqlQry = "insert into " + databaseTable + "(" + c_Columname + ") values (" + c_Values + ")";
            Console.WriteLine(sqlQry);
            c_Connection.Open();
            c_Command = new SqlCommand(sqlQry, c_Connection);
            c_Command.ExecuteNonQuery();
            c_Connection.Close();
        }

        public void setColumn(string columnName)
        {
            if (c_Columname == string.Empty)
                c_Columname = columnName;
            else
                c_Columname = c_Columname + ", " + columnName;
        }

        public void setValues(string val)
        {
            if (c_Values == string.Empty)
            {
                if (val != "")
                {
                    if (val.Substring(0, 1) == "@")
                        c_Values = " " + val.Substring(1) + " ";
                    else
                        c_Values = "'" + val + "'";
                }


            }
            else
            {

                if (val != "")
                {
                    if (val.Substring(0, 1) == "@")
                        c_Values = c_Values + ", " + val.Substring(1);
                    else
                        c_Values = c_Values + ", '" + val + "'";
                }
                else
                {
                    Console.WriteLine("val:" + val);
                }

            }


        }
    }
}
