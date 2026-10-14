namespace Amaar_Metro_Project
{
    partial class MetroSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetroSchedule));
            label1 = new Label();
            M = new Label();
            Mc = new Label();
            Md = new Label();
            Ms = new Label();
            label6 = new Label();
            McodeTb = new TextBox();
            Mcap = new TextBox();
            Msrc = new ComboBox();
            Mdest = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            Mdt = new Label();
            Mdate = new DateTimePicker();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(201, 9);
            label1.Name = "label1";
            label1.Size = new Size(347, 62);
            label1.TabIndex = 2;
            label1.Text = "AMAR METRO";
            label1.Click += label1_Click;
            // 
            // M
            // 
            M.AutoSize = true;
            M.FlatStyle = FlatStyle.System;
            M.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            M.ForeColor = Color.Red;
            M.Location = new Point(30, 189);
            M.Name = "M";
            M.Size = new Size(140, 31);
            M.TabIndex = 3;
            M.Text = "Metro Code";
            // 
            // Mc
            // 
            Mc.AutoSize = true;
            Mc.FlatStyle = FlatStyle.System;
            Mc.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Mc.ForeColor = Color.Red;
            Mc.Location = new Point(30, 419);
            Mc.Name = "Mc";
            Mc.Size = new Size(137, 31);
            Mc.TabIndex = 4;
            Mc.Text = "No of Seats";
            Mc.Click += label3_Click;
            // 
            // Md
            // 
            Md.AutoSize = true;
            Md.FlatStyle = FlatStyle.System;
            Md.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Md.ForeColor = Color.Red;
            Md.Location = new Point(30, 313);
            Md.Name = "Md";
            Md.Size = new Size(87, 31);
            Md.TabIndex = 5;
            Md.Text = "Source";
            // 
            // Ms
            // 
            Ms.AutoSize = true;
            Ms.FlatStyle = FlatStyle.System;
            Ms.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Ms.ForeColor = Color.Red;
            Ms.Location = new Point(30, 251);
            Ms.Name = "Ms";
            Ms.Size = new Size(87, 31);
            Ms.TabIndex = 6;
            Ms.Text = "Source";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.System;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(251, 71);
            label6.Name = "label6";
            label6.Size = new Size(245, 31);
            label6.TabIndex = 10;
            label6.Text = "Record New Schedule";
            label6.Click += label6_Click;
            // 
            // McodeTb
            // 
            McodeTb.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            McodeTb.ForeColor = Color.Red;
            McodeTb.Location = new Point(179, 189);
            McodeTb.Name = "McodeTb";
            McodeTb.Size = new Size(161, 34);
            McodeTb.TabIndex = 11;
            // 
            // Mcap
            // 
            Mcap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Mcap.ForeColor = Color.Red;
            Mcap.Location = new Point(179, 419);
            Mcap.Name = "Mcap";
            Mcap.Size = new Size(161, 34);
            Mcap.TabIndex = 12;
            Mcap.TextChanged += textBox2_TextChanged;
            // 
            // Msrc
            // 
            Msrc.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Msrc.ForeColor = Color.Red;
            Msrc.FormattingEnabled = true;
            Msrc.Items.AddRange(new object[] { "Uttara North", "Uttara Center", "Uttara South", "Pallabi", "Mirpur 11", "Mirpur 10", "Kazipara", "Shewrapara", "Agargaon", "Bijoy Sarani", "Farmgate", "Karwan Bazar", "Shahbagh", "Dhaka University", "Bangladesh Secretariat", "Motijheel" });
            Msrc.Location = new Point(179, 251);
            Msrc.Name = "Msrc";
            Msrc.Size = new Size(161, 31);
            Msrc.TabIndex = 13;
            // 
            // Mdest
            // 
            Mdest.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Mdest.ForeColor = Color.Red;
            Mdest.FormattingEnabled = true;
            Mdest.Items.AddRange(new object[] { "Uttara North", "Uttara Center", "Uttara South", "Pallabi", "Mirpur 11", "Mirpur 10", "Kazipara", "Shewrapara", "Agargaon", "Bijoy Sarani", "Farmgate", "Karwan Bazar", "Shahbagh", "Dhaka University", "Bangladesh Secretariat", "Motijheel" });
            Mdest.Location = new Point(179, 313);
            Mdest.Name = "Mdest";
            Mdest.Size = new Size(161, 31);
            Mdest.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(220, 512);
            button1.Name = "button1";
            button1.Size = new Size(125, 47);
            button1.TabIndex = 15;
            button1.Text = "Record";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(390, 512);
            button2.Name = "button2";
            button2.Size = new Size(125, 47);
            button2.TabIndex = 16;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(396, 186);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 264);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // Mdt
            // 
            Mdt.AutoSize = true;
            Mdt.FlatStyle = FlatStyle.System;
            Mdt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Mdt.ForeColor = Color.Red;
            Mdt.Location = new Point(30, 369);
            Mdt.Name = "Mdt";
            Mdt.Size = new Size(125, 31);
            Mdt.TabIndex = 18;
            Mdt.Text = "Depurture";
            // 
            // Mdate
            // 
            Mdate.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Mdate.CalendarForeColor = Color.Red;
            Mdate.Location = new Point(179, 373);
            Mdate.Name = "Mdate";
            Mdate.Size = new Size(161, 27);
            Mdate.TabIndex = 19;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(305, 581);
            button3.Name = "button3";
            button3.Size = new Size(125, 47);
            button3.TabIndex = 20;
            button3.Text = "View Metro";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // MetroSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(735, 689);
            Controls.Add(button3);
            Controls.Add(Mdate);
            Controls.Add(Mdt);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Mdest);
            Controls.Add(Msrc);
            Controls.Add(Mcap);
            Controls.Add(McodeTb);
            Controls.Add(label6);
            Controls.Add(Ms);
            Controls.Add(Md);
            Controls.Add(Mc);
            Controls.Add(M);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MetroSchedule";
            Text = "MetroSchedule";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label M;
        private Label Mc;
        private Label Md;
        private Label Ms;
        private Label label6;
        private TextBox McodeTb;
        private TextBox Mcap;
        private ComboBox Msrc;
        private ComboBox Mdest;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label Mdt;
        private DateTimePicker Mdate;
        private Button button3;
    }
}