using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace EducationForm
{
    public partial class MasterCountry : Form
    {
        String Cstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

        SqlConnection con;
        SqlCommand cmd;

        public MasterCountry()
        {
            InitializeComponent();
        }

        private void AddCountry_Click(object sender, EventArgs e)
        {
            if (Country.Text != "")
            {
                //String query = "INSERT INTO eduCountry (CountryName) VALUES (@a)";
                con = new SqlConnection(Cstring);
                //cmd = new SqlCommand(query, con);
                cmd = new SqlCommand("InsertCountry", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@countryName", Country.Text);
                con.Open();
                int rowsAdded = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(rowsAdded.ToString() + " rows added.");
                GridLoad();
            }
            else
                MessageBox.Show("Please enter any Country Name.");
        }

        

        private void MasterCountry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet1.eduCountry' table. You can move, or remove it, as needed.
            this.eduCountryTableAdapter1.Fill(this.studentDataSet1.eduCountry);
            // TODO: This line of code loads data into the 'studentDataSet.eduCountry' table. You can move, or remove it, as needed.
            this.eduCountryTableAdapter.Fill(this.studentDataSet.eduCountry);

        }

        public void GridLoad()
        {
            string query = "SELECT * FROM eduCountry";
            con = new SqlConnection(Cstring);
            cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            GridLoad();
        }
    }
}
