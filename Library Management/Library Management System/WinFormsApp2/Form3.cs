using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    //Admin Main
    public partial class Form3 : Form
    {

        public int AD_ID;
        public Form3()
        {
            InitializeComponent();
        }



        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aDDBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open add book
            Form4 f = new Form4();
            f.admin_id = AD_ID;
            f.Show();
            this.Close();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open Login
            login l = new login();
            l.Show();
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //open admin edit account
            EditAdminDetails ed = new EditAdminDetails();
            ed.adm_id = AD_ID;
            ed.Show();
            this.Close();
        }

        private void browseBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminBrowsing a = new AdminBrowsing();
            a.AdminID = AD_ID;
            a.Show();
            this.Close();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            GenerateReport g = new GenerateReport();
            g.Show();

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminSearch s = new AdminSearch();
            s.AdminID = AD_ID;
            s.Show();
            this.Close();
        }
    }
}
