using Microsoft.Data.SqlClient;
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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("CS");
            comboBox1.Items.Add("Engineering");
            comboBox1.Items.Add("Arts");
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 10;
            numericUpDown1.Value = 0;
            numericUpDown1.Increment = 1;
            numericUpDown2.Minimum = 0;
            numericUpDown2.Maximum = 100;
            numericUpDown2.Value = 1;
            numericUpDown2.Increment = 1;
        }
 
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e) { }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void textBox7_TextChanged(object sender, EventArgs e) { }


        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox2.Text;
            string author = textBox3.Text;
            string publisher = textBox4.Text;
            string category = comboBox1.Text;

            if (string.IsNullOrWhiteSpace(title) ||
                string.IsNullOrWhiteSpace(author) ||
                string.IsNullOrWhiteSpace(publisher) ||
                comboBox1.SelectedItem == null ||
                string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text) ||
                string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            //comment added
            if (!int.TryParse(textBox1.Text, out int id))
            {
                MessageBox.Show("ID must be an integer.");
                return;
            }

            if (!int.TryParse(textBox7.Text, out int isbn))
            {
                MessageBox.Show("ISBN must be an integer.");
                return;
            }

            if (!float.TryParse(textBox6.Text, out float price))
            {
                MessageBox.Show("Price must be numeric.");
                return;
            }

            int quantity = (int)numericUpDown1.Value;
            int rn = (int)numericUpDown2.Value;
            DateTime dtp = dateTimePicker1.Value;

            using (SqlConnection conn = new SqlConnection(
                "Data Source=DESKTOP-3B7KHR8\\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True;Trust Server Certificate=True"))
            {
                conn.Open();

                string query = @"INSERT INTO LibTable 
                        (BookID, Title, Author, Publisher, Category, ISBN, Quantity, Price, RackNo, DateAdded)
                        VALUES
                        (@id, @title, @auth, @pub, @cat, @isbn, @qty, @price, @rn, @dtp)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@auth", author);
                cmd.Parameters.AddWithValue("@pub", publisher);
                cmd.Parameters.AddWithValue("@cat", category);
                cmd.Parameters.AddWithValue("@isbn", isbn);
                cmd.Parameters.AddWithValue("@qty", quantity);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@rn", rn);
                cmd.Parameters.AddWithValue("@dtp", dtp);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Book added successfully!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

