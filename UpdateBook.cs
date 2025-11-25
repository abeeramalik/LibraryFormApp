using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryFormApp
{
    public partial class UpdateBook : Form
    {
        public UpdateBook()
        {
            InitializeComponent();
        }



        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            string title = textBox2.Text;
            string author = textBox3.Text;
            string publisher = textBox4.Text;
            string category = comboBox1.Text;

            if (string.IsNullOrWhiteSpace(title) ||
                string.IsNullOrWhiteSpace(author) ||
                string.IsNullOrWhiteSpace(publisher) ||
                 string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text) ||
                string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (!int.TryParse(textBox5.Text, out int id))
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

                string query = @"UPDATE LibTable
                         SET Title = @title,
                             Author = @author,
                             Publisher = @publisher,
                             Category = @category,
                             ISBN = @isbn,
                             Quantity = @quantity,
                             Price = @price,
                             RackNo = @rn,
                             DateAdded = @dtp
                         WHERE BookID = @BookID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BookID", id);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@publisher", publisher);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@isbn", isbn);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@rn", rn);
                    cmd.Parameters.AddWithValue("@dtp", dtp);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Book updated successfully!");
                }
            }
        }

        private void UpdateBook_Load(object sender, EventArgs e)
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
    }
}

