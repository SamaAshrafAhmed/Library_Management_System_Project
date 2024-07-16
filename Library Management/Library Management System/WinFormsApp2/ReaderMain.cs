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
    public partial class ReaderMain : Form
    {

        public int R_ID;
        public ReaderMain()
        {
            InitializeComponent();
        }

        private void ReaderMain_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            // open browse page
            ReaderBrowsing r = new ReaderBrowsing();
            r.read_id = R_ID;
            r.Show();
            this.Close();

        }

        private void browseBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open browse page
            ReaderBrowsing r = new ReaderBrowsing();
            r.read_id = R_ID;
            r.Show();
            this.Close();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open search books
            ReaderSearch r = new ReaderSearch();
            r.read_id = R_ID;
            r.Show();
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // open Edit Account
            EditReaderDetails r = new EditReaderDetails();
            r.read_id = R_ID;
            r.Show();
            this.Close();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open Login
            login l = new login();
            l.Show();
            this.Close();
        }

        private void borrowedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowedBooks b = new BorrowedBooks();
            b.reader_id = R_ID;
            b.Show();
            
        }
    }
}
