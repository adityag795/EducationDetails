using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace EducationForm.Reports
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
            //ReportDocument Report = new ReportDocument();
            //Report.Load(Microsoft.SqlServer.Server.MapPath("~/EmployeeData.rpt"));
            //Report.SetDatabaseLogon("sa", "sa123", "Rakesh-PC", "RakeshData");
            //reportViewer1.ReportSource = Report; 
        }
    }
}
