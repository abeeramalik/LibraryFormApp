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
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        private void ViewBook_Load(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(
    "Data Source=DESKTOP-3B7KHR8\\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True;Trust Server Certificate=True"))
            {
                conn.Open();

                string query = "SELECT * FROM LibTable";

                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
            }

        }

    }
    }

