using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncapsulatedClass_Giamat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                String Name = txtName.Text;
                String Gmail = txtGmail.Text;
                String Address = txtAddress.Text;
                String Contact = txtContact.Text;
                UserClass user = new UserClass(Name, int.Parse(txtAge.Text), Gmail, Address, Contact);

                MessageBox.Show("Name: " + user.name + "\nAge: " + user.age.ToString() + "\nEmail: " + user.gmail + "\nAddress: " + user.address + "\nContact Number: " + user.contact);



            }
            catch (Exception)
            {
                MessageBox.Show("PLEASE INPUT A PROPER CREDENTIAL ON THE GIVEN BOXES.\nTHANK YOU!");
            }
        }
    }
}
