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
    public partial class EditAdminDetails : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-MAIL4L03\MSSQLSERVER1;Initial Catalog=Project;Integrated Security=True;");
        public int adm_id;
        string old_email = "";

        public EditAdminDetails()
        {
            InitializeComponent();
        }

        private void EditAdminDetails_Load(object sender, EventArgs e)
        {

            conn.Open();

            string authQuery = "Select * From Admin  Where  admin_ID = " + adm_id + " ";
            SqlDataAdapter ad = new SqlDataAdapter(authQuery, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            textBox1.Text = dt.Rows[0]["FirstName"].ToString();
            textBox2.Text = dt.Rows[0]["LastName"].ToString();
            textBox3.Text = dt.Rows[0]["Email"].ToString();
            textBox4.Text = dt.Rows[0]["Pass"].ToString();
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
                        string Admin_query = "UPDATE  Admin SET    FirstName  = '" + textBox1.Text + "',   LastName " +
                            " = '" + textBox2.Text + "', Email  " +
                            " = '" + textBox3.Text.ToLower()
                            + "',Pass ='" + textBox4.Text + "'  WHERE admin_ID =   " + adm_id + " ";
                        SqlCommand admin_cmnd = new SqlCommand(Admin_query, conn);
                        admin_cmnd.ExecuteNonQuery();
                        conn.Close();

                        Form3 f = new Form3();
                        f.AD_ID = adm_id;
                        f.Show();
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
                    string AdminQuery = "Select * From Admin Where Email = '" + textBox3.Text.ToLower() + "' ";
                    SqlDataAdapter ad = new SqlDataAdapter(AdminQuery, conn);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        if (textBox4.Text.Length <= 10)
                        {
                            string query = "UPDATE  Admin SET    FirstName " +
                                " = '" + textBox1.Text + "',   LastName  = '" + textBox2.Text + "', Email " +
                                "  = '" + textBox3.Text.ToLower() + "',Pass='" + textBox4.Text + "'  WHERE admin_ID = " +
                                " " + adm_id + "";
                            SqlCommand cmnd = new SqlCommand(query, conn);
                            cmnd.ExecuteNonQuery();


                            Form3 f = new Form3();
                            f.AD_ID = adm_id;
                            f.Show();
                            this.Close();

                            conn.Close();
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

            Form3 f = new Form3();
            f.AD_ID = adm_id;
            f.Show();
            this.Close();
        }
    }
}
