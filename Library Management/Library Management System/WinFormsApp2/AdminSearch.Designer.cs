namespace WinFormsApp2
{
    partial class AdminSearch
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            menuStrip1 = new MenuStrip();
            hOMEToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            bOOKSToolStripMenuItem = new ToolStripMenuItem();
            aDDBOOKToolStripMenuItem = new ToolStripMenuItem();
            browseBooksToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            lOGOUTToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(350, 50);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(700, 369);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(23, 281);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 31);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(255, 255, 192);
            groupBox1.Location = new Point(12, 41);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(208, 168);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Serch By:";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(41, 90);
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
            radioButton2.Location = new Point(41, 27);
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
            radioButton1.Location = new Point(41, 57);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(97, 27);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Author";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 255, 192);
            label1.Location = new Point(23, 249);
            label1.Name = "label1";
            label1.Size = new Size(52, 23);
            label1.TabIndex = 3;
            label1.Text = "Title";
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(255, 255, 192);
            button1.Location = new Point(23, 351);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(127, 36);
            button1.TabIndex = 4;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(64, 64, 64);
            button2.Location = new Point(199, 351);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(131, 36);
            button2.TabIndex = 5;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(44, 44, 44);
            menuStrip1.Font = new Font("Arial Rounded MT Bold", 12F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hOMEToolStripMenuItem, toolStripMenuItem3, toolStripMenuItem1, bOOKSToolStripMenuItem, lOGOUTToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1076, 31);
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
            bOOKSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aDDBOOKToolStripMenuItem, browseBooksToolStripMenuItem, searchToolStripMenuItem });
            bOOKSToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 12F);
            bOOKSToolStripMenuItem.ForeColor = Color.Tan;
            bOOKSToolStripMenuItem.Margin = new Padding(20, 0, 0, 0);
            bOOKSToolStripMenuItem.Name = "bOOKSToolStripMenuItem";
            bOOKSToolStripMenuItem.Size = new Size(84, 27);
            bOOKSToolStripMenuItem.Text = "Books";
            // 
            // aDDBOOKToolStripMenuItem
            // 
            aDDBOOKToolStripMenuItem.BackColor = Color.FromArgb(44, 44, 44);
            aDDBOOKToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 12F);
            aDDBOOKToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 192);
            aDDBOOKToolStripMenuItem.Name = "aDDBOOKToolStripMenuItem";
            aDDBOOKToolStripMenuItem.Size = new Size(233, 28);
            aDDBOOKToolStripMenuItem.Text = "Add Book";
            aDDBOOKToolStripMenuItem.Click += aDDBOOKToolStripMenuItem_Click;
            // 
            // browseBooksToolStripMenuItem
            // 
            browseBooksToolStripMenuItem.BackColor = Color.FromArgb(44, 44, 44);
            browseBooksToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 12F);
            browseBooksToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 192);
            browseBooksToolStripMenuItem.Name = "browseBooksToolStripMenuItem";
            browseBooksToolStripMenuItem.Size = new Size(233, 28);
            browseBooksToolStripMenuItem.Text = "Browse Books";
            browseBooksToolStripMenuItem.Click += browseBooksToolStripMenuItem_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.BackColor = Color.FromArgb(44, 44, 44);
            searchToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 12F);
            searchToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 192);
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(233, 28);
            searchToolStripMenuItem.Text = "Search";
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
            // AdminSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(1076, 472);
            Controls.Add(menuStrip1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminSearch";
            Text = "Search";
            Load += Search_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label1;
        private Button button1;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem hOMEToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem bOOKSToolStripMenuItem;
        private ToolStripMenuItem aDDBOOKToolStripMenuItem;
        private ToolStripMenuItem browseBooksToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem lOGOUTToolStripMenuItem;
    }
}