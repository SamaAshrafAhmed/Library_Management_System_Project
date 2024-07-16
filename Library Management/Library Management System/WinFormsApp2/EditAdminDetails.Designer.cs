namespace WinFormsApp2
{
    partial class EditAdminDetails
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F);
            label5.ForeColor = Color.FromArgb(255, 255, 192);
            label5.Location = new Point(140, 282);
            label5.Name = "label5";
            label5.Size = new Size(107, 23);
            label5.TabIndex = 19;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F);
            label4.ForeColor = Color.FromArgb(255, 255, 192);
            label4.Location = new Point(140, 220);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 18;
            label4.Text = "E-mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F);
            label3.ForeColor = Color.FromArgb(255, 255, 192);
            label3.Location = new Point(140, 156);
            label3.Name = "label3";
            label3.Size = new Size(114, 23);
            label3.TabIndex = 17;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F);
            label2.ForeColor = Color.FromArgb(255, 255, 192);
            label2.Location = new Point(140, 97);
            label2.Name = "label2";
            label2.Size = new Size(121, 23);
            label2.TabIndex = 16;
            label2.Text = " First Name";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Arial Rounded MT Bold", 12F);
            textBox4.Location = new Point(343, 279);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(313, 31);
            textBox4.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial Rounded MT Bold", 12F);
            textBox3.Location = new Point(343, 217);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(313, 31);
            textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial Rounded MT Bold", 12F);
            textBox2.Location = new Point(343, 153);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(313, 31);
            textBox2.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 192);
            button1.Font = new Font("Arial Rounded MT Bold", 13.8F);
            button1.ForeColor = Color.FromArgb(64, 64, 64);
            button1.Location = new Point(245, 344);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(306, 34);
            button1.TabIndex = 12;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Rounded MT Bold", 12F);
            textBox1.Location = new Point(343, 94);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(313, 31);
            textBox1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F);
            label1.ForeColor = Color.FromArgb(255, 255, 192);
            label1.Location = new Point(330, 27);
            label1.Name = "label1";
            label1.Size = new Size(134, 27);
            label1.TabIndex = 10;
            label1.Text = "Edit Profile";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.Font = new Font("Arial Rounded MT Bold", 13.8F);
            button2.ForeColor = Color.FromArgb(255, 255, 192);
            button2.Location = new Point(245, 386);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(306, 34);
            button2.TabIndex = 20;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // EditAdminDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "EditAdminDetails";
            Text = "Edit Profile";
            Load += EditAdminDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
    }
}