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
    public partial class SelectUser : Form
    {
        public SelectUser()
        {
            InitializeComponent();
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SLoginForm loginForm = new SLoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        private void teacherButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TLoginForm loginForm = new TLoginForm();    
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
