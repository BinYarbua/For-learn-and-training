using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace ExpMangment.BussineL
{
    class CLSExpensed
    {
        DataAcessL.DataAcessLayer exp = new DataAcessL.DataAcessLayer();

        // This Method to get all exp that display in gridViwe
        public DataTable Get_All_Exp()
        {
            DataTable dt = new DataTable();
            dt =exp.selectData("Get_All_Exp", null);
            exp.close();
            return dt;
        }

        //This Method to ar_name of EXP to ensure its only one name
        public DataTable Get_The_Same_ar_Name(string ar_Name)
        {
            DataTable dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ar_Name", SqlDbType.NVarChar, 50);
            param[0].Value = ar_Name;
            
            dt = exp.selectData("Get_The_Same_Name",param );
            exp.close();
            return dt;
        }

        public DataTable Get_The_Same_eng_Name(string ar_Name)
        {
            DataTable dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@eng_Name", SqlDbType.NVarChar, 50);
            param[0].Value = ar_Name;

            dt = exp.selectData("Get_The_Same_eng_Name", param);
            exp.close();
            return dt;
        }
        //This Method to add exp 
        public void ADD_EXP(string exp_arbicName ,string exp_engName,string exp_Info,byte[] image)
        {
            exp.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@arbic_Name", SqlDbType.NVarChar, 50);
            param[0].Value = exp_arbicName;

            param[1] = new SqlParameter("@eng_Name", SqlDbType.NVarChar, 50);
            param[1].Value = exp_engName;

            param[2] = new SqlParameter("@Info", SqlDbType.Text );
            param[2].Value = exp_Info;
            
            param[3] = new SqlParameter("@image", SqlDbType.Image );
            param[3].Value = image;

            exp.excutedCommand("ADD_EXP", param);
            exp.close();
        }
       
        //Method to updata Exp
        public void UPDATA_EXP(string exp_arbicName, string exp_engName, string exp_Info, byte[] image,string name)
        {
            exp.open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@arbic_Name", SqlDbType.NVarChar, 50);
            param[0].Value = exp_arbicName;

            param[1] = new SqlParameter("@eng_Name", SqlDbType.NVarChar, 50);
            param[1].Value = exp_engName;

            param[2] = new SqlParameter("@Info", SqlDbType.Text);
            param[2].Value = exp_Info;

            param[3] = new SqlParameter("@image", SqlDbType.Image);
            param[3].Value = image;

            param[4] = new SqlParameter("@NameBeforUpdate", SqlDbType.VarChar, 30);
            param[4].Value = name;

            exp.excutedCommand("UPDATA_EXP", param);
            exp.close();
        }
        public void DELETE_EXP(string ar_Name_Of_EXP)
        {
            exp.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@arbic_Name", SqlDbType.NVarChar, 30);
            param[0].Value = ar_Name_Of_EXP;

            exp.excutedCommand("DELETE_EXP", param);
            exp.close();

        }
    }
}
