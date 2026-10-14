using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Amaar_Metro_Project
{
    public partial class MetroSchedule : Form
    {
        public MetroSchedule()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=zarif-51384\sqlexpress;Initial Catalog=AmarMetroDB;Integrated Security=True;Trust Server Certificate=True");

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (McodeTb.Text == "" || Msrc.Text == "" || Mdest.Text == "" || Mdate.Text == "" || Mcap.Text == "")
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
                try
                {
                    Con.Open();
                    String query = "Insert into Schedule values('" + McodeTb.Text + "','" + Msrc.SelectedItem.ToString() + ",'" + Mdest.SelectedItem.ToString() + ",'" + Mdate.Value.ToString() + ",'" + Mcap.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Recorded Successfully");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewSchedule viewSchedule = new ViewSchedule();
            viewSchedule.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            McodeTb.Text = "";
            Mcap.Text = " ";
        }
    }
}
