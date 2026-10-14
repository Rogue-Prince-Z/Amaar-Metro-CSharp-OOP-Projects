namespace Amaar_Metro_Project
{
    partial class ViewPassenger
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label6 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            PcontTb = new Label();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            PnameTb = new Label();
            PgendCb = new Label();
            PidTb = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            PassengerDGV = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)PassengerDGV).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.System;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(235, 59);
            label6.Name = "label6";
            label6.Size = new Size(232, 31);
            label6.TabIndex = 14;
            label6.Text = "View New Passenger";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(186, -3);
            label1.Name = "label1";
            label1.Size = new Size(347, 62);
            label1.TabIndex = 13;
            label1.Text = "AMAR METRO";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.Red;
            textBox4.Location = new Point(539, 137);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(161, 34);
            textBox4.TabIndex = 40;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.Red;
            textBox3.Location = new Point(165, 187);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(161, 34);
            textBox3.TabIndex = 39;
            // 
            // PcontTb
            // 
            PcontTb.AutoSize = true;
            PcontTb.FlatStyle = FlatStyle.System;
            PcontTb.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PcontTb.ForeColor = Color.Red;
            PcontTb.Location = new Point(12, 187);
            PcontTb.Name = "PcontTb";
            PcontTb.Size = new Size(97, 31);
            PcontTb.TabIndex = 38;
            PcontTb.Text = "Contact";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "MALE", "FEMALE", "NON-BINARY" });
            comboBox2.Location = new Point(539, 187);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(161, 31);
            comboBox2.TabIndex = 37;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Red;
            textBox1.Location = new Point(165, 136);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 34);
            textBox1.TabIndex = 36;
            // 
            // PnameTb
            // 
            PnameTb.AutoSize = true;
            PnameTb.FlatStyle = FlatStyle.System;
            PnameTb.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PnameTb.ForeColor = Color.Red;
            PnameTb.Location = new Point(344, 137);
            PnameTb.Name = "PnameTb";
            PnameTb.Size = new Size(189, 31);
            PnameTb.TabIndex = 35;
            PnameTb.Text = "Passenger Name";
            // 
            // PgendCb
            // 
            PgendCb.AutoSize = true;
            PgendCb.FlatStyle = FlatStyle.System;
            PgendCb.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PgendCb.ForeColor = Color.Red;
            PgendCb.Location = new Point(344, 187);
            PgendCb.Name = "PgendCb";
            PgendCb.Size = new Size(91, 31);
            PgendCb.TabIndex = 34;
            PgendCb.Text = "Gender";
            // 
            // PidTb
            // 
            PidTb.AutoSize = true;
            PidTb.FlatStyle = FlatStyle.System;
            PidTb.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PidTb.ForeColor = Color.Red;
            PidTb.Location = new Point(12, 136);
            PidTb.Name = "PidTb";
            PidTb.Size = new Size(147, 31);
            PidTb.TabIndex = 33;
            PidTb.Text = "Passenger Id";
            // 
            // button4
            // 
            button4.BackColor = Color.Green;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(527, 291);
            button4.Name = "button4";
            button4.Size = new Size(125, 47);
            button4.TabIndex = 44;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(225, 291);
            button3.Name = "button3";
            button3.Size = new Size(125, 47);
            button3.TabIndex = 43;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(379, 291);
            button2.Name = "button2";
            button2.Size = new Size(125, 47);
            button2.TabIndex = 42;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(67, 291);
            button1.Name = "button1";
            button1.Size = new Size(125, 47);
            button1.TabIndex = 41;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PassengerDGV
            // 
            PassengerDGV.BackgroundColor = Color.Snow;
            PassengerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PassengerDGV.Location = new Point(12, 394);
            PassengerDGV.Name = "PassengerDGV";
            PassengerDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            PassengerDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = Color.Navy;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PassengerDGV.RowsDefaultCellStyle = dataGridViewCellStyle1;
            PassengerDGV.RowTemplate.Height = 30;
            PassengerDGV.Size = new Size(693, 217);
            PassengerDGV.TabIndex = 45;
            PassengerDGV.CellContentClick += PassengerDGV_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.System;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(690, -3);
            label3.Name = "label3";
            label3.Size = new Size(29, 31);
            label3.TabIndex = 46;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // ViewPassenger
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(717, 642);
            Controls.Add(label3);
            Controls.Add(PassengerDGV);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(PcontTb);
            Controls.Add(comboBox2);
            Controls.Add(textBox1);
            Controls.Add(PnameTb);
            Controls.Add(PgendCb);
            Controls.Add(PidTb);
            Controls.Add(label6);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewPassenger";
            Text = "ViewPassenger";
            Load += ViewPassenger_Load;
            ((System.ComponentModel.ISupportInitialize)PassengerDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label PcontTb;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Label PnameTb;
        private Label PgendCb;
        private Label PidTb;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView PassengerDGV;
        private Label label3;
    }
}