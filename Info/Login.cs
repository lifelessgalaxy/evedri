using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Info
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\Info\Book1.xlsx");
            Worksheet sheet = book.Worksheets[0];
            int row = sheet.Rows.Length;
            bool log = false;
            for (int i = 2; i <= row; i++)
            {
                if (sheet.Range[i, 5].Value == txtUsername.Text && sheet.Range[i, 6].Value == txtPassword.Text)
                {
                    log = true; 
                    break;

                }
                else
                {
                    log = false;
                }
            }
            if (log == true)
            {
                MessageBox.Show("Success");

            }
            else
            {
                MessageBox.Show("PAss and User is incorrect");
            }
        }
    }
}
