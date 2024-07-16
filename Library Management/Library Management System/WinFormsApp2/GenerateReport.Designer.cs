namespace WinFormsApp2
{
    partial class GenerateReport
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
            label1 = new Label();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 255, 192);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(59, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(987, 324);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label1.ForeColor = Color.FromArgb(255, 255, 192);
            label1.Location = new Point(238, 36);
            label1.Name = "label1";
            label1.Size = new Size(589, 21);
            label1.TabIndex = 1;
            label1.Text = "Total Number Of Books Written By Each Author in Each Category ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.8F);
            label2.ForeColor = Color.FromArgb(255, 255, 192);
            label2.Location = new Point(59, 401);
            label2.Name = "label2";
            label2.Size = new Size(954, 21);
            label2.TabIndex = 3;
            label2.Text = " Readers Who Are Borrowing Books From More Than One Category and Are Borrowing More Than 5 Books";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.BackgroundColor = Color.FromArgb(255, 255, 192);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(59, 437);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(987, 300);
            dataGridView2.TabIndex = 2;
            // 
            // GenerateReport
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(1146, 749);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(64, 64, 64);
            MinimumSize = new Size(600, 683);
            Name = "GenerateReport";
            Text = "GenerateReport";
            Load += GenerateReport_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView2;
    }
}