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
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
            LandExcelFile();
        }

        public void LandExcelFile()
        {
            Workbook book = new Workbook();
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\Desktop\Info\Book1.xlsx");
            Worksheet sheet = book.Worksheets[0];
            DataTable dt = sheet.ExportDataTable();
            UserData.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filterText = txtSearch.Text.Trim();

            foreach (DataGridViewRow row in UserData.Rows)
            {
                if (row.Cells["Column1"].Value != null)
                {
                    string Name = row.Cells["Column1"].Value.ToString();
                    row.Visible = Name.StartsWith(filterText, StringComparison.OrdinalIgnoreCase);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in UserData.SelectedRows)
            {
                UserData.Rows.Remove(row);
            }
        }


        private void UserData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form1 form1 = new Form1(this);

            int r = UserData.CurrentCell.RowIndex;
            form1.lblID.Text = r.ToString();
            form1.txtName.Text = UserData.Rows[r].Cells["Column1"].Value.ToString();
            form1.txtSaying.Text = UserData.Rows[r].Cells["Column5"].Value.ToString();
            form1.cmbFavoriteColor.Text = UserData.Rows[r].Cells["Column4"].Value.ToString();
            switch (UserData.Rows[r].Cells["Column2"].Value)
            {
                case "Male":
                    form1.radMale.Checked = true;
                    break;
                default:
                    form1.radFemale.Checked = true;
                    break;
            }

            string cellValue = UserData.Rows[r].Cells["Column3"].Value?.ToString();
            if (!string.IsNullOrEmpty(cellValue))
            {
                string[] words = cellValue.Split(' ');

                foreach (string word in words)
                {
                    if (word == "BasketBall")
                    {
                        form1.chkBasketball.Checked = true;
                    }
                    if (word == "VolleyBall")
                    {
                        form1.chkVolleyBall.Checked = true;
                    }
                    if (word == "Soccer")
                    {
                        form1.chkSoccer.Checked = true;
                    }
                }
            }


            this.Hide();
            form1.Show();
            form1.btnUpdate.Visible = true;
            form1.btnAdd.Visible = false;
            form1.btnDisplay.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Close();
            Login login = new Login();
            login.Show();
            this.Hide();
        }

    }
}
