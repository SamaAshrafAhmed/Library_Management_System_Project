using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp2
{

        // Admin Sign Up
    public partial class Form1 : Form
    {
        
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-MAIL4L03\MSSQLSERVER1;Initial Catalog=Project;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                      
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string mail = textBox3.Text.ToLower();

            // search for existing email
            string mailQuery = "Select Email from Admin where Email ='" + mail + "'";
            SqlDataAdapter ad = new SqlDataAdapter(mailQuery, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                // if mail is new
                // check feilds are not empty
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
                {
                    string query = "Insert into Admin (FirstName, LastName, Email, Pass) values('" + textBox1.Text + "','" + textBox2.Text + "','" + mail + "','" + textBox4.Text + "' )";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    


                    //open Login page
                    login l = new login();
                    l.Show();
                    this.Hide();



                }
                else
                {
                    MessageBox.Show("Fields Should not be empty!");
                }

            }
            else
                MessageBox.Show("Email Already Exists!");



          

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //open Login page
            login l = new login();
            l.Show();
            this.Hide();
        }
    }
}
