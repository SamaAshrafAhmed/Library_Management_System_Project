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
    public partial class EditReaderDetails : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-MAIL4L03\MSSQLSERVER1;Initial Catalog=Project;Integrated Security=True;");
        public int read_id;
        string old_email = "";
        public EditReaderDetails()
        {
            InitializeComponent();
        }

        private void EditReaderDetails_Load(object sender, EventArgs e)
        {

            conn.Open();

            string authQuery = "Select * From Reader  Where  R_ID = " + read_id + " ";
            SqlDataAdapter ad = new SqlDataAdapter(authQuery, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            textBox1.Text = dt.Rows[0]["FirstName"].ToString();
            textBox2.Text = dt.Rows[0]["LastName"].ToString();
            textBox3.Text = dt.Rows[0]["Email"].ToString();
            textBox4.Text = dt.Rows[0]["Pass"].ToString();
            textBox5.Text = dt.Rows[0]["Phone_NO"].ToString();
            old_email = textBox3.Text;
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                // if the user enetered new email check it is unique 
                if (textBox3.Text == old_email)
                {
                    if (textBox4.Text.Length <= 10)
                    {
                        string read_Query = "UPDATE Reader SET FirstName = '" + textBox1.Text + "', LastName = '" + textBox2.Text +
                        "', Email = '" + textBox3.Text.ToLower() + "', Pass = '" + textBox4.Text + "', Phone_NO = '" + textBox5.Text +
                       "' WHERE R_ID = " + read_id;
                        SqlCommand read_cmnd = new SqlCommand(read_Query, conn);
                        read_cmnd.ExecuteNonQuery();
                        conn.Close();

                        ReaderMain m = new ReaderMain();
                        m.R_ID = read_id;
                        m.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password Length Should Not Exceed 10 characters");
                        conn.Close();


                    }

                }
                else
                {
                    string ReadQuery = "Select * From Reader Where Email = '" + textBox3.Text.ToLower() + "' ";
                    SqlDataAdapter ad = new SqlDataAdapter(ReadQuery, conn);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        if (textBox4.Text.Length <= 10)
                        {
                            string query = "UPDATE Reader SET FirstName = '" + textBox1.Text + "', LastName = '" + textBox2.Text +
                            "', Email = '" + textBox3.Text.ToLower() + "', Pass = '" + textBox4.Text + "', Phone_NO = '" + textBox5.Text +
                           "' WHERE R_ID = " + read_id;
                            SqlCommand cmnd = new SqlCommand(query, conn);
                            cmnd.ExecuteNonQuery();
                            conn.Close();


                            ReaderMain m = new ReaderMain();
                            m.R_ID = read_id;
                            m.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Password Length Should Not Exceed 10 characters");
                            conn.Close();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Email Already Exists!");
                        conn.Close();

                    }

                }



            }
            else
            {
                MessageBox.Show("Fields Should Not Be Empty!");
                conn.Close();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReaderMain m = new ReaderMain();
            m.R_ID = read_id;
            m.Show();
            this.Close();
        }
    }
}
