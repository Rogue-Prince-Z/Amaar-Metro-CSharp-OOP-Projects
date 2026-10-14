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
    public partial class ViewSchedule : Form
    {
        public ViewSchedule()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=ZARIF-51384\SQLEXPRESS;Initial Catalog=AmarMetroDB;Integrated Security=True;Trust Server Certificate=True");

        private void populate()
        {
            Con.Open();

            string query = "select * from Schedule";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ScheduleDGV.DataSource = ds.Tables[0];

            Con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ViewSchedule_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MetroSchedule metroSchedule = new MetroSchedule();
            metroSchedule.Show();
            this.Hide();
        }

        private void ScheduleDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
