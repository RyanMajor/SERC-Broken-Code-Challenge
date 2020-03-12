using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetesPizza
{
    public partial class frmInvoice : Form
    {
        public frmInvoice()
        {
            InitializeComponent();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            GlobalVars.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            GlobalVars.dblDiscount = 0;
            GlobalVars.dblSubTotal = 0;
            GlobalVars.dblTotal = 0;
            GlobalVars.IsOrderPlaced = false;

            frmMainMenu menu = new frmMainMenu();
            menu.Show();
            this.Hide();
        }

       

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            lstInvoice.Items.Add("Total:      " + "£" + GlobalVars.dblSubTotal.ToString("00.00"));
            lstInvoice.Items.Add("Discount:   " + GlobalVars.dblDiscount.ToString("00.00") + "%");
            lstInvoice.Items.Add("Subtotal:   " + "£" + GlobalVars.dblTotal.ToString("00.00"));
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }

        private void lstInvoice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region Printing
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintInvoice();
        }

        private void PrintInvoice()
        {
            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDocument1 = new PrintDocument();

            printDialog.Document = printDocument1; //add the document to the dialog box...        

            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing

            //on a till you will not want to ask the user where to print but this is fine for the test envoironment.

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument1.Print();

            }
        }

        public void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //this prints the reciept

            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 12); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("Pete's Pizza", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            string top = "Item Name".PadRight(30) + "Price";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent


            foreach (string item in lstInvoice.Items)
            {
                //create the string to print on the reciept
                string productDescription = item;

                if (productDescription.Contains("  -"))
                {
                    string productLine = productDescription.Substring(0, 24);

                    graphic.DrawString(productLine, new Font("Courier New", 12, FontStyle.Italic), new SolidBrush(Color.Red), startX, startY + offset);

                    offset = offset + (int)fontHeight + 5; //make the spacing consistent
                }
                else
                {
                    string productLine = productDescription;

                    graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);

                    offset = offset + (int)fontHeight + 5; //make the spacing consistent
                }

            }

            //when we have drawn all of the items add the total

            offset = offset + 20; //make some room so that the total stands out.

            graphic.DrawString("Order Total: ".PadRight(30) + String.Format("{0:c}", GlobalVars.dblSubTotal), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + 30; //make some room so that the total stands out.
            graphic.DrawString("Discount:    ".PadRight(30) + String.Format("{0:c}", GlobalVars.dblDiscount), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            offset = offset + 30; //make some room so that the total stands out.
            graphic.DrawString("To Pay:      ".PadRight(30) + String.Format("{0:c}", GlobalVars.dblTotal), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 30; //make some room so that the total stands out.
            graphic.DrawString("     Thank-you for your custom,", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            graphic.DrawString("       please come back soon!", font, new SolidBrush(Color.Black), startX, startY + offset);

        }
        #endregion
    }
}
