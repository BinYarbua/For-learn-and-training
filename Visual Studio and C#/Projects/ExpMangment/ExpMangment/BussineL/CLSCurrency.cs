using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ExpMangment.BussineL
{
    class CLSCurrency
    {
        DataAcessL.DataAcessLayer CURRENCY = new DataAcessL.DataAcessLayer();

        //Method to get the main currency
        public DataTable GET_MAIN_CURRENCY()
        {
            DataTable  DT = new DataTable();
            DT = CURRENCY.selectData("GET_MAIN_CURRENCY", null);
            return DT;
        }

        //Method to get all currency
        public DataTable GET_ALL_CURRENCY()
        {
            DataTable DT = new DataTable();
            DT = CURRENCY.selectData("GET_ALL_CURRENCY", null);
            return DT;
        }
        //Method to get Currency by Name to compere 
        public DataTable GET_CURRENCY_BYNAME(string currency_Name)
        {
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@currency_Name", SqlDbType.NVarChar, 50);
            param[0].Value = currency_Name;

            DT = CURRENCY.selectData("GET_CURRENCY_BYNAME", param);
            return DT;
        }
        //Method to add Currency
        public void ADD_CURRENCY(string AR_Name_Of_Currency, string EN_Name_of_Currency, string Simple_Ar,
                                string Simple_En, string Exchang_Price, string Is_Main, string Note)
        {
            CURRENCY.open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@AR_Name_Of_Currency", SqlDbType.NVarChar, 50);
            param[0].Value = AR_Name_Of_Currency;

            param[1] = new SqlParameter("@EN_Name_of_Currency", SqlDbType.NVarChar, 50);
            param[1].Value = EN_Name_of_Currency;

            param[2] = new SqlParameter("@Simple_Ar", SqlDbType.VarChar, 50);
            param[2].Value = Simple_Ar;

            param[3] = new SqlParameter("@Simple_En", SqlDbType.VarChar, 50);
            param[3].Value = Simple_En;

            param[4] = new SqlParameter("@Exchang_Price", SqlDbType.VarChar , 50);
            param[4].Value = Exchang_Price;

            param[5] = new SqlParameter("@Is_Main", SqlDbType.NVarChar , 5);
            param[5].Value = Is_Main;

            param[6] = new SqlParameter("@Note", SqlDbType.Text );
            param[6].Value = Note;

            CURRENCY.excutedCommand("ADD_CURRENCY", param);
            CURRENCY.close();
        }

        //Method to Updata Currency
        public void UPDATA_CURRENCY(string AR_Name_Of_Currency, string EN_Name_of_Currency, string Simple_Ar,
                                string Simple_En, string Exchang_Price, string Is_Main, string Note,string Name_Befor_Updata)
        {
            CURRENCY.open();
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@AR_Name_Of_Currency", SqlDbType.NVarChar, 50);
            param[0].Value = AR_Name_Of_Currency;

            param[1] = new SqlParameter("@EN_Name_of_Currency", SqlDbType.NVarChar, 50);
            param[1].Value = EN_Name_of_Currency;

            param[2] = new SqlParameter("@Simple_Ar", SqlDbType.VarChar, 50);
            param[2].Value = Simple_Ar;

            param[3] = new SqlParameter("@Simple_En", SqlDbType.VarChar, 50);
            param[3].Value = Simple_En;

            param[4] = new SqlParameter("@Exchang_Price", SqlDbType.VarChar, 50);
            param[4].Value = Exchang_Price;

            param[5] = new SqlParameter("@Is_Main", SqlDbType.VarChar, 5);
            param[5].Value = Is_Main;

            param[6] = new SqlParameter("@Note", SqlDbType.Text);
            param[6].Value = Note;

            param[7] = new SqlParameter("@Name_Befor_Updata", SqlDbType.NVarChar ,50);
            param[7].Value = Name_Befor_Updata;

            CURRENCY.excutedCommand("UPDATA_CURRENCY", param);
            CURRENCY.close();
        }

        //Merhod to delete currency
        public void DELETE_CURRENCY(string Name_Befor_Updata)
        {
            CURRENCY.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Name_Befor_Updata", SqlDbType.NVarChar, 50);
            param[0].Value = Name_Befor_Updata;

            CURRENCY.excutedCommand("DELETE_CURRENCY", param);
            CURRENCY.close();
        }
    }
}
