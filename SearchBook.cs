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
    public partial class SearchBook : Form
    {
        public SearchBook()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string isbn = textBox7.Text.Trim();
            string title = textBox2.Text.Trim();
            string author = textBox3.Text.Trim();

            string query = "SELECT * FROM LibTable WHERE 1=1";

            if (!string.IsNullOrEmpty(isbn))
                query += " AND ISBN = @ISBN";

            if (!string.IsNullOrEmpty(title))
                query += " AND Title LIKE @Title";

            if (!string.IsNullOrEmpty(author))
                query += " AND Author LIKE @Author";

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-3B7KHR8\\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True;Trust Server Certificate=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);


                if (!string.IsNullOrEmpty(isbn))
                    cmd.Parameters.AddWithValue("@ISBN" , isbn);

                if (!string.IsNullOrEmpty(title))
                    cmd.Parameters.AddWithValue("@Title", "%" + title + "%");

                if (!string.IsNullOrEmpty(author))
                    cmd.Parameters.AddWithValue("@Author", "%" + author + "%");


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }

        }
    }
}

