using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data .SqlClient ;
using System.Data ;

namespace ExpMangment.BussineL
{
    class CLSPayment
    {
        DataAcessL.DataAcessLayer PAYMENT = new DataAcessL.DataAcessLayer();
            
        //Get all Currency with Id and namr
        public DataTable GET_ALL_CURRENCY_With_Id_Name()
        {
            DataTable DT = new DataTable();
            DT = PAYMENT.selectData ("GET_ALL_CURRENCY_With_Id_Name", null);
            return DT;
        }

        //Get all Customer with Id and Name
        public DataTable GET_ALL_CUSTOMER_with_Id_Name()
        {
            DataTable DT = new DataTable();
            DT = PAYMENT.selectData("GET_ALL_CUSTOMER_with_Id_Name", null);
            return DT;
        }

        //Get all Type Of EXP
        public DataTable GET_ALL_TYPE_OF_EXP_withId_Name()
        {
            DataTable DT = new DataTable();
            DT = PAYMENT.selectData("GET_ALL_TYPE_OF_EXP_withId_Name", null);
            return DT;
        }

        //Get max number of payment
        public DataTable  Get_Max_NumberOfPayment()
        {
            DataTable DT=new DataTable ();
            DT = PAYMENT.selectData("Get_Max_NumberOfPayment", null);
            return DT;
        }

        //Get Exchange price for selecet currency
        public DataTable GET_PRICE_OF_CURRENCY(int Id_OF_Currency, string NameOfCurrency)
        {
            DataTable DT = new DataTable();

            SqlParameter[] param = new SqlParameter[2];
            param[0].ParameterName = "@NameOfCurrency";
            param[0].SqlDbType = SqlDbType.NVarChar;
            param[0].Size = 30;
            param[0].Direction = ParameterDirection.Input;
            param[0].Value = NameOfCurrency;

            param[1].ParameterName = "@Id_OF_Currency";
            param[1].SqlDbType = SqlDbType.Int ;
            param[1].Direction = ParameterDirection.Input;
            param[1].Value = Id_OF_Currency;

            DT = PAYMENT.selectData("GET_PRICE_OF_CURRENCY", param);
            return DT;
        }

        //Method the to add payment 
        public void ADD_PAYMENT(int Num_OF_Pay, DateTime Date_Of_Pay, string Money, int Id_type_of_Currency, string Money_IN_Main,
                            int Id_customer, int Id_Exp, string Payment_Method, string Info, int Id_user)
        {

        }
    }
}
