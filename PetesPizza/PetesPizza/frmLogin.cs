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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            GlobalVars.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            GlobalVars.strEnteredUsername = txtUsername.Text.ToUpper();
            GlobalVars.strEnteredPassword = txtPassword.Text.ToUpper();

            if ((GlobalVars.strEnteredUsername == GlobalVars.strUsername) || (GlobalVars.strEnteredPassword == GlobalVars.strPassword))
            {
                frmMainMenu mainMenu = new frmMainMenu();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
