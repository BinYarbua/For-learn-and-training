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
    public partial class FRMmain : Form
    {
        public FRMmain()
        {
            InitializeComponent();
        }

        private void انواعالمصاريفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersentitionL.FRMexpensed frm = new PersentitionL.FRMexpensed();
            frm.MdiParent = this;
            frm.Show();
        }

        private void العملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersentitionL.FRMcustomer frm = new PersentitionL.FRMcustomer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void العملاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersentitionL.FRMCurrency frmMoney = new PersentitionL.FRMCurrency();
            frmMoney.MdiParent = this;
            frmMoney.Show();
        }

        private void تحريرالسنداتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersentitionL.FRMpayment frmPayment = new PersentitionL.FRMpayment();
            frmPayment.MdiParent = this;
            frmPayment.Show();
        }

        private void FRMmain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
