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
    public partial class ViewPassenger : Form
    {
        public ViewPassenger()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=ZARIF-51384\SQLEXPRESS;Initial Catalog=AmarMetroDB;Integrated Security=True;Trust Server Certificate=True");

        private void populate()
        {
            Con.Open();

            string query = "select * from Passenger2";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PassengerDGV.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void ViewPassenger_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PidTb.Text = "";
            PnameTb.Text = "";
            PcontTb.Text = "";
            PgendCb.Text = "";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddPassenger addpass = new AddPassenger();
            addpass.Show();
            this.Hide();
        }

        private void PassengerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PidTb.Text = PassengerDGV.SelectedRows[0].Cells[0].Value.ToString();
            PnameTb.Text = PassengerDGV.SelectedRows[0].Cells[1].Value.ToString();
            PcontTb.Text = PassengerDGV.SelectedRows[0].Cells[2].Value.ToString();
            PgendCb.Text = PassengerDGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PidTb.Text == "")
            {
                MessageBox.Show("Enter The Passenger to Delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from Passenger2 where PassengerID= " + PidTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Deleted Successfully ");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PidTb.Text == " " || PnameTb.Text == " " || PcontTb.Text == " " || PgendCb.Text ==" ")
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
                try
                {
                    Con.Open();
                    String query = "Update Passenger3 set PassengerName = " + PnameTb.Text + ", Gender = " + PgendCb.Text + ", Contact = " + PcontTb.Text + "' where PassengerID = " +PidTb.Text+ " )";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully");
                    Con.Close();
                    populate();

                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Missing Information");
                }
            }
        }
    }
}
