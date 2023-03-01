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
    public partial class THomeForm : Form
    {
        public THomeForm()
        {
            InitializeComponent();
        }

        private void THomeForm_Load(object sender, EventArgs e)
        {

        }


        private void classButton_Click(object sender, EventArgs e)
        {
            TClassesForm frm = new TClassesForm();
            frm.ShowDialog();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            TCreateQuiz form = new TCreateQuiz(); 
            form.ShowDialog();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            TViewQuiz viewQuiz =   new TViewQuiz();
            viewQuiz.ShowDialog();  
        }
    }
}
