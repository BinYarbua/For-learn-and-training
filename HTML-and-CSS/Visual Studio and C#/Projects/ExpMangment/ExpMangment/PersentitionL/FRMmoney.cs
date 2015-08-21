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
    public partial class FRMCurrency : Form
    {
        string NameBeforUpdata = "";
        BussineL.CLSCurrency CURRENCY = new BussineL.CLSCurrency();

        public FRMCurrency()
        {
            InitializeComponent();
        }
        private void Clear_All_Controls()
        {
            txtExchangPrice.Clear ();
            txtNameOfCurrency.Clear();
            txtNameOfCurrencyEN.Clear();
            txtNote.Clear();
            txtSimlpeEN.Clear();
            txtSimpleAR.Clear();
            cmbIsMainCurrency.Text ="";
        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.SelectedRows[0].Selected = false;
            }
            Clear_All_Controls();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtNameOfCurrency.Text = row.Cells[0].Value.ToString();
                txtSimpleAR.Text = row.Cells[1].Value.ToString();
                txtNameOfCurrencyEN.Text = row.Cells[2].Value.ToString();
                txtSimlpeEN.Text = row.Cells[3].Value.ToString();
                txtExchangPrice.Text = row.Cells[4].Value.ToString();
                //cmbIsMainCurrency.SelectedItem = cmbIsMainCurrency.Items.Equals(row.Cells[5].Value.ToString());
                txtNote.Text = row.Cells[6].Value.ToString();
                NameBeforUpdata = row.Cells[0].Value.ToString();
                if (cmbIsMainCurrency.Items[0].ToString() == row.Cells[5].Value.ToString())
                {
                    cmbIsMainCurrency.Text = cmbIsMainCurrency.Items[0].ToString();

                }
                else
                {
                    if (cmbIsMainCurrency.Items[1].ToString() == row.Cells[5].Value.ToString())
                    {
                        cmbIsMainCurrency.Text = cmbIsMainCurrency.Items[1].ToString();
                    }
                }
            }
        }
        private void FRMCurrency_Load(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = CURRENCY.GET_ALL_CURRENCY();
            dataGridView1.DataSource = DT;
            txtNameOfCurrency.Focus();
        }
        private void cmbIsMainCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIsMainCurrency.Text == "Yes")
            {
                txtExchangPrice.Text = "1";
                txtExchangPrice.ReadOnly = true; ;
            }
            else
            {
                txtExchangPrice.Text = "";
                txtExchangPrice.ReadOnly = false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // اولا يجب التاكد من انا جميع االبيانات موجودة ولايوجد خانه فاضية
            if (txtNameOfCurrency.Text != "" && txtSimpleAR.Text != "" && txtNameOfCurrencyEN.Text != "" && txtSimlpeEN.Text != ""
                                                                    && cmbIsMainCurrency.Text != "" && txtExchangPrice.Text != "")
            {
                //للتاكد من انه لاتوجد عمله لها نفس الاسم للعملة المراد تخزينها
                DataTable DT = new DataTable();
                DT = CURRENCY.GET_CURRENCY_BYNAME(txtNameOfCurrency.Text);
                if (DT.Rows.Count != 1)
                {
                    //تم التاكد من انه لايوجد اسم نبفس اسم العملة المراد تخزينها
                    //هل العمله المراد تخزينها عمله اساسية
                    if (cmbIsMainCurrency.Text =="Yes")
                    {
                        DT.Clear();
                        DT = CURRENCY.GET_MAIN_CURRENCY();
                        if (DT.Rows.Count == 1)
                        {
                            if((MessageBox.Show("توجد عمله اساسية في قائمة العملات!هل تريد حفظ هذه العملة كملة غير اساسية", "عملة واحدة رئيسية فقط", MessageBoxButtons.YesNo , MessageBoxIcon.Question))==DialogResult .Yes) 
                            {
                                CURRENCY.ADD_CURRENCY(txtNameOfCurrency.Text, txtNameOfCurrencyEN.Text, txtSimpleAR.Text, txtSimlpeEN.Text,
                                                        txtExchangPrice.Text, cmbIsMainCurrency.Items[0].ToString (), txtNote.Text);
                                Clear_All_Controls();
                                FRMCurrency_Load(sender, e);
                                txtNameOfCurrency.Focus();
                            }
                        }
                        else 
                        {
                                CURRENCY.ADD_CURRENCY(txtNameOfCurrency.Text, txtNameOfCurrencyEN.Text, txtSimpleAR.Text, txtSimlpeEN.Text,
                                                        "1", cmbIsMainCurrency.Items[1].ToString (), txtNote.Text);
                                Clear_All_Controls();    
                            FRMCurrency_Load(sender, e);
                                txtNameOfCurrency.Focus();
                        }
                    }
                    else 
                    {
                        CURRENCY.ADD_CURRENCY(txtNameOfCurrency.Text, txtNameOfCurrencyEN.Text, txtSimpleAR.Text, txtSimlpeEN.Text,
                                                        txtExchangPrice.Text, cmbIsMainCurrency.Items[0].ToString (), txtNote.Text);
                        Clear_All_Controls();
                        FRMCurrency_Load(sender, e);
                        txtNameOfCurrency.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("توجد عملة بنفس الاسم", "تكرار اسم العملة", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtNameOfCurrency.Focus();
                    txtNameOfCurrency.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("الرجاء التاكد من جميع الادخالات", "البيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.None);
                txtNameOfCurrency.Focus();
                txtNameOfCurrency.SelectAll();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }


        private void btnUpdata_Click(object sender, EventArgs e)
        {
            // اولا يجب التاكد من انا جميع االبيانات موجودة ولايوجد خانه فاضية
            if (txtNameOfCurrency.Text != "" && txtSimpleAR.Text != "" && txtNameOfCurrencyEN.Text != "" && txtSimlpeEN.Text != ""
                                                                    && cmbIsMainCurrency.Text != "" && txtExchangPrice.Text != "")
            {
                //لفحص هل العملة المراد تعديل بياناتها هي عملة اساسية
                DataTable DT = new DataTable();
                DT=CURRENCY.GET_MAIN_CURRENCY();
                if (DT.Rows[0][0].ToString() == NameBeforUpdata)
                {
                    MessageBox.Show("لايمكن تعديل بيانات العملة الاساسية", "عملة اساسية", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    //للتاكد من الاسم الجديد للعملة ليس موجود في قائمة العملات
                    //
                    DT.Clear();
                    DT = CURRENCY.GET_CURRENCY_BYNAME(txtNameOfCurrency.Text);
                    if ((DT.Rows.Count > 0)&&(DT.Rows[0][0].ToString() != NameBeforUpdata))
                    {
                        MessageBox.Show("توجد عملة بنفس الاسم", "تكرار اسم العملة", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtNameOfCurrency.Focus();
                        txtNameOfCurrency.SelectAll();
                    }
                    else
                    {
                        //اذا كان العملة المراد تعديل بياناتها وحفظها كعملة اساسية
                        if (cmbIsMainCurrency.Text == "Yes")
                        {
                            //لفحص هل يوجد عملة اساسية في القائمة 
                            DT.Clear();
                            DT = CURRENCY.GET_MAIN_CURRENCY();
                            if (DT.Rows.Count == 0)
                            {
                                //اذا لايوجد عملة اساسية في القائمة هنا يمكن التعديل والحفظ كعملة اساسية
                                CURRENCY.UPDATA_CURRENCY(txtNameOfCurrency.Text, txtNameOfCurrencyEN.Text, txtSimpleAR.Text, txtSimlpeEN.Text,
                                                        txtExchangPrice.Text, "Yes", txtNote.Text, NameBeforUpdata);
                                Clear_All_Controls();
                                NameBeforUpdata = "";
                                FRMCurrency_Load(sender, e);
                                txtNameOfCurrency.Focus();
                                btnAdd.Focus();

                            }
                            else
                            {
                                MessageBox.Show("لايمكن اضافة عملة اساسية ثانية الى البرنامج", "العملة الاساسية موجودة", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                        else
                        {
                            CURRENCY.UPDATA_CURRENCY(txtNameOfCurrency.Text, txtNameOfCurrencyEN.Text, txtSimpleAR.Text, txtSimlpeEN.Text,
                                                        txtExchangPrice.Text, "No", txtNote.Text, NameBeforUpdata);
                            MessageBox.Show("تم التعديل بنجاح");
                            Clear_All_Controls();
                            NameBeforUpdata = "";
                            FRMCurrency_Load(sender, e);
                            txtNameOfCurrency.Focus();
                            btnAdd.Focus();
                        }
                    }
                }
            }

            else
            {
                MessageBox.Show("الرجاء التاكد من جميع الادخالات", "البيانات ناقصة", MessageBoxButtons.OK, MessageBoxIcon.None);
                txtNameOfCurrency.Focus();
                txtNameOfCurrency.SelectAll();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear_All_Controls();
            NameBeforUpdata = "";
            btnAdd.Focus();
        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        



      
    }
}