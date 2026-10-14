namespace Amaar_Metro_Project
{
    partial class ViewSchedule
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
            label1 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            Mdate = new Label();
            comboBox2 = new ComboBox();
            Msrc = new ComboBox();
            textBox2 = new TextBox();
            McodeTb = new TextBox();
            label5 = new Label();
            Mdest = new Label();
            Mcap = new Label();
            label2 = new Label();
            ScheduleDGV = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)ScheduleDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(182, 9);
            label1.Name = "label1";
            label1.Size = new Size(347, 62);
            label1.TabIndex = 3;
            label1.Text = "AMAR METRO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.System;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(224, 71);
            label6.Name = "label6";
            label6.Size = new Size(262, 31);
            label6.TabIndex = 11;
            label6.Text = "View Scheduled Flights";
            label6.Click += label6_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.CalendarForeColor = Color.Red;
            dateTimePicker1.Location = new Point(158, 203);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(161, 27);
            dateTimePicker1.TabIndex = 29;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Mdate
            // 
            Mdate.AutoSize = true;
            Mdate.FlatStyle = FlatStyle.System;
            Mdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Mdate.ForeColor = Color.Red;
            Mdate.Location = new Point(12, 196);
            Mdate.Name = "Mdate";
            Mdate.Size = new Size(125, 31);
            Mdate.TabIndex = 28;
            Mdate.Text = "Depurture";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(526, 199);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(161, 31);
            comboBox2.TabIndex = 27;
            // 
            // Msrc
            // 
            Msrc.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Msrc.FormattingEnabled = true;
            Msrc.Location = new Point(526, 138);
            Msrc.Name = "Msrc";
            Msrc.Size = new Size(161, 31);
            Msrc.TabIndex = 26;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Red;
            textBox2.Location = new Point(378, 267);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 34);
            textBox2.TabIndex = 25;
            // 
            // McodeTb
            // 
            McodeTb.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            McodeTb.ForeColor = Color.Red;
            McodeTb.Location = new Point(158, 132);
            McodeTb.Name = "McodeTb";
            McodeTb.Size = new Size(161, 34);
            McodeTb.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.System;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(354, 138);
            label5.Name = "label5";
            label5.Size = new Size(87, 31);
            label5.TabIndex = 23;
            label5.Text = "Source";
            label5.Click += label5_Click;
            // 
            // Mdest
            // 
            Mdest.AutoSize = true;
            Mdest.FlatStyle = FlatStyle.System;
            Mdest.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Mdest.ForeColor = Color.Red;
            Mdest.Location = new Point(354, 199);
            Mdest.Name = "Mdest";
            Mdest.Size = new Size(139, 31);
            Mdest.TabIndex = 22;
            Mdest.Text = "Destination";
            // 
            // Mcap
            // 
            Mcap.AutoSize = true;
            Mcap.FlatStyle = FlatStyle.System;
            Mcap.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Mcap.ForeColor = Color.Red;
            Mcap.Location = new Point(182, 270);
            Mcap.Name = "Mcap";
            Mcap.Size = new Size(137, 31);
            Mcap.TabIndex = 21;
            Mcap.Text = "No of Seats";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(12, 132);
            label2.Name = "label2";
            label2.Size = new Size(140, 31);
            label2.TabIndex = 20;
            label2.Text = "Metro Code";
            label2.Click += label2_Click;
            // 
            // ScheduleDGV
            // 
            ScheduleDGV.BackgroundColor = Color.Snow;
            ScheduleDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ScheduleDGV.Location = new Point(12, 413);
            ScheduleDGV.Name = "ScheduleDGV";
            ScheduleDGV.RowHeadersWidth = 51;
            ScheduleDGV.Size = new Size(693, 217);
            ScheduleDGV.TabIndex = 30;
            ScheduleDGV.CellContentClick += ScheduleDGV_CellContentClick;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(378, 334);
            button2.Name = "button2";
            button2.Size = new Size(125, 47);
            button2.TabIndex = 32;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(66, 334);
            button1.Name = "button1";
            button1.Size = new Size(125, 47);
            button1.TabIndex = 31;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(224, 334);
            button3.Name = "button3";
            button3.Size = new Size(125, 47);
            button3.TabIndex = 33;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Green;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(526, 334);
            button4.Name = "button4";
            button4.Size = new Size(125, 47);
            button4.TabIndex = 34;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // ViewSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(717, 642);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ScheduleDGV);
            Controls.Add(dateTimePicker1);
            Controls.Add(Mdate);
            Controls.Add(comboBox2);
            Controls.Add(Msrc);
            Controls.Add(textBox2);
            Controls.Add(McodeTb);
            Controls.Add(label5);
            Controls.Add(Mdest);
            Controls.Add(Mcap);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewSchedule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewSchedule";
            Load += ViewSchedule_Load;
            ((System.ComponentModel.ISupportInitialize)ScheduleDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label Mdate;
        private ComboBox comboBox2;
        private ComboBox Msrc;
        private TextBox textBox2;
        private TextBox McodeTb;
        private Label label5;
        private Label Mdest;
        private Label Mcap;
        private Label label2;
        private DataGridView ScheduleDGV;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}