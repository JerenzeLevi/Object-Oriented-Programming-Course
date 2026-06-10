using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omandam_Midterm_SetA
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
                String Title = txtTitle.Text;
                String Author = txtAuthor.Text;
                String Publisher = txtPublisher.Text;
                BookApp Book = new BookApp(Title, Author, Publisher, int.Parse(txtYear.Text));

                MessageBox.Show("          BOOK APP\nTitle: " + Title + "\nAuthor: " + Author + "\nPublisher: " + Publisher + "\nYear Published: " + Book.yearpublished.ToString());
            }
            catch
            {
                MessageBox.Show("INPUT ALL CREDENTIALS PLS!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
