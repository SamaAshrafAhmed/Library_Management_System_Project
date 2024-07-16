using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-MAIL4L03\MSSQLSERVER1;Initial Catalog=Project;Integrated Security=True;");
        ErrorProvider errorProvider1 = new ErrorProvider();
        string g = "";
        public int userID;
        bool b1 = true;
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            if (radioButton1.Checked == true)
            {
                g = "admin";
                b1 = true;
            }
            else if (radioButton2.Checked == true)
            {
                g = "reader";
                b1 = true;
            }
            else
            {
                b1 = false;
            }

            string Query;

            if (b1 == true && textBox1.Text != "" && textBox2.Text != "")
            {
                if (g == "admin" )
                {
                    Query = "select * from Admin where Email= '"+textBox1.Text.ToLower()+"' and Pass='"+textBox2.Text+"' ";
                   
                  
                }
                else
                {
                    Query = "select * from Reader where Email='" + textBox1.Text.ToLower() + "' and Pass='" + textBox2.Text + "'";
                }
                SqlDataAdapter ad = new SqlDataAdapter(Query, con);
                DataTable dt = new DataTable();
                ad.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                   if(g=="admin")
                    {
                        // open admin home page
                        Form3 f = new Form3();
                        userID = Convert.ToInt32(dt.Rows[0]["admin_ID"]);
                        f.AD_ID = userID;
                        f.Show();
                        this.Close();
                    }
                    else
                    {
                        // open reader home page
                        ReaderMain m = new ReaderMain();
                        userID = Convert.ToInt32(dt.Rows[0]["R_ID"]);
                        m.R_ID = userID ;
                        m.Show();
                        this.Close();
                    }


                }
                else
                {
                    MessageBox.Show("username or password is wrong");
                }


            }
            else
            {
                MessageBox.Show("Fields Cannot Be Empty!", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            con.Close();
        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }


        private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }
    }
}
