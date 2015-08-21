using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ExpMangment.BussineL
{
    class CLSlogin
    {
        public DataTable Login(string Name, string Pass)
        {
            DataAcessL.DataAcessLayer Login = new DataAcessL.DataAcessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 20);
            param[0].Value = Name;

            param[1] = new SqlParameter("@Pass", SqlDbType.NVarChar, 20);
            param[1].Value = Pass;

            DataTable DT=new DataTable ();
            DT=Login.selectData("SP_LOGIN", param);

            return DT;
        }

    }
}
