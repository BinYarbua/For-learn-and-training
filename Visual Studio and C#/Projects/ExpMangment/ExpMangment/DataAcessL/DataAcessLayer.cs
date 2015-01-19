using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

namespace ExpMangment.DataAcessL
{
    class DataAcessLayer
    {
        SqlConnection sqlConnection;

        // constructor for Intiails the sql connection with do object of class
        public DataAcessLayer()
        {
            //sqlConnection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\user\documents\visual studio 2010\Projects\ExpMangment\ExpMangment\DateBase\ExpMangmentDB.mdf;Integrated Security=True;User Instance=True");
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ExpMangment.Properties.Settings.ExpMangmentDBConnectionString"].ToString ());
        }

        //Method to open connection
        public void open()
        {
            if (sqlConnection.State != ConnectionState.Open)
            {
                try { sqlConnection.Open(); }
                catch (Exception e) { throw e; }
            }
        }

        //Method to close connection
        public void close()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                try { sqlConnection.Close(); }
                catch (Exception e) { throw e; }
            }
        }

        //Method to read data from database
        //هنا في هذا الدالة يتم استخدام Stored proceduer
        //وذلك حتى يتم تنفيد جمل الاستعلام على مستوى السيرفو او قاعدة البيانات نفسها 
        //عند استخدام الاستوريج برسيدير هنالك حاجتين لابد من معرفتها 
        // * اسم الـ stored proceduer
        //الباراميتر الخاصة بالstored proceduer
        public DataTable selectData(string stored_proceduer, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_proceduer;
            sqlcmd.Connection = sqlConnection;

            if (param != null)
            {
                for (int i = 0; i<param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            int x = Convert.ToInt32(dt.Rows.Count);
            return dt;
        }
        //من هذه الدالة تمكننا من عمل الاضافة والتعديل والحدف من قاعدة البيانات 
        //وهي دالة واحد فقط
        public void excutedCommand(string stored_proceduer , SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_proceduer;
            sqlcmd.Connection = sqlConnection;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            try
            {
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error MessageBox in " + e);
            }
        }

    }
}
