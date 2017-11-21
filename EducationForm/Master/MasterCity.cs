using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace EducationForm
{
    public partial class MasterCity : Form
    {
        String CString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        SqlConnection con;
        SqlCommand cmd,cmd2;

        bool ValidateInput()
        {
            if (txtCity.Text == "")
            {
                MessageBox.Show("Please enter city name");
                txtCity.Focus();
                return false;
            }
            string val = Convert.ToString(ddlState.Text);
            if (val == Convert.ToString("-----Select State-----"))
            {
                MessageBox.Show("Please Select any State.");
                ddlState.Focus();
                return false;
            }
            return true;
        }

        public MasterCity()
        {
            InitializeComponent();
        }

        private void AddCity_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;
            con = new SqlConnection(CString);
            con.Open();
            
            cmd = new SqlCommand("InsertCity", con);
            cmd.CommandType = CommandType.StoredProcedure;

            string query = "Select StateID from eduState where StateName = '" + ddlState.SelectedValue + "'";
            cmd2 = new SqlCommand(query, con);
            int id = Convert.ToInt32(cmd2.ExecuteScalar());

            cmd.Parameters.AddWithValue("@cityName", txtCity.Text);
            cmd.Parameters.AddWithValue("@stateId", id);
            int rowsAdded = cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(rowsAdded + " rows added.");
        }

        private void MasterCity_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet4.eduState' table. You can move, or remove it, as needed.
            this.eduStateTableAdapter.Fill(this.studentDataSet4.eduState);
            ddlState.Text = "-----Select State-----";

        }
    }
}
