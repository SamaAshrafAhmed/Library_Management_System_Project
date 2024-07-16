using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    //Add Book

    public partial class Form4 : Form
    {
        public int admin_id;
        public int auth_id;


        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-MAIL4L03\MSSQLSERVER1;Initial Catalog=Project;Integrated Security=True;");

        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            conn.Open();

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                // check that isbn is unique among books
                string ISBNQuery = "Select * From Book Where ISBN= '" + textBox4.Text + "' ";
                SqlDataAdapter ad1 = new SqlDataAdapter(ISBNQuery, conn);
                DataTable dt1 = new DataTable();
                ad1.Fill(dt1);

                if (dt1.Rows.Count == 0)
                {
                    string authQuery = "Select * From Author Where Name= '" + textBox3.Text.ToLower() + "' ";
                    SqlDataAdapter ad = new SqlDataAdapter(authQuery, conn);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);


                    // if the book has new author add him to table author
                    if (dt.Rows.Count == 0)
                    {
                        string q = "Insert into Author values ('" + textBox3.Text.ToLower() + "')";
                        SqlCommand cmand = new SqlCommand(q, conn);
                        cmand.ExecuteNonQuery();

                        ad = new SqlDataAdapter(authQuery, conn);
                        ad.Fill(dt);

                    }

                    auth_id = Convert.ToInt32(dt.Rows[0]["Auth_ID"]); //get author id

                    // add the book to table book
                    string book_query = "Insert into Book(ISBN, Title, Pub_Year, Category ) values('" + textBox4.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox5.Text + "')";
                    SqlCommand book_cmnd = new SqlCommand(book_query, conn);
                    book_cmnd.ExecuteNonQuery();


                    // add a book copy to table book copy
                    string bookcopy_query = "Insert into BOOK_COPY (ISBN, Title, Pub_Year, Category ) values('" + textBox4.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox5.Text + "')";
                    SqlCommand bookcopycmnd = new SqlCommand(bookcopy_query, conn);
                    bookcopycmnd.ExecuteNonQuery();


                    // add author id and book id to table writes
                    string WriteQuery = "Insert into Write (Auth_ID, ISBN) values(" + auth_id + ",'" + textBox4.Text + "') ";
                    SqlCommand write_cmnd = new SqlCommand(WriteQuery, conn);
                    write_cmnd.ExecuteNonQuery();




                    // add the admin id and book id to table manages
                    string managesQuery = "Insert into Manages (admin_ID, ISBN) values(" + admin_id + ",'" + textBox4.Text + "')";
                    SqlCommand cmnd = new SqlCommand(managesQuery, conn);
                    cmnd.ExecuteNonQuery();





                    conn.Close();
                    textBox1.Text="";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";


                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Book ISBN Already Exists!");
                    conn.Close();
                }






            }
            else
            {
                MessageBox.Show("Fields Should Not Be Empty!");
                conn.Close();
            }
        }

        private void bOOKSToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {

        }

        private void bOOKSToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {

        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.AD_ID = admin_id;
            f.Show();
            this.Hide();


        }

        private void Form4_Load_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditAdminDetails ed = new EditAdminDetails();
            ed.adm_id = admin_id;
            ed.Show();
            this.Close();
        }

        private void aDDBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void browseBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminBrowsing a = new AdminBrowsing();
            a.AdminID = admin_id;
            a.Show();
            this.Close();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open search page
            AdminSearch a=new AdminSearch();
            a.AdminID = admin_id;
            a.Show();
            this.Close();
        }
    }
}
