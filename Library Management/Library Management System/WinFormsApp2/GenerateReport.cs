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
    public partial class GenerateReport : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-MAIL4L03\MSSQLSERVER1;Initial Catalog=Project;Integrated Security=True;");
        public GenerateReport()
        {
            InitializeComponent();
        }

        private void GenerateReport_Load(object sender, EventArgs e)
        {
            SqlDataAdapter ad = new SqlDataAdapter("SELECT  a.Auth_ID, a.Name AS Author_Name,  bc.Category,   COUNT(DISTINCT b.ISBN) AS Total_Books_In_Category FROM Author a JOIN  Write w ON a.Auth_ID = w.Auth_ID JOIN    Book b ON w.ISBN = b.ISBN JOIN   BOOK_COPY bc ON b.ISBN = bc.ISBN GROUP BY  a.Auth_ID, a.Name, bc.Category ORDER BY a.Auth_ID;", con);
            DataTable d = new DataTable();
            ad.Fill(d);
            dataGridView1.DataSource = d;

            SqlDataAdapter ad2 = new SqlDataAdapter("SELECT  r.R_ID,     r.FirstName AS Reader_FirstName,     r.LastName AS Reader_LastName,    r.Email AS Reader_Email,     COUNT(DISTINCT bc.Category) AS Total_Categories_Borrowed,    COUNT(*) AS Total_Books_Borrowed FROM      Reader r JOIN      Borrow b ON r.R_ID = b.R_ID JOIN     BOOK_COPY bc ON b.ISBN = bc.ISBN GROUP BY      r.R_ID, r.LastName, r.FirstName, r.Email HAVING      COUNT(DISTINCT bc.Category) > 1     AND COUNT(*) > 5 ORDER BY      Total_Books_Borrowed DESC;", con);
            DataTable d2 = new DataTable();
            ad2.Fill(d2);
            dataGridView2.DataSource = d2;
        }
    }
}
