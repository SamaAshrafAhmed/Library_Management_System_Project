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

namespace WinFormsApp2
{
    public partial class ReaderSearch : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-MAIL4L03\MSSQLSERVER1;Initial Catalog=Project;Integrated Security=True;");
        public int read_id;
        public ReaderSearch()
        {
            InitializeComponent();
        }
        private void ReaderSearch_Load(object sender, EventArgs e)
        {
            SqlDataAdapter ad = new SqlDataAdapter("select b.ISBN , Pub_Year ,Title , Category , a.Name as Author_Name from Book b join Write w on b.ISBN = w.ISBN join Author a on w.Auth_ID = a.Auth_ID", con);
            DataTable d = new DataTable();
            ad.Fill(d);
            dataGridView1.DataSource = d;
            label1.Text = "Title";
            radioButton2.Checked = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                SqlDataAdapter ad = new SqlDataAdapter("select b.ISBN , Pub_Year ,Title , Category , a.Name as Author_Name from Book b join Write w on b.ISBN = w.ISBN join Author a on w.Auth_ID = a.Auth_ID where a.Name like '%" + textBox1.Text + "%'", con);
                DataTable d = new DataTable();
                ad.Fill(d);
                dataGridView1.DataSource = d;
            }
            if (radioButton2.Checked)
            {

                SqlDataAdapter ad = new SqlDataAdapter("select b.ISBN , Pub_Year ,Title , Category , a.Name as Author_Name from Book b join Write w on b.ISBN = w.ISBN join Author a on w.Auth_ID = a.Auth_ID where Title like '%" + textBox1.Text + "%'", con);
                DataTable d = new DataTable();
                ad.Fill(d);
                dataGridView1.DataSource = d;
            }
            if (radioButton3.Checked)
            {

                SqlDataAdapter ad = new SqlDataAdapter("select b.ISBN , Pub_Year ,Title , Category , a.Name as Author_Name from Book b join Write w on b.ISBN = w.ISBN join Author a on w.Auth_ID = a.Auth_ID where Category like '%" + textBox1.Text + "%'", con);
                DataTable d = new DataTable();
                ad.Fill(d);
                dataGridView1.DataSource = d;
            }
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label1.Text = "Title";
                textBox1.Text = "";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = "Author";
                textBox1.Text = "";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                label1.Text = "Category";
                textBox1.Text = "";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            BorrowedBooks b = new BorrowedBooks();
            b.reader_id = this.read_id;
            b.Show();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReaderMain m = new ReaderMain();
            m.R_ID = this.read_id;
            m.Show();
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditReaderDetails ed = new EditReaderDetails();
            ed.read_id = this.read_id;
            ed.Show();
            this.Close();
        }

        private void browseBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReaderBrowsing reader = new ReaderBrowsing();
            reader.read_id = read_id;
            reader.Show();
            this.Close();
        }

        private void borrowedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowedBooks b = new BorrowedBooks();
            b.reader_id = this.read_id;
            b.Show();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Close();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
