namespace WinFormsApp2
{
    partial class ReaderSearch
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
            lOGOUTToolStripMenuItem = new ToolStripMenuItem();
            browseBooksToolStripMenuItem = new ToolStripMenuItem();
            bOOKSToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            borrowedBooksToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            hOMEToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            button1 = new Button();
            label1 = new Label();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            // browseBooksToolStripMenuItem
            // 
            browseBooksToolStripMenuItem.BackColor = Color.FromArgb(44, 44, 44);
            browseBooksToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 12F);
            browseBooksToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 192);
            browseBooksToolStripMenuItem.Name = "browseBooksToolStripMenuItem";
            browseBooksToolStripMenuItem.Size = new Size(256, 28);
            browseBooksToolStripMenuItem.Text = "Browse Books";
            browseBooksToolStripMenuItem.Click += browseBooksToolStripMenuItem_Click;
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
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Font = new Font("Arial Rounded MT Bold", 12F);
            toolStripMenuItem1.ForeColor = Color.Tan;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(105, 27);
            toolStripMenuItem1.Text = "Account";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Font = new Font("Arial Rounded MT Bold", 12F);
            toolStripMenuItem3.ForeColor = Color.Tan;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(29, 27);
            toolStripMenuItem3.Text = " ";
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
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(44, 44, 44);
            menuStrip1.Font = new Font("Arial Rounded MT Bold", 12F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hOMEToolStripMenuItem, toolStripMenuItem3, toolStripMenuItem1, bOOKSToolStripMenuItem, lOGOUTToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1067, 31);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(255, 255, 192);
            button1.Location = new Point(349, 632);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(307, 36);
            button1.TabIndex = 13;
            button1.Text = "Borrow";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 255, 192);
            label1.Location = new Point(33, 297);
            label1.Name = "label1";
            label1.Size = new Size(52, 23);
            label1.TabIndex = 12;
            label1.Text = "Title";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(41, 89);
            radioButton3.Margin = new Padding(3, 2, 3, 2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(122, 27);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Category";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(41, 26);
            radioButton2.Margin = new Padding(3, 2, 3, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(73, 27);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Title";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(41, 56);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(97, 27);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Author";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(255, 255, 192);
            groupBox1.Location = new Point(22, 89);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(208, 168);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Serch By:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(33, 329);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 31);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(360, 98);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(700, 369);
            dataGridView1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label3.ForeColor = Color.FromArgb(255, 255, 192);
            label3.Location = new Point(278, 566);
            label3.Name = "label3";
            label3.Size = new Size(116, 27);
            label3.TabIndex = 19;
            label3.Text = "Due Date";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Font = new Font("Arial Rounded MT Bold", 13.8F);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(458, 560);
            dateTimePicker2.MinDate = new DateTime(2024, 5, 11, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 34);
            dateTimePicker2.TabIndex = 18;
            dateTimePicker2.Value = new DateTime(2024, 5, 25, 23, 59, 59, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label2.ForeColor = Color.FromArgb(255, 255, 192);
            label2.Location = new Point(278, 505);
            label2.Name = "label2";
            label2.Size = new Size(126, 27);
            label2.TabIndex = 17;
            label2.Text = "Start Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.FromArgb(255, 255, 192);
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(44, 44, 44);
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(458, 499);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 34);
            dateTimePicker1.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 255, 192);
            label4.Location = new Point(338, 684);
            label4.Name = "label4";
            label4.Size = new Size(319, 27);
            label4.TabIndex = 20;
            label4.Text = "View Your Borrowed Books";
            label4.Click += label4_Click;
            // 
            // ReaderSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(1067, 734);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker2);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(menuStrip1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "ReaderSearch";
            Text = "ReaderSearch";
            Load += ReaderSearch_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem lOGOUTToolStripMenuItem;
        private ToolStripMenuItem browseBooksToolStripMenuItem;
        private ToolStripMenuItem bOOKSToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem hOMEToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Button button1;
        private Label label1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private ToolStripMenuItem borrowedBooksToolStripMenuItem;
    }
}