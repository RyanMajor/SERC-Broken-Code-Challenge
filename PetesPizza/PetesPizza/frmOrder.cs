using System;
using System.Windows.Forms;

namespace PetesPizza
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMainMenu menu = new frmMainMenu();
            menu.Show();
            this.Hide();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            frmInvoice invoice = new frmInvoice();
            invoice.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            GlobalVars.Exit();
        }

        #region Tuna
        private void picTuna_MouseHover(object sender, EventArgs e)
        {
            lstDetails.Items.Add("Tuna Pizza");
            lstDetails.Items.Add("____________________");
            lstDetails.Items.Add("Tomato Sauce, Sweetcorn, Onions, Tuna");
            lstDetails.Items.Add("");
            lstDetails.Items.Add("--------------------");
            lstDetails.Items.Add("Total: £6.99");
        }

        private void picTuna_MouseLeave(object sender, EventArgs e)
        {
            lstDetails.Items.Clear();
        }

        private void picTuna_Click(object sender, EventArgs e)
        {
            lstCart.Items.Add("Tuna Pizza - £6.99");
            lstDetails.Items.Clear();
            GlobalVars.dblSubTotal = GlobalVars.dblSubTotal + 6.99;
        }
        #endregion

        #region Hot & Spicy
        private void picHotSpicy_MouseHover(object sender, EventArgs e)
        {
            lstDetails.Items.Add("Hot & Spicy Pizza");
            lstDetails.Items.Add("____________________");
            lstDetails.Items.Add("Tomato Sauce, Onions, Peppers,");
            lstDetails.Items.Add("Jalapeno Peppers, Ground Beef");
            lstDetails.Items.Add("");
            lstDetails.Items.Add("--------------------");
            lstDetails.Items.Add("Total: £6.99");
        }

        private void picHotSpicy_MouseLeave(object sender, EventArgs e)
        {
            lstDetails.Items.Clear();
        }

        private void picHotSpicy_Click(object sender, EventArgs e)
        {
            lstCart.Items.Add("Hot & Spicy Pizza - £6.99");
            lstDetails.Items.Clear();
            GlobalVars.dblSubTotal = GlobalVars.dblSubTotal + 6.99;
        }
        #endregion

        #region Hawaiian
        private void picHawaiian_MouseHover(object sender, EventArgs e)
        {
            lstDetails.Items.Add("Hawaiian Pizza");
            lstDetails.Items.Add("____________________");
            lstDetails.Items.Add("Tomato Sauce, Ham, Mushrooms,");
            lstDetails.Items.Add("Pineapple");
            lstDetails.Items.Add("");
            lstDetails.Items.Add("--------------------");
            lstDetails.Items.Add("Total: £5.99");
        }

        private void picHawaiian_MouseLeave(object sender, EventArgs e)
        {
            lstDetails.Items.Clear();
        }

        private void picHawaiian_Click(object sender, EventArgs e)
        {
            lstCart.Items.Add("Hawaiian Pizza - £5.99");
            lstDetails.Items.Clear();
            GlobalVars.dblSubTotal = GlobalVars.dblSubTotal + 5.99;
        }
        #endregion

        #region Vegi
        private void picVegi_MouseHover(object sender, EventArgs e)
        {
            lstDetails.Items.Add("Vegi Pizza");
            lstDetails.Items.Add("____________________");
            lstDetails.Items.Add("Tomato Sauce, Sweetcorn, Onions,");
            lstDetails.Items.Add("Peppers, Mushrooms");
            lstDetails.Items.Add("");
            lstDetails.Items.Add("--------------------");
            lstDetails.Items.Add("Total: £5.99");
        }

        private void picVegi_MouseLeave(object sender, EventArgs e)
        {
            lstDetails.Items.Clear();
        }

        private void picVegi_Click(object sender, EventArgs e)
        {
            lstCart.Items.Add("Vegi Pizza - £5.99");
            lstDetails.Items.Clear();
            GlobalVars.dblSubTotal = GlobalVars.dblSubTotal + 2.99;
        }
        #endregion

        #region Pepperoni
        private void picPepperoni_MouseHover(object sender, EventArgs e)
        {
            lstDetails.Items.Add("Pepperoni Pizza");
            lstDetails.Items.Add("____________________");
            lstDetails.Items.Add("Tomato Sauce, Pepperoni");
            lstDetails.Items.Add("");
            lstDetails.Items.Add("--------------------");
            lstDetails.Items.Add("Total: £4.99");
        }

        private void picPepperoni_MouseLeave(object sender, EventArgs e)
        {
            lstDetails.Items.Clear();
        }

        private void picPepperoni_Click(object sender, EventArgs e)
        {
            lstCart.Items.Add("Pepperoni Pizza - £4.99");
            lstDetails.Items.Clear();
            GlobalVars.dblSubTotal = GlobalVars.dblSubTotal + 4.99;
        }
        #endregion

        #region Cheese
        private void picCheese_MouseHover(object sender, EventArgs e)
        {
            lstDetails.Items.Add("Cheese Pizza");
            lstDetails.Items.Add("____________________");
            lstDetails.Items.Add("Tomato Sauce, Mozzarella");
            lstDetails.Items.Add("");
            lstDetails.Items.Add("--------------------");
            lstDetails.Items.Add("Total: £4.99");
        }

        private void picCheese_MouseLeave(object sender, EventArgs e)
        {
            lstDetails.Items.Clear();
        }

        private void picCheese_Click(object sender, EventArgs e)
        {
            lstCart.Items.Add("Cheese Pizza - £4.99");
            lstDetails.Items.Clear();
            GlobalVars.dblSubTotal = GlobalVars.dblSubTotal + 4.99;
        }
        #endregion


        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult Clear;

            Clear = MessageBox.Show("Are you sure you wish to clear your order?", "Clear Order?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Clear == DialogResult.Yes)
            {
                GlobalVars.dblSubTotal = 0;
                lstCart.Items.Clear();
                GlobalVars.IsOrderPlaced = false;
                GlobalVars.dblDiscount = 0;
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            DialogResult Proceed;
            GlobalVars.IsOrderPlaced = true;

            if (GlobalVars.dblSubTotal >= 20.0 || chkRegular.Checked == true)
            {
                GlobalVars.dblDiscount = GlobalVars.dblSubTotal / 100 * 0.5;
                GlobalVars.dblTotal = GlobalVars.dblSubTotal - GlobalVars.dblDiscount;
            }
            else
            {
                GlobalVars.dblTotal = GlobalVars.dblSubTotal;
                GlobalVars.dblDiscount = 0;
            }

           Proceed = MessageBox.Show("Your order has been placed. \nDo you wish to proceed to your invoice?", "Order Placed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Proceed == DialogResult.Yes)
            {
                frmInvoice invoice = new frmInvoice();
                invoice.Show();
                this.Hide();
            }

        }
    }
}
