using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExpMangment.PersentitionL
{
    public partial class FRMLogin : Form
    {
        BussineL.CLSlogin Log = new BussineL.CLSlogin(); 
        public FRMLogin()
        {
            InitializeComponent();
        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = Log.Login(txtName.Text, txtPassword.Text);
            if (DT.Rows.Count > 0)
            {
                PersentitionL.FRMmain frmMain = new PersentitionL.FRMmain();
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The Log fialed! Check The UserName AND PassWord","Error Information",MessageBoxButtons.OK);
            }
        }
    }
}
