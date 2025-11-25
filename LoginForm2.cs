using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = "user";
            string password = "123x";

            if (textBox1.Text == username && textBox2.Text == password)
            {
                MessageBox.Show("Login Successfull");
                Form2 f2 = new Form2();
                f2.Show();
                return;

            }
            MessageBox.Show("Wrong Credentials");
            return;
        }
    }
}
