using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EducationForm
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void schoolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterSchool ms = new MasterSchool();
            ms.ShowDialog();
        }

        private void collegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterCollege mc = new MasterCollege();
            mc.ShowDialog();
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterCourse msc = new MasterCourse();
            msc.ShowDialog();
        }

        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterCountry MC = new MasterCountry();
            MC.ShowDialog();
        }

        private void stateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterState ms = new MasterState();
            ms.ShowDialog();
        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterCity city = new MasterCity();
            city.ShowDialog();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentInfo st = new StudentInfo();
            st.ShowDialog();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment pt = new Payment();
            pt.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listOfStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentDetails sd = new StudentDetails();
            sd.ShowDialog();
        }

        private void studentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentList sl = new StudentList();
            sl.ShowDialog();
        }

        private void sampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student.Form1 form1 = new Student.Form1();
            form1.ShowDialog();
        }

       

        
    }
}
