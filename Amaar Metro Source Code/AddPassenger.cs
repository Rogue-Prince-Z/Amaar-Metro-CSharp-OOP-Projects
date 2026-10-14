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
    public partial class AddPassenger : Form
    {
        public AddPassenger()
        {
            InitializeComponent(GetPassengerID(), GetPassengerID());
        }

        SqlConnection Con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\AmarMetroDatabase.mdf;Integrated Security=True;Connect Timeout=30;Trust Server Certificate=True");
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddPassenger_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PassengerID.Text == "" || PassengerName.Text == "" || Gender.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
                try
                {
                    Con.Open();
                    String query = "Insert into Passenger values(" + PassengerID.Text + "," + PassengerName.Text + ",'" + Gender.SelectedItem.ToString() + ",'" + Contact.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Recorded Successfully");
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
            ViewPassenger viewpass = new ViewPassenger();
            viewpass.Show();
            this.Hide();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}