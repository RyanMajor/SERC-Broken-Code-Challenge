using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetesPizza
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            GlobalVars.Exit();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            if (GlobalVars.IsOrderPlaced == false)
            {
                MessageBox.Show("Please place an order.", "Place Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmInvoice invoice = new frmInvoice();
                invoice.Show();
                this.Hide();
            }

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmOrder order = new frmOrder();
            order.Show();
            this.Hide();
        }
    }
}
