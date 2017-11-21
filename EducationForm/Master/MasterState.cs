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
    public partial class MasterState : Form
    {
        String Cstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        SqlConnection con;

        bool ValidateInput()
        {
            if (ddlCountry.Text == "-----Select Country-----")
            {
                MessageBox.Show("Please select any Country.");
                return false;
            }
            if (txtState.Text == "")
            {
                MessageBox.Show("Please enter state name.");
                return false;
            }
            return true;
        }
        public MasterState()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddState_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            SqlCommand cmd,cmd2;
            con = new SqlConnection(Cstring);
            //String query = "INSERT INTO eduState (StateName) VALUES (@a)";
            con.Open();
            cmd = new SqlCommand("InsertState",con);
            //cmd.Parameters.AddWithValue("@a",
            cmd.CommandType = CommandType.StoredProcedure;

            string query = "Select CountryID from eduCountry where CountryName = '" + ddlCountry.SelectedValue + "'";
            cmd2 = new SqlCommand(query, con);
            int id = Convert.ToInt32(cmd2.ExecuteScalar());

            cmd.Parameters.AddWithValue("@CountryId", id);
            cmd.Parameters.AddWithValue("@StateName", txtState.Text);
            int rowsAdded = cmd.ExecuteNonQuery();
            MessageBox.Show(rowsAdded + " rows added.");
        }

        private void MasterState_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet2.eduCountry' table. You can move, or remove it, as needed.
            this.eduCountryTableAdapter.Fill(this.studentDataSet2.eduCountry);
            ddlCountry.Text = "-----Select Country-----";
        }
       
    }
}
