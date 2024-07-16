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
    public partial class BorrowedBooks : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-MAIL4L03\MSSQLSERVER1;Initial Catalog=Project;Integrated Security=True;");
        public int reader_id;
        public BorrowedBooks()
        {
            InitializeComponent();

           
        }

        private void BorrowedBooks_Load(object sender, EventArgs e)
        {
            SqlDataAdapter ad = new SqlDataAdapter("select Book.ISBN, Pub_Year, Title, Category, Start_Date, Due_Date from Book join Borrow on Book.ISBN = Borrow.ISBN where Borrow.R_ID = " + reader_id + " ", con);
            DataTable d = new DataTable();
            ad.Fill(d);
            dataGridView1.DataSource = d;
     
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            if (dataGridView1.Rows.Count > 0)
            {
                string q = "Delete From Borrow where ISBN = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' and R_ID = " + reader_id + " ";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();


                SqlDataAdapter ad = new SqlDataAdapter("select Book.ISBN, Pub_Year, Title, Category, Start_Date, Due_Date from Book join Borrow on Book.ISBN = Borrow.ISBN where Borrow.R_ID = " + reader_id + " ", con);
                DataTable d = new DataTable();
                ad.Fill(d);
                dataGridView1.DataSource = d;
            }
            
            con.Close();

        }
    }
}
