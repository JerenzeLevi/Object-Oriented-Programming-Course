using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritanceActivity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();

            teacher.Email = txtEmail.Text;
            teacher.Password = txtPassword.Text;
            teacher.Subject = "Object Oriented Programming";

            MessageBox.Show(
                "Role: " + teacher.GetRole() +
                "\nEmail: " + teacher.Email +
                "\nSubject: " + teacher.Subject
            );
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            admin.Email = txtEmail.Text;
            admin.Password = txtPassword.Text;

            MessageBox.Show(
                "Role: " + admin.GetRole() +
                "\nEmail: " + admin.Email
            );
        }
    }
}
