using Microsoft.Data.SqlClient;
namespace LibraryFormApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook lf2 = new AddBook();
            lf2.Show();
        }

        private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook lf3 = new ViewBook();
            lf3.Show();
        }

        private void updateBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBook lf4 = new UpdateBook();
            lf4.Show();
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit e1 = new Exit();
            e1.Show();
        }
        private void deleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteBook db = new DeleteBook();
            db.Show();
        }
        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ls = new Form2();
            ls.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBook sb = new SearchBook();
            sb.Show();
        }
    }
}
