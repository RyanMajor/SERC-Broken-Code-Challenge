using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetesPizza
{
    class GlobalVars
    {
        public static string strUsername = "Pete";
        public static string strPassword = "Pizza";
        public static string strEnteredUsername;
        public static  string strEnteredPassword;

        public static double dblSubTotal;
        public static double dblDiscount;
        public static double dblTotal;

        public static bool IsOrderPlaced = false;

        public static void Exit()
        {
            DialogResult Exit;
            const string strMessage = "Are you sure you wish to exit?";
            const string strTitle = "Exiting";

            Exit = MessageBox.Show(strMessage, strTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Exit == DialogResult.No)
            {
                Application.Exit();
            }
        }
    }
}
