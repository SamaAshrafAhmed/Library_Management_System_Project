namespace WinFormsApp2
{
    partial class Form4
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
            menuStrip1 = new MenuStrip();
            hOMEToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            bOOKSToolStripMenuItem = new ToolStripMenuItem();
            aDDBOOKToolStripMenuItem = new ToolStripMenuItem();
            browseBooksToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            lOGOUTToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(44, 44, 44);
            menuStrip1.Font = new Font("Arial Rounded MT Bold", 12F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hOMEToolStripMenuItem, toolStripMenuItem1, bOOKSToolStripMenuItem, lOGOUTToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(771, 31);
            menuStrip1.TabIndex = 1;
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
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Font = new Font("Arial Rounded MT Bold", 12F);
            toolStripMenuItem1.ForeColor = Color.Tan;
            toolStripMenuItem1.Margin = new Padding(50, 0, 0, 0);
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
            bOOKSToolStripMenuItem.Margin = new Padding(50, 0, 0, 0);
            bOOKSToolStripMenuItem.Name = "bOOKSToolStripMenuItem";
            bOOKSToolStripMenuItem.Size = new Size(84, 27);
            bOOKSToolStripMenuItem.Text = "Books";
            bOOKSToolStripMenuItem.MouseEnter += bOOKSToolStripMenuItem_MouseEnter;
            bOOKSToolStripMenuItem.MouseHover += bOOKSToolStripMenuItem_MouseHover;
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
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 255, 192);
            label1.Location = new Point(269, 61);
            label1.Name = "label1";
            label1.Size = new Size(215, 32);
            label1.TabIndex = 2;
            label1.Text = "Add New Book";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F);
            label2.ForeColor = Color.FromArgb(255, 255, 192);
            label2.Location = new Point(189, 121);
            label2.Name = "label2";
            label2.Size = new Size(52, 23);
            label2.TabIndex = 3;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F);
            label3.ForeColor = Color.FromArgb(255, 255, 192);
            label3.Location = new Point(189, 222);
            label3.Name = "label3";
            label3.Size = new Size(169, 23);
            label3.TabIndex = 4;
            label3.Text = "Publication Year";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F);
            label4.ForeColor = Color.FromArgb(255, 255, 192);
            label4.Location = new Point(189, 278);
            label4.Name = "label4";
            label4.Size = new Size(76, 23);
            label4.TabIndex = 5;
            label4.Text = "Author";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Rounded MT Bold", 12F);
            textBox1.Location = new Point(388, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 31);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial Rounded MT Bold", 12F);
            textBox2.Location = new Point(388, 219);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(282, 31);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial Rounded MT Bold", 12F);
            textBox3.Location = new Point(388, 275);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(282, 31);
            textBox3.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 224, 192);
            button1.Font = new Font("Arial Rounded MT Bold", 12F);
            button1.ForeColor = Color.FromArgb(64, 64, 64);
            button1.Location = new Point(280, 431);
            button1.Name = "button1";
            button1.Size = new Size(216, 42);
            button1.TabIndex = 9;
            button1.Text = "Add Book";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Arial Rounded MT Bold", 12F);
            textBox4.Location = new Point(388, 169);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(282, 31);
            textBox4.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F);
            label5.ForeColor = Color.FromArgb(255, 255, 192);
            label5.Location = new Point(189, 172);
            label5.Name = "label5";
            label5.Size = new Size(58, 23);
            label5.TabIndex = 10;
            label5.Text = "ISBN";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Arial Rounded MT Bold", 12F);
            textBox5.Location = new Point(388, 329);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(282, 31);
            textBox5.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F);
            label6.ForeColor = Color.FromArgb(255, 255, 192);
            label6.Location = new Point(189, 332);
            label6.Name = "label6";
            label6.Size = new Size(101, 23);
            label6.TabIndex = 12;
            label6.Text = "Category";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(771, 531);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "Form4";
            Text = "Add New Book";
            Load += Form4_Load_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hOMEToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem bOOKSToolStripMenuItem;
        private ToolStripMenuItem aDDBOOKToolStripMenuItem;
        private ToolStripMenuItem browseBooksToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem lOGOUTToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
    }
}