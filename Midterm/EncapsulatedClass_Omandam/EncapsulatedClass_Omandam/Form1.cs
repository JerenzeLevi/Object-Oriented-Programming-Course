using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncapsulatedClass_Omandam
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
                String Fullname = txtfullname.Text;
                String Nationality = txtnationality.Text;
                String CivilStatus = txtcivilstatus.Text;
                String BirthDate = txtbirthdate.Text;
                Userclass user = new Userclass(Fullname, int.Parse(txtage.Text), Nationality, CivilStatus, BirthDate);

                MessageBox.Show("Full Name: " + user.fullname + "\nAge: " + user.age.ToString() + "\nNationality: " + user.natonality + "\nCivil Status: " + user.civilStatus + "\nBirth Date: " + user.birthDate);



            }
            catch (Exception)
            {
                MessageBox.Show("PLEASE INPUT A PROPER CREDENTIAL ON THE GIVEN BOXES.\nTHANK YOU!");
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            txtfullname.Text = "";
            txtage.Text = "";
            txtnationality.Text = "";
            txtcivilstatus.Text = "";
            txtbirthdate.Text = "";
        }
    }
}
