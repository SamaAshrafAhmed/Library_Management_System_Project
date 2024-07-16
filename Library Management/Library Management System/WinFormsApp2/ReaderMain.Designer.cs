namespace WinFormsApp2
{
    partial class ReaderMain
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
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            bOOKSToolStripMenuItem = new ToolStripMenuItem();
            browseBooksToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            borrowedBooksToolStripMenuItem = new ToolStripMenuItem();
            lOGOUTToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(44, 44, 44);
            menuStrip1.Font = new Font("Arial Rounded MT Bold", 12F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hOMEToolStripMenuItem, toolStripMenuItem3, toolStripMenuItem1, bOOKSToolStripMenuItem, lOGOUTToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 31);
            menuStrip1.TabIndex = 2;
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
            browseBooksToolStripMenuItem.Click += browseBooksToolStripMenuItem_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.BackColor = Color.FromArgb(44, 44, 44);
            searchToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 12F);
            searchToolStripMenuItem.ForeColor = Color.FromArgb(255, 255, 192);
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(256, 28);
            searchToolStripMenuItem.Text = "Search Books";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 255, 192);
            label1.Location = new Point(236, 145);
            label1.Name = "label1";
            label1.Size = new Size(330, 39);
            label1.TabIndex = 3;
            label1.Text = "Welcome Reader :)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 255, 128);
            label2.Location = new Point(289, 212);
            label2.Name = "label2";
            label2.Size = new Size(222, 27);
            label2.TabIndex = 5;
            label2.Text = "Start Your Journey";
            label2.Click += label2_Click_1;
            // 
            // ReaderMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "ReaderMain";
            Text = "ReaderMain";
            Load += ReaderMain_Load;
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
        private ToolStripMenuItem browseBooksToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem lOGOUTToolStripMenuItem;
        private Label label1;
        private Label label2;
        private ToolStripMenuItem borrowedBooksToolStripMenuItem;
    }
}