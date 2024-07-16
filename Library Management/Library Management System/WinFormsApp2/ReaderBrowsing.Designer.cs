namespace WinFormsApp2
{
    partial class ReaderBrowsing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            hOMEToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            bOOKSToolStripMenuItem = new ToolStripMenuItem();
            browseBooksToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            borrowedBooksToolStripMenuItem = new ToolStripMenuItem();
            lOGOUTToolStripMenuItem = new ToolStripMenuItem();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(255, 255, 192);
            button1.Location = new Point(224, 611);
            button1.Name = "button1";
            button1.Size = new Size(488, 51);
            button1.TabIndex = 3;
            button1.Text = "Borrow";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 255, 192);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Gray;
            dataGridView1.Location = new Point(78, 107);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 330);
            dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 255, 192);
            label1.Location = new Point(355, 54);
            label1.Name = "label1";
            label1.Size = new Size(205, 32);
            label1.TabIndex = 7;
            label1.Text = "Library Books";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(44, 44, 44);
            menuStrip1.Font = new Font("Arial Rounded MT Bold", 12F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hOMEToolStripMenuItem, toolStripMenuItem3, toolStripMenuItem1, bOOKSToolStripMenuItem, lOGOUTToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(919, 31);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            hOMEToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 12F);
            hOMEToolStripMenuItem.ForeColor = Color.Tan;
            hOMEToolStripMenuItem.Margin = new Padding(50, 0, 0, 0);
            hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            hOMEToolStripMenuItem.Size = new Size(81, 27);
            hOMEToolStripMenuItem.Text = "Home";
            hOMEToolStripMenuItem.Click += hOMEToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Font = new Font("Arial Rounded MT Bold", 12F);
            toolStripMenuItem3.ForeColor = Color.Tan;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(29, 27);
            toolStripMenuItem3.Text = " ";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Font = new Font("Arial Rounded MT Bold", 12F);
            toolStripMenuItem1.ForeColor = Color.Tan;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(105, 27);
            toolStripMenuItem1.Text = "Account";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // bOOKSToolStripMenuItem
            // 
            bOOKSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { browseBooksToolStripMenuItem, searchToolStripMenuItem, borrowedBooksToolStripMenuItem });
            bOOKSToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 12F);
            bOOKSToolStripMenuItem.ForeColor = Color.Tan;
            bOOKSToolStripMenuItem.Margin = new Padding(20, 0, 0, 0);
            bOOKSToolStripMenuItem.Name = "bOOKSToolStripMenuItem";
            bOOKSToolStripMenuItem.Size = new Size(84, 27);
            bOOKSToolStripMenuItem.Text = "Books";
            // 
            // browseBooksToolStripMenuItem
            // 
            browseBooksToolStripMenuItem.BackColor = Color.FromArgb(44, 44, 44);
            browseBooksToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 12F);
            browseBooksToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 192);
            browseBooksToolStripMenuItem.Name = "browseBooksToolStripMenuItem";
            browseBooksToolStripMenuItem.Size = new Size(256, 28);
            browseBooksToolStripMenuItem.Text = "Browse Books";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.BackColor = Color.FromArgb(44, 44, 44);
            searchToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 12F);
            searchToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 192);
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(256, 28);
            searchToolStripMenuItem.Text = "Search";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // borrowedBooksToolStripMenuItem
            // 
            borrowedBooksToolStripMenuItem.BackColor = Color.FromArgb(44, 44, 44);
            borrowedBooksToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 192);
            borrowedBooksToolStripMenuItem.Name = "borrowedBooksToolStripMenuItem";
            borrowedBooksToolStripMenuItem.Size = new Size(256, 28);
            borrowedBooksToolStripMenuItem.Text = "Borrowed Books";
            borrowedBooksToolStripMenuItem.Click += borrowedBooksToolStripMenuItem_Click;
            // 
            // lOGOUTToolStripMenuItem
            // 
            lOGOUTToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            lOGOUTToolStripMenuItem.BackColor = Color.Maroon;
            lOGOUTToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            lOGOUTToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 12F);
            lOGOUTToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            lOGOUTToolStripMenuItem.Margin = new Padding(0, 0, 50, 0);
            lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            lOGOUTToolStripMenuItem.Size = new Size(92, 27);
            lOGOUTToolStripMenuItem.Text = "Logout";
            lOGOUTToolStripMenuItem.Click += lOGOUTToolStripMenuItem_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.FromArgb(255, 255, 192);
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(44, 44, 44);
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(404, 489);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 34);
            dateTimePicker1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label2.ForeColor = Color.FromArgb(255, 255, 192);
            label2.Location = new Point(224, 495);
            label2.Name = "label2";
            label2.Size = new Size(126, 27);
            label2.TabIndex = 10;
            label2.Text = "Start Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label3.ForeColor = Color.FromArgb(255, 255, 192);
            label3.Location = new Point(224, 556);
            label3.Name = "label3";
            label3.Size = new Size(116, 27);
            label3.TabIndex = 12;
            label3.Text = "Due Date";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Font = new Font("Arial Rounded MT Bold", 13.8F);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(404, 550);
            dateTimePicker2.MinDate = new DateTime(2024, 5, 11, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 34);
            dateTimePicker2.TabIndex = 11;
            dateTimePicker2.Value = new DateTime(2024, 5, 25, 23, 59, 59, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 255, 192);
            label4.Location = new Point(299, 685);
            label4.Name = "label4";
            label4.Size = new Size(319, 27);
            label4.TabIndex = 13;
            label4.Text = "View Your Borrowed Books";
            label4.Click += label4_Click;
            // 
            // ReaderBrowsing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(919, 761);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker2);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "ReaderBrowsing";
            Text = "Browse Books";
            Load += ReaderBrowsing_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hOMEToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem bOOKSToolStripMenuItem;
        private ToolStripMenuItem browseBooksToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem lOGOUTToolStripMenuItem;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label4;
        private ToolStripMenuItem borrowedBooksToolStripMenuItem;
    }
}