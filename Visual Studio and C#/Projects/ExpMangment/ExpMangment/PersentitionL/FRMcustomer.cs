using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ExpMangment.PersentitionL
{
    public partial class FRMcustomer : Form
    {
        //This member to use in updata and delete by name of customer befor updata
        string name_BEFORE_UPDATE="";

        BussineL.CLSCustomer CUSTOMER = new BussineL.CLSCustomer();

        public FRMcustomer()
        {
            InitializeComponent();
        }

        private void Clear_All_textboxes()
        {
            txtCustAddress1.Clear();
            txtCustAddress2.Clear();
            txtCustEmail.Clear();
            txtCustPhone.Clear();
            txtCustName.Clear();
            txtCustMobile.Clear();
            cmbCustCountry.Text = "";
        }

        //Method to convert Image to byte 
        private byte[] CONVERT_TO_BYTE()
        {
            //TO CONVRET IMAGE TO BYTE
            byte[] byteImage;
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pBoxImage.Image.Save(ms, pBoxImage.Image.RawFormat);
                    byteImage = ms.ToArray();
                }
            }
            catch (Exception) { throw; }
            return byteImage;
        }
        private void FRMcustomer_Load(object sender, EventArgs e)
        {
            // Resize the height of the column headers. 
            dataGridView1.AutoResizeColumnHeadersHeight();

            //FILL dategridView by all Customer
            DataTable DT = new DataTable();
            DT=CUSTOMER.GET_ALL_CUST();
            dataGridView1.DataSource = DT;
            Clear_All_textboxes();
            txtCustName.Focus();
            btnAdd.Focus();
        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.SelectedRows[0].Selected = false;
            }
            Clear_All_textboxes();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtCustName.Text = row.Cells[0].Value.ToString();
                txtCustMobile.Text = row.Cells[1].Value.ToString();
                txtCustPhone.Text = row.Cells[2].Value.ToString();
                txtCustEmail.Text = row.Cells[3].Value.ToString();
                txtCustAddress1.Text = row.Cells[4].Value.ToString();
                cmbCustCountry.Text = row.Cells[5].Value.ToString();
                name_BEFORE_UPDATE = row.Cells[0].Value.ToString();
            }
        }
        private void btnListImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImage = new OpenFileDialog();
            openImage.Filter = "ملفات الصور (*.PNG,*.JPG)|*.PNG; *.GIF; *.JPG";
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                pBoxImage.Image = Image.FromFile(openImage.FileName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            byte[] byteImage = CONVERT_TO_BYTE();
            if (txtCustName.Text != "")
            {
                DataTable DT = new DataTable();
                DT = CUSTOMER.GET_CUST_BYNAME(txtCustName.Text);
                if (DT.Rows.Count == 0)
                {
                    CUSTOMER.ADD_CUSTOMER(txtCustName.Text, txtCustMobile.Text, txtCustPhone.Text,
                                            txtCustEmail.Text, txtCustAddress1.Text,cmbCustCountry.Text , byteImage);
                    FRMcustomer_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("يوجد عميل بنفس الاسم الرجاء تغير الاسم....", "الاسم مكرر", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCustName.Focus();
                    txtCustName.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("...الاسم غير موجود", "الرجاء ادخل الاسم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustName.Focus();
                txtCustName.SelectAll();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            byte[] byteImage = CONVERT_TO_BYTE();
            if (txtCustName.Text !="")
            {
                DataTable DT = new DataTable();
                DT = CUSTOMER.GET_CUST_BYNAME(txtCustName.Text);
                if (DT.Rows.Count == 0)
                {
                    CUSTOMER.UPDATE_CUSTOMER(txtCustName.Text, txtCustPhone.Text, txtCustMobile.Text,
                                           txtCustEmail.Text, txtCustAddress1.Text, cmbCustCountry.Text, byteImage, name_BEFORE_UPDATE);
                    Clear_All_textboxes();
                    FRMcustomer_Load( sender, e);
                    txtCustName.Focus();
                    name_BEFORE_UPDATE = "";
                }
                if (DT.Rows.Count == 1)
                {
                    CUSTOMER.UPDATE_CUSTOMER(txtCustName.Text, txtCustPhone.Text, txtCustMobile.Text,
                                          txtCustEmail.Text, txtCustAddress1.Text, cmbCustCountry.Text, byteImage, name_BEFORE_UPDATE);
                    Clear_All_textboxes();
                    FRMcustomer_Load(sender, e);
                    txtCustName.Focus();
                    name_BEFORE_UPDATE = "";
                }
                if (DT.Rows.Count > 1)
                {
                    MessageBox.Show("يوجد عميل بنفس الاسم...", "الاسم مكرر", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("الاسم غير موجود ...", "الرجاء ادخل الاسم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustName.Focus();
                txtCustName.SelectAll();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCustName.Text  != "" && name_BEFORE_UPDATE  != "")
            {
                if ((MessageBox.Show("هل تريد الحدف فعلاً", "تاكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    CUSTOMER.DELETE_CUSTOMER(name_BEFORE_UPDATE);
                    FRMcustomer_Load(sender, e);
                    Clear_All_textboxes();
                    txtCustName.Focus();

                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        { 
            Clear_All_textboxes();
            FRMcustomer_Load(sender, e);
            txtCustName.Focus();
        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
