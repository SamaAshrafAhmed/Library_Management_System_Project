using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class ReaderBrowsing : Form
    {


        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-MAIL4L03\MSSQLSERVER1;Initial Catalog=Project;Integrated Security=True;");
        public int read_id;
        public ReaderBrowsing()
        {
            InitializeComponent();
            SqlDataAdapter ad = new SqlDataAdapter("select b.ISBN , Pub_Year ,Title , Category , a.Name as Author_Name from Book b join Write w on b.ISBN = w.ISBN join Author a on w.Auth_ID = a.Auth_ID", con);
            DataTable d = new DataTable();
            ad.Fill(d);
            dataGridView1.DataSource = d;
        }

        private void ReaderBrowsing_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReaderMain r = new ReaderMain();
            r.R_ID = read_id;
            r.Show();
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            // open Edit Account
            EditReaderDetails r = new EditReaderDetails();
            r.read_id = read_id;
            r.Show();
            this.Close();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open search
            ReaderSearch r = new ReaderSearch();
            r.read_id = read_id;
            r.Show();
            this.Close();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open Login
            login l = new login();
            l.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            // add relation between current book and current user
            DialogResult result = MessageBox.Show("Confirm Borrowing " + dataGridView1.CurrentRow.Cells[2].Value.ToString() + " From Date " + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " to Date " + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "", "Confirmation!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string q = "select * from Borrow where R_ID = " + read_id + " and ISBN = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' ";
                SqlDataAdapter ad = new SqlDataAdapter(q, con);
                DataTable d = new DataTable();
                ad.Fill(d);
                if (d.Rows.Count == 0)
                {
                    string query = "Insert into Borrow (ISBN, R_ID, Start_Date, Due_Date) values ('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' ,  " + read_id + ", '" + this.dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' , '" + this.dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' )";
                    SqlCommand cmnd = new SqlCommand(query, con);
                    cmnd.ExecuteNonQuery();
                    MessageBox.Show("Borrowed Successfully!");
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Book Already Borrowed!");
                    con.Close();
                }


            }
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            BorrowedBooks b = new BorrowedBooks();
            b.reader_id = this.read_id;
            b.Show();
        }

        private void borrowedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowedBooks b = new BorrowedBooks();
            b.reader_id = this.read_id;
            b.Show();
        }
    }
}
