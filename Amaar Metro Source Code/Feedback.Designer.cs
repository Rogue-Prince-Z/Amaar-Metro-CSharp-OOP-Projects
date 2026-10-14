namespace Amaar_Metro_Project
{
    partial class Feedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Feedback));
            label6 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.System;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(269, 71);
            label6.Name = "label6";
            label6.Size = new Size(114, 31);
            label6.TabIndex = 13;
            label6.Text = "Feedback";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(171, 9);
            label1.Name = "label1";
            label1.Size = new Size(347, 62);
            label1.TabIndex = 12;
            label1.Text = "AMAR METRO";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Red;
            textBox1.Location = new Point(207, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 34);
            textBox1.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(12, 149);
            label2.Name = "label2";
            label2.Size = new Size(147, 31);
            label2.TabIndex = 25;
            label2.Text = "Passenger Id";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Red;
            textBox2.Location = new Point(207, 193);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 34);
            textBox2.TabIndex = 28;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.System;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(12, 196);
            label3.Name = "label3";
            label3.Size = new Size(189, 31);
            label3.TabIndex = 27;
            label3.Text = "Passenger Name";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Snow;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.Red;
            textBox3.Location = new Point(12, 361);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(356, 34);
            textBox3.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.System;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(12, 311);
            label4.Name = "label4";
            label4.Size = new Size(165, 31);
            label4.TabIndex = 29;
            label4.Text = "Complain Box";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.System;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(12, 253);
            label5.Name = "label5";
            label5.Size = new Size(253, 31);
            label5.TabIndex = 31;
            label5.Text = "Rate Your Experipence";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(427, 146);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 249);
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // Feedback
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(699, 595);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Feedback";
            Text = "Feedback";
            Load += Feedback_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
    }
}