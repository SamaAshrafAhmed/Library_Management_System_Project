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
using Windows.UI.ViewManagement;

namespace WinFormsApp2
{
    public partial class AdminSearch : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-MAIL4L03\MSSQLSERVER1;Initial Catalog=Project;Integrated Security=True;");
        public int AdminID;
        public AdminSearch()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            EditBook ee = new EditBook();
            ee.admin_id = AdminID;
            ee.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ee.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ee.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ee.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ee.textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            ee.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want to Delete " + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "", "Confirmation!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                con.Open();
                string curr_ISBN = dataGridView1.CurrentRow.Cells[0].Value.ToString();


                // delete relations related to book from tables (borrow, write, manages)
                string q1 = "Delete From Borrow where ISBN = '" + curr_ISBN + "'";
                string q2 = "Delete From Write where ISBN = '" + curr_ISBN + "'";
                string q3 = "Delete From Manages where ISBN = '" + curr_ISBN + "'";

                SqlCommand cmnd = new SqlCommand(q1, con);
                cmnd.ExecuteNonQuery();

                cmnd = new SqlCommand(q2, con);
                cmnd.ExecuteNonQuery();


                cmnd = new SqlCommand(q3, con);
                cmnd.ExecuteNonQuery();

                // delete book Copy
                string q4 = "Delete From BOOK_COPY where ISBN = '" + curr_ISBN + "'";
                cmnd = new SqlCommand(q4, con);
                cmnd.ExecuteNonQuery();

                // delete book itself
                string q5 = "Delete From Book where ISBN = '" + curr_ISBN + "'";
                cmnd = new SqlCommand(q5, con);
                cmnd.ExecuteNonQuery();


                SqlDataAdapter ad = new SqlDataAdapter("select b.ISBN , Pub_Year ,Title , Category , a.Name as Author_Name  from Book b join Write w on b.ISBN = w.ISBN join Author a on w.Auth_ID = a.Auth_ID", con);
                DataTable d = new DataTable();
                ad.Fill(d);
                dataGridView1.DataSource = d;


                con.Close();
            }
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.AD_ID = AdminID;
            f.Show();
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditAdminDetails ed = new EditAdminDetails();
            ed.adm_id = AdminID;
            ed.Show();
            this.Close();
        }

        private void aDDBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.admin_id = AdminID;
            f.Show();
            this.Close();
        }

        private void browseBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminBrowsing a = new AdminBrowsing();
            a.AdminID = AdminID;
            a.Show();
            this.Close();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Close();   
        }
    }
}
