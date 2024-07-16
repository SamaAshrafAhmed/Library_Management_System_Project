namespace WinFormsApp2
{
    partial class login
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
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Arial Rounded MT Bold", 12F);
            radioButton2.ForeColor = Color.FromArgb(255, 255, 192);
            radioButton2.Location = new Point(514, 267);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(103, 27);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "Reader";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Arial Rounded MT Bold", 12F);
            radioButton1.ForeColor = Color.FromArgb(255, 255, 192);
            radioButton1.Location = new Point(237, 267);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(93, 27);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "Admin";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F);
            label2.ForeColor = Color.FromArgb(255, 255, 192);
            label2.Location = new Point(131, 190);
            label2.Name = "label2";
            label2.Size = new Size(107, 23);
            label2.TabIndex = 11;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F);
            label1.ForeColor = Color.FromArgb(255, 255, 192);
            label1.Location = new Point(131, 112);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 9;
            label1.Text = "Email";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Font = new Font("Arial Rounded MT Bold", 12F);
            button1.ForeColor = Color.FromArgb(255, 255, 192);
            button1.Location = new Point(251, 340);
            button1.Name = "button1";
            button1.Size = new Size(343, 43);
            button1.TabIndex = 7;
            button1.Text = "log in ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Rounded MT Bold", 12F);
            textBox1.ForeColor = Color.FromArgb(64, 64, 64);
            textBox1.Location = new Point(271, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(390, 31);
            textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial Rounded MT Bold", 12F);
            textBox2.ForeColor = Color.FromArgb(64, 64, 64);
            textBox2.Location = new Point(269, 187);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(392, 31);
            textBox2.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(352, 27);
            label3.Name = "label3";
            label3.Size = new Size(96, 34);
            label3.TabIndex = 16;
            label3.Text = "Login";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            ForeColor = Color.FromArgb(255, 255, 128);
            Name = "login";
            Text = "Login";
            Load += login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
    }
}