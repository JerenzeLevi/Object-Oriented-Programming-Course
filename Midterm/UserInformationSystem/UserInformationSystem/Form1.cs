using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInformationSystem
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String FirstName = txtFirstName.Text;
                String MiddleName = txtMiddlename.Text;
                String LastName = txtLastName.Text;
                String Address = txtAddress.Text;
                String Username = txtUsername.Text;
                String Password = txtPassword.Text;
                UserClass user = new UserClass(int.Parse(txtID.Text), FirstName, MiddleName, LastName, int.Parse(txtAge.Text), Address, Username, Password);

                MessageBox.Show("User ID: " + user.userId.ToString() + "\nFirst Name: " + user.firstName + "\nMiddle Name: " + user.middleName + "\nLast Name:" + user.lastName + "\n" +
                    user.age + "\n" + user.address + "\n" + user.username + "\n" + user.password);
                
                
                
            } catch(Exception)
            {
                MessageBox.Show("PLEASE INPUT A PROPER CREDENTIAL ON THE GIVEN BOXES.\nTHANK YOU!");
            }
            
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtFirstName.Text = "";
            txtMiddlename.Text = "";
            txtLastName.Text = "";
            txtAge.Text = "";
            txtAddress.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                String FirstName = txtFirstName.Text;
                String MiddleName = txtMiddlename.Text;
                String LastName = txtLastName.Text;
                String Address = txtAddress.Text;
                String Username = txtUsername.Text;
                String Password = txtPassword.Text;
                UserClass user = new UserClass(int.Parse(txtID.Text), FirstName, MiddleName, LastName, int.Parse(txtAge.Text), Address, Username, Password);
                await FirebaseHelper.SaveDataAsync("User/" + user.userId, user);
                MessageBox.Show("Data Save Successfully");
            }
            catch
            {
                MessageBox.Show("Please fill all field or enter correct data. Thank you!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
