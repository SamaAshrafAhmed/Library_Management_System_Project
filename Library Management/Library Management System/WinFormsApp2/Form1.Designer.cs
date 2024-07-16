namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 192);
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(64, 64, 64);
            button1.Location = new Point(233, 354);
            button1.Name = "button1";
            button1.Size = new Size(309, 37);
            button1.TabIndex = 0;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Rounded MT Bold", 12F);
            textBox1.Location = new Point(285, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(316, 31);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial Rounded MT Bold", 12F);
            textBox2.Location = new Point(285, 183);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(316, 31);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F);
            label1.ForeColor = Color.FromArgb(255, 255, 128);
            label1.Location = new Point(217, 59);
            label1.Name = "label1";
            label1.Size = new Size(278, 23);
            label1.TabIndex = 4;
            label1.Text = "Create New Admin Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F);
            label2.ForeColor = Color.FromArgb(255, 255, 192);
            label2.Location = new Point(160, 132);
            label2.Name = "label2";
            label2.Size = new Size(116, 23);
            label2.TabIndex = 5;
            label2.Text = "First Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F);
            label3.ForeColor = Color.FromArgb(255, 255, 192);
            label3.Location = new Point(160, 183);
            label3.Name = "label3";
            label3.Size = new Size(114, 23);
            label3.TabIndex = 6;
            label3.Text = "Last Name";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial Rounded MT Bold", 12F);
            textBox3.Location = new Point(285, 237);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(316, 31);
            textBox3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F);
            label4.ForeColor = Color.FromArgb(255, 255, 192);
            label4.Location = new Point(160, 240);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 8;
            label4.Text = "E-mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(255, 255, 128);
            label5.Location = new Point(270, 409);
            label5.Name = "label5";
            label5.Size = new Size(203, 17);
            label5.TabIndex = 9;
            label5.Text = "Sign Up As Reader Instead";
            label5.Click += label5_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Arial Rounded MT Bold", 12F);
            textBox4.Location = new Point(285, 293);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new Size(316, 31);
            textBox4.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F);
            label6.ForeColor = Color.FromArgb(255, 255, 192);
            label6.Location = new Point(160, 296);
            label6.Name = "label6";
            label6.Size = new Size(107, 23);
            label6.TabIndex = 11;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(255, 255, 128);
            label7.Location = new Point(258, 456);
            label7.Name = "label7";
            label7.Size = new Size(230, 17);
            label7.TabIndex = 12;
            label7.Text = "Already Registered? Try Login";
            label7.Click += label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(753, 608);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Admin Sign Up";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
    }
}
