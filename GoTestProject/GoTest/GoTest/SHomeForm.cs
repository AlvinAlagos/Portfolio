using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoTest
{
    public partial class SHomeForm : Form
    {
        public SHomeForm()
        {
            InitializeComponent();
        }

        private void classButton_Click(object sender, EventArgs e)
        {
            SRegisterCourseForm course = new SRegisterCourseForm();
            this.Hide();
            course.ShowDialog();
            this.Close();
        }

        private void viewQuizButton_Click(object sender, EventArgs e)
        {
            SViewQuizForm quiz = new SViewQuizForm();
            this.Hide();
            quiz.ShowDialog();
            this.Close();
        }

        

        private void resultButton_Click(object sender, EventArgs e)
        {
            SResultsForm results = new SResultsForm();
            this.Hide();
            results.ShowDialog();
            this.Close();
        }
    }
}
