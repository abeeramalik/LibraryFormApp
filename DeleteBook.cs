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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryFormApp
{
    public partial class DeleteBook : Form
    {
        public DeleteBook()
        {
            InitializeComponent();
        }

        private void DeleteBook_Load(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int id))
            {
                MessageBox.Show("Enter valid ID.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(
                "Data Source=DESKTOP-3B7KHR8\\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True;Trust Server Certificate=True"))
            {
                conn.Open();

                string query = "DELETE FROM LibTable WHERE BookID = @BookID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BookID", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Book deleted successfully!");
                }
            }

        }



    }
}
