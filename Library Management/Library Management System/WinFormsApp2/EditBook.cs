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

namespace WinFormsApp2
{
    public partial class EditBook : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-MAIL4L03\MSSQLSERVER1;Initial Catalog=Project;Integrated Security=True;");
       public  int admin_id;
        string isbn = "";
        string oldAuth = "";
        public EditBook()
        {
            InitializeComponent();
        }
        private void LoadBookData()
        {
      
            isbn = textBox1.Text;
            oldAuth = textBox5.Text;
            

        }
        private void EditBook_Load(object sender, EventArgs e)
        {
            LoadBookData();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                // search for author in table author
                string authQuery = "Select * From Author Where Name= '" + textBox5.Text.ToLower() + "' ";
                SqlDataAdapter ad = new SqlDataAdapter(authQuery, conn);
                DataTable dt = new DataTable();
                ad.Fill(dt);


                // if the book has new author add him to table author
                if (dt.Rows.Count == 0)
                {
                    string q = "Insert into Author values ('" + textBox5.Text.ToLower() + "')";
                    SqlCommand cmand = new SqlCommand(q, conn);
                    cmand.ExecuteNonQuery();




                    ad = new SqlDataAdapter(authQuery, conn);
                    ad.Fill(dt);



                }
                int pubYear = Convert.ToInt16(textBox2.Text);

                int auth_id = Convert.ToInt32(dt.Rows[0]["Auth_ID"]); //get author id

                // edit the book in table book
                string book_query = "UPDATE Book SET Title = '" + textBox3.Text + "', Pub_Year = '" + pubYear + "', Category = '" + textBox4.Text + "' WHERE ISBN = '" + isbn + "'";
                SqlCommand book_cmnd = new SqlCommand(book_query, conn);
                book_cmnd.ExecuteNonQuery();


                // edit the book copy in table book copy
                string Book_query = "UPDATE BOOK_COPY SET Title = '" + textBox3.Text + "', Pub_Year = '" + pubYear + "', Category = '" + textBox4.Text + "' WHERE ISBN = '" + isbn + "'";
                SqlCommand Book_cmnd = new SqlCommand(Book_query, conn);
                Book_cmnd.ExecuteNonQuery();



                // if the user changesd the auhtor
                if (oldAuth != textBox5.Text)
                {
                    // Delete the old relation between old author and current book
                    string bookquery = "DELETE FROM Write WHERE ISBN = '" + textBox1.Text + "'";
                    SqlCommand bookcmnd = new SqlCommand(bookquery, conn);
                    bookcmnd.ExecuteNonQuery();

                    // insert the new auhtor relation with this book
                    string WriteQuery = "Insert into Write (Auth_ID, ISBN) values(" + auth_id + ",'" + isbn + "') ";
                    SqlCommand write_cmnd = new SqlCommand(WriteQuery, conn);
                    write_cmnd.ExecuteNonQuery();
                }

                // store the current admin relation with book
                string authr = "SELECT * FROM Manages WHERE admin_ID = " + admin_id + " AND ISBN = '" + isbn + "'";
                SqlDataAdapter a = new SqlDataAdapter(authr, conn);
                DataTable d = new DataTable();
                a.Fill(d);

                if (d.Rows.Count == 0)
                {
                    // add the admin id and book id to table manages
                    string managesQuery = "Insert into Manages (admin_ID, ISBN) values(" + admin_id + ",'" + isbn + "')";
                    SqlCommand cmnd = new SqlCommand(managesQuery, conn);
                    cmnd.ExecuteNonQuery();

                }

                conn.Close();
                AdminBrowsing ab = new AdminBrowsing();
                ab.AdminID = admin_id;
                ab.Show();
                this.Close();


            }
            else
            {
                MessageBox.Show("Fields Should Not Be Empty!");
                conn.Close();

               
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminBrowsing ab = new AdminBrowsing();
            ab.AdminID = admin_id;
            ab.Show();
            this.Close();
        }
    }

}
