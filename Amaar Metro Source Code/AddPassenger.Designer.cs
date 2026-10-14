
namespace Amaar_Metro_Project
{
    partial class AddPassenger
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

        private TextBox GetPassengerID()
        {
            return PassengerID;
        }

        private TextBox GetPassengerID()
        {
            return PassengerID;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(TextBox passengerID, TextBox passengerID)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPassenger));
            label6 = new Label();
            label1 = new Label();
            Gender = new ComboBox();
            PassengerID = new TextBox();
            PasseName = new Label();
            Gend = new Label();
            PassID = new Label();
            Contact = new TextBox();
            Cont = new Label();
            PassengerName = new TextBox();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            Age = new TextBox();
            Ag = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.System;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(238, 99);
            label6.Name = "label6";
            label6.Size = new Size(254, 31);
            label6.TabIndex = 12;
            label6.Text = "Record New Passenger";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(198, 28);
            label1.Name = "label1";
            label1.Size = new Size(347, 62);
            label1.TabIndex = 11;
            label1.Text = "AMAR METRO";
            // 
            // Gender
            // 
            Gender.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Gender.FormattingEnabled = true;
            Gender.Items.AddRange(new object[] { "MALE", "FEMALE", "NON BINARY" });
            Gender.Location = new Point(238, 432);
            Gender.Name = "Gender";
            Gender.Size = new Size(161, 31);
            Gender.TabIndex = 27;
            // 
            // PassengerID
            // 
            PassengerID.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            PassengerID.ForeColor = Color.Red;
            PassengerID.Location = new Point(238, 183);
            PassengerID.Name = "PassengerID";
            PassengerID.Size = new Size(161, 34);
            PassengerID.TabIndex = 24;
            NewMethod();
            // 
            // PasseName
            // 
            PasseName.AutoSize = true;
            PasseName.FlatStyle = FlatStyle.System;
            PasseName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasseName.ForeColor = Color.Red;
            PasseName.Location = new Point(38, 256);
            PasseName.Name = "PasseName";
            PasseName.Size = new Size(189, 31);
            PasseName.TabIndex = 23;
            PasseName.Text = "Passenger Name";
            // 
            // Gend
            // 
            Gend.AutoSize = true;
            Gend.FlatStyle = FlatStyle.System;
            Gend.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Gend.ForeColor = Color.Red;
            Gend.Location = new Point(38, 432);
            Gend.Name = "Gend";
            Gend.Size = new Size(91, 31);
            Gend.TabIndex = 22;
            Gend.Text = "Gender";
            // 
            // PassID
            // 
            PassID.AutoSize = true;
            PassID.FlatStyle = FlatStyle.System;
            PassID.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PassID.ForeColor = Color.Red;
            PassID.Location = new Point(38, 183);
            PassID.Name = "PassID";
            PassID.Size = new Size(150, 31);
            PassID.TabIndex = 20;
            PassID.Text = "Passenger ID";
            // 
            // Contact
            // 
            Contact.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            Contact.ForeColor = Color.Red;
            Contact.Location = new Point(238, 321);
            Contact.Name = "Contact";
            Contact.Size = new Size(161, 34);
            Contact.TabIndex = 31;
            // 
            // Cont
            // 
            Cont.AutoSize = true;
            Cont.FlatStyle = FlatStyle.System;
            Cont.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cont.ForeColor = Color.Red;
            Cont.Location = new Point(38, 321);
            Cont.Name = "Cont";
            Cont.Size = new Size(97, 31);
            Cont.TabIndex = 30;
            Cont.Text = "Contact";
            // 
            // PassengerName
            // 
            PassengerName.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            PassengerName.ForeColor = Color.Red;
            PassengerName.Location = new Point(238, 256);
            PassengerName.Name = "PassengerName";
            PassengerName.Size = new Size(161, 34);
            PassengerName.TabIndex = 32;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(367, 513);
            button2.Name = "button2";
            button2.Size = new Size(125, 47);
            button2.TabIndex = 34;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(198, 513);
            button1.Name = "button1";
            button1.Size = new Size(125, 47);
            button1.TabIndex = 33;
            button1.Text = "Record";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(438, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 320);
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.System;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(707, -2);
            label3.Name = "label3";
            label3.Size = new Size(29, 31);
            label3.TabIndex = 36;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // Age
            // 
            Age.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            Age.ForeColor = Color.Red;
            Age.Location = new Point(238, 376);
            Age.Name = "Age";
            Age.Size = new Size(161, 34);
            Age.TabIndex = 38;
            // 
            // Ag
            // 
            Ag.AutoSize = true;
            Ag.FlatStyle = FlatStyle.System;
            Ag.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Ag.ForeColor = Color.Red;
            Ag.Location = new Point(38, 376);
            Ag.Name = "Ag";
            Ag.Size = new Size(56, 31);
            Ag.TabIndex = 37;
            Ag.Text = "Age";
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(238, 585);
            button3.Name = "button3";
            button3.Size = new Size(209, 47);
            button3.TabIndex = 39;
            button3.Text = "View Passenger";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // AddPassenger
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 689);
            Controls.Add(button3);
            Controls.Add(Age);
            Controls.Add(Ag);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PassengerName);
            Controls.Add(Contact);
            Controls.Add(Cont);
            Controls.Add(Gender);
            Controls.Add(PassengerID);
            Controls.Add(PasseName);
            Controls.Add(Gend);
            Controls.Add(PassID);
            Controls.Add(label6);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddPassenger";
            Text = "AddPassenger";
            Load += AddPassenger_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void NewMethod()
        {
            PassengerID.TextChanged += textBox1_TextChanged;
        }

        #endregion

        private Label label6;
        private Label label1;
        private ComboBox Gender;
        private TextBox PassengerID;
        private Label PasseName;
        private Label Gend;
        private Label PassID;
        private TextBox Contact;
        private Label Cont;
        private TextBox PassengerName;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox Age;
        private Label Ag;
        private Button button3;

        public EventHandler textBox1_TextChanged { get; private set; }
    }
}