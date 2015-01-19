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
    public partial class FRMpayment : Form
    {
        BussineL.CLSPayment Payment = new BussineL.CLSPayment();

        DataTable DT = new DataTable();
        public FRMpayment()
        {
            InitializeComponent();
      
            cmbCurrency.DataSource = Payment.GET_ALL_CURRENCY_With_Id_Name();
            cmbCurrency.DisplayMember = "Currency_ar_name";
            cmbCurrency.ValueMember = "Id_type_money";
            
            cmbCustomer.DataSource = Payment.GET_ALL_CUSTOMER_with_Id_Name();
            cmbCustomer.SelectedIndex = -1;
            cmbCustomer.DisplayMember = "Cust_name";
            cmbCustomer.ValueMember = "Id_customer";
            cmbTypeOfExp.DataSource = Payment.GET_ALL_TYPE_OF_EXP_withId_Name();
            cmbTypeOfExp.DisplayMember = "Exp_arbicName";
            cmbTypeOfExp.ValueMember = "Id_Exp";

        }

        private void FRMpayment_Load(object sender, EventArgs e)
        {

        }

        private void FRMpayment_Activated(object sender, EventArgs e)
        {
            cmbCustomer.SelectedIndex = -1;
            cmbTypeOfExp.SelectedIndex = -1;
            DT = Payment.Get_Max_NumberOfPayment();
            if (DT.Rows.Count > 0)
            {
                txtNemberOfPayment.Text = DT.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show("There is not data retirve from guery");
            }

        }
        
    }
}
