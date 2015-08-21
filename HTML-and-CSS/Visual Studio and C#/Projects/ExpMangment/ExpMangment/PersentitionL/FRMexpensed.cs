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
    public partial class FRMexpensed : Form
    {
        //This member for store name to using in Updata SQL command
        string NameBeforUpdata="";

        BussineL.CLSExpensed exp = new BussineL.CLSExpensed();

        public FRMexpensed()
        {
            InitializeComponent();
            
        }
        //To fill dgView in Load form
        private void FRMexpensed_Load(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = exp.Get_All_Exp();
            dataGridView1.DataSource = DT;
        }

        // event To clear textboxes
        private void FRMexpensed_Shown(object sender, EventArgs e)
        {
            txtArbic_Name.Clear();
            txtEng_Name.Clear();
            txtInfo.Clear();
            txtArbic_Name.Focus();
        }

        // This event to pervnet add two same names for EXP 
        private void txtArbic_Name_Leave(object sender, EventArgs e)
        {
            //to ensoure for name its only find in database
            string ar_Name = txtArbic_Name.Text;
            DataTable DT = new DataTable();
            DT = exp.Get_The_Same_ar_Name(ar_Name);

            if (DT.Rows.Count > 0)
            {
                MessageBox.Show("12يوجد نفس الاسم لاحدى انواع المصاريف", "التكرر ممنوع", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtArbic_Name.Focus();
                txtArbic_Name.Select();
            }
        }

        //This event to pervaent add two same english names for EXP
        private void txtEng_Name_Leave(object sender, EventArgs e)
        {
            //to ensoure for name its only find in database
            string eng_Name = txtEng_Name.Text;
            DataTable DT = new DataTable();
            DT = exp.Get_The_Same_eng_Name(eng_Name);

            if (DT.Rows.Count > 0)
            {
                MessageBox.Show("يوجد نفس الاسم لاحدى انواع المصاريف123", "التكرر ممنوع", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtEng_Name.Focus();
                txtEng_Name.SelectAll();
            }
        }

        //To pervnet select first rows
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.SelectedRows[0].Selected = false;
            }
            FRMexpensed_Shown(sender, e);
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        //To dispaly data form dgview to texts
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtArbic_Name.Text = row.Cells[0].Value.ToString();
                txtEng_Name.Text = row.Cells[1].Value.ToString();
                txtInfo.Text = row.Cells[2].Value.ToString();
                NameBeforUpdata = row.Cells[0].Value.ToString();
            }
        }
        //Add EXP
        private void button5_Click(object sender, EventArgs e)
        {
            string ar_Name; string en_Name; string Info;
            DataTable DT = new DataTable();
            // هنا لابد من تحويل الصورة الى بايت ليتم تخزينها في قاعدة البيانات
            // ولعمل ذلك نستعي مجال الاسماء system.IO

            byte[] bytImage;
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pBox.Image.Save(ms, pBox.Image.RawFormat);
                    bytImage = ms.ToArray();
                }
            }
            catch (Exception) { throw; }

            ar_Name = txtArbic_Name.Text;
            en_Name = txtEng_Name.Text;
            Info = txtInfo.Text;
            DT = exp.Get_The_Same_ar_Name(ar_Name);
            if (ar_Name !="" && DT.Rows.Count == 0)
            {
                exp.ADD_EXP(ar_Name, en_Name, Info, bytImage);
                NameBeforUpdata = null;
                FRMexpensed_Load(sender, e);
                txtEng_Name.Focus();
            }
            else
            {
                MessageBox.Show("يوجد صنف بفس الاسم ", "ممنوع التكرار ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            FRMexpensed_Shown( sender, e);
        }
        // to open file dialog
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImage = new OpenFileDialog();
            openImage.Filter = "ملفات الصور|*.PNG; *.GIF; *.JPG";
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                pBox.Image = Image.FromFile(openImage.FileName);
            }
        }

        //Updata data for exp
        private void btnUpdata_Click(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            //Convert the image to byte
            byte[] bytImage;
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pBox.Image.Save(ms, pBox.Image.RawFormat);
                    bytImage = ms.ToArray();
                }
            }
            catch (Exception) { throw; }

            DT =exp.Get_The_Same_ar_Name (txtArbic_Name .Text );
            if(txtArbic_Name .Text !="" && DT.Rows .Count <=1)
            exp.UPDATA_EXP(txtArbic_Name.Text, txtEng_Name.Text, txtInfo.Text, bytImage, NameBeforUpdata);
            NameBeforUpdata = null;
            FRMexpensed_Shown(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtArbic_Name.Text !="" && NameBeforUpdata !="")
            {
                if ((MessageBox.Show("هل تريد الحدف فعلاً", "تاكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    exp.DELETE_EXP(NameBeforUpdata);
                    NameBeforUpdata = null;
                    FRMexpensed_Load( sender, e);
                    FRMexpensed_Shown(sender, e);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRMexpensed_Shown(sender, e);
        }

        private void btnCenconl_Click(object sender, EventArgs e)
        {
            this.Close();
        }



      /* private void txtArbic_Name_Leave(object sender, EventArgs e)
        {
           //to ensoure for name its only find in database
            string ar_Name = txtArbic_Name.Text;
            DataTable DT=new DataTable ();
            DT=exp.Get_The_Same_Name (ar_Name );

            if(DT .Rows .Count >0)
            {
                MessageBox.Show("يوجد نفس الاسم لاحدى انواع المصاريف", "التكرر ممنوع", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtArbic_Name.Focus();
                txtArbic_Name.Select();
            }
        }*/

    }
}
