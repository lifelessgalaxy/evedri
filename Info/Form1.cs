using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Info
{
    public partial class Form1 : Form
    {

        private Display Data;

        public Form1(Display form)
        {
            InitializeComponent();
            Data = form;
        }
        string Gender = "";
        string Hobby = "";
        public void Storage(string name, string gender, string hobbies, string favcolor, string saying)
        {
            try
            {
                name = txtName.Text;
                favcolor = cmbFavoriteColor.Text;
                saying = txtSaying.Text;

                
                
                if (radFemale.Checked)
                {
                    Gender = radFemale.Text;
                }
                else if (radMale.Checked)
                {
                    Gender = radMale.Text;
                }

                if (chkBasketball.Checked)
                {
                    Hobby += chkBasketball.Text + " ";
                }
                if (chkVolleyBall.Checked)
                {
                    Hobby += chkVolleyBall.Text + " ";
                }
                if (chkSoccer.Checked)
                {
                    Hobby += chkSoccer.Text + " ";
                }

                name = txtName.Text;
                favcolor = cmbFavoriteColor.Text;
                saying = txtSaying.Text;

                int index = Data.UserData.Rows.Add();
                Data.UserData.Rows[index].Cells[0].Value = name;
                Data.UserData.Rows[index].Cells[1].Value = Gender;
                Data.UserData.Rows[index].Cells[2].Value = Hobby;
                Data.UserData.Rows[index].Cells[3].Value = favcolor;
                Data.UserData.Rows[index].Cells[4].Value = saying;



                txtName.Text = string.Empty;
                txtSaying.Text = string.Empty;
                radFemale.Checked = false;
                radMale.Checked = false;
                chkBasketball.Checked = false;
                chkSoccer.Checked = false;
                chkVolleyBall.Checked = false;
                cmbFavoriteColor.Text = string.Empty;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            
        }

        public void InputEditedData(int ID, string name, string gender, string hobbies, string favcolor, string saying)
        {
            ID = Convert.ToInt32(lblID.Text);

            try
            {
                name = txtName.Text;
                favcolor = cmbFavoriteColor.Text;
                saying = txtSaying.Text;



                if (radFemale.Checked)
                {
                    Gender = radFemale.Text;
                }
                else if (radMale.Checked)
                {
                    Gender = radMale.Text;
                }

                if (chkBasketball.Checked)
                {
                    Hobby += chkBasketball.Text + " ";
                }
                if (chkVolleyBall.Checked)
                {
                    Hobby += chkVolleyBall.Text + " ";
                }
                if (chkSoccer.Checked)
                {
                    Hobby += chkSoccer.Text + " ";
                }

                name = txtName.Text;
                favcolor = cmbFavoriteColor.Text;
                saying = txtSaying.Text;

                Data.UserData.Rows[ID].Cells[0].Value = name;
                Data.UserData.Rows[ID].Cells[1].Value = Gender;
                Data.UserData.Rows[ID].Cells[2].Value = Hobby;
                Data.UserData.Rows[ID].Cells[3].Value = favcolor;
                Data.UserData.Rows[ID].Cells[4].Value = saying;



                txtName.Text = string.Empty;
                txtSaying.Text = string.Empty;
                radFemale.Checked = false;
                radMale.Checked = false;
                chkBasketball.Checked = false;
                chkSoccer.Checked = false;
                chkVolleyBall.Checked = false;
                cmbFavoriteColor.Text = string.Empty;

                this.Hide();
                Data.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)      
        {

            Storage(txtName.Text, Gender, Hobby, cmbFavoriteColor.Text, txtSaying.Text);

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Data.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(lblID.Text);
            InputEditedData(ID, txtName.Text, Gender, Hobby, cmbFavoriteColor.Text, txtSaying.Text);
            btnDisplay.Visible = true;
            btnAdd.Visible = true;
        }

       
    }
    
}
