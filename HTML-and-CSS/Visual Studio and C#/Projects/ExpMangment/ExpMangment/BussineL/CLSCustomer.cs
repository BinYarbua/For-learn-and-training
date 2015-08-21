using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ExpMangment.BussineL
{
    class CLSCustomer
    {
        DataAcessL.DataAcessLayer CUST = new DataAcessL.DataAcessLayer();

        //Method to get all customers
        public DataTable GET_ALL_CUST()
        {
            DataTable DT=new DataTable ();
            DT = CUST.selectData("GET_ALL_CUST", null);
            return DT;
        }

        //Method to check if the Name of customer is existing
        public DataTable GET_CUST_BYNAME(string name_FOR_Checking)
        {
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@check_Name", SqlDbType.NVarChar, 50);
            param[0].Value = name_FOR_Checking;

            DT = CUST.selectData("GET_CUST_BYNAME", param);
            return DT;
        }

        //Method to add customer
        public void ADD_CUSTOMER(string cust_Name, string cust_Phone, string cust_Mobile, string cust_Email,
                                  string cust_Address, string cust_Country, byte[] cust_Image)
        {
            CUST.open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@Name_Of_Cust", SqlDbType.NVarChar, 50);
            param[0].Value = cust_Name;

            param[1] = new SqlParameter("@Phone_Of_Cust", SqlDbType.NVarChar, 50);
            param[1].Value =cust_Phone ;

            param[2] = new SqlParameter("@Mobile_Of_Cust", SqlDbType.NVarChar, 25);
            param[2].Value = cust_Mobile ;

            param[3] = new SqlParameter("@Email_Of_Cust", SqlDbType.NVarChar, 30);
            param[3].Value = cust_Email ;

            param[4] = new SqlParameter("@Address_Of_Cust", SqlDbType.NVarChar, 50);
            param[4].Value = cust_Address ;

            param[5] = new SqlParameter("@Country_Of_Cust", SqlDbType.NVarChar, 30);
            param[5].Value = cust_Country;

            param[6] = new SqlParameter("@Image_Of_Cust", SqlDbType.Image);
            param[6].Value = cust_Image;

            CUST.excutedCommand("ADD_CUSTOMER", param);
            CUST.close();
        }

        //Method to UPDATA CUSTOMER 
        public void UPDATE_CUSTOMER(string cust_Name, string cust_Phone, string cust_Mobile, string cust_Email,
                                  string cust_Address, string cust_Country, byte[] cust_Image, string name_BEFORE_UPDATE)
        {
            CUST.open();
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@Name_Of_Cust", SqlDbType.NVarChar, 50);
            param[0].Value = cust_Name;

            param[1] = new SqlParameter("@Phone_Of_Cust", SqlDbType.NVarChar, 50);
            param[1].Value = cust_Phone;

            param[2] = new SqlParameter("@Mobile_Of_Cust", SqlDbType.NVarChar, 25);
            param[2].Value = cust_Mobile;

            param[3] = new SqlParameter("@Email_Of_Cust", SqlDbType.NVarChar, 30);
            param[3].Value = cust_Email;

            param[4] = new SqlParameter("@Address_Of_Cust", SqlDbType.NVarChar, 50);
            param[4].Value = cust_Address;

            param[5] = new SqlParameter("@Country_Of_Cust", SqlDbType.NVarChar, 30);
            param[5].Value = cust_Country;

            param[6] = new SqlParameter("@Image_Of_Cust", SqlDbType.Image);
            param[6].Value = cust_Image;

            param[7] = new SqlParameter("@Name_Befor_Updata", SqlDbType.NVarChar ,50);
            param[7].Value = name_BEFORE_UPDATE;

            CUST.excutedCommand("UPDATE_CUSTOMER", param);
            CUST.close();
        }

        //Method To Delete Customer
        public void DELETE_CUSTOMER(string Name_Of_Customer)
        {
            CUST.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Name_Of_Cust", SqlDbType.NVarChar, 50);
            param[0].Value = Name_Of_Customer;

            CUST.excutedCommand("DELETE_CUSTOMER", param);
            CUST.close();
        }
    }
}
