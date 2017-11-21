using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EducationForm.Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet18.StudentInfo' table. You can move, or remove it, as needed.
            this.studentInfoTableAdapter.Fill(this.studentDataSet18.StudentInfo);
            // TODO: This line of code loads data into the 'studentDataSet17.StudentDetail' table. You can move, or remove it, as needed.
            this.studentDetailTableAdapter.Fill(this.studentDataSet17.StudentDetail);

        }
    }
}
