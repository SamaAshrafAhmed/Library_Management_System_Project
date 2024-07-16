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
    //Reader Sign Up
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-MAIL4L03\MSSQLSERVER1;Initial Catalog=project;Integrated Security=True;");

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {



            string mail = textBox3.Text.ToLower();

            // search for existing email
            string mailQuery = "Select Email from Reader where Email ='" + mail + "'";
            SqlDataAdapter ad = new SqlDataAdapter(mailQuery, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                {
                    string query = "Insert into Reader (FirstName, LastName, Email, Pass, Phone_NO) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "' )";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    //open Login page
                    login l = new login();
                    l.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Fields Should not be empty!");
                }
            }
            else { MessageBox.Show("Email Already Exists!"); }





        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
           
            //open Login page
            login l = new login();
            l.Show();
            this.Close();
        }
    }
}
