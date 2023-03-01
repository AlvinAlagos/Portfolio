using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoTest
{
    public partial class SNavigation : UserControl
    {
        public SNavigation()
        {
            InitializeComponent();
            User user = User.GetInstance();
            userLabel.Text = "User: " + user.FirstName + " " + user.LastName + "\nid: " + user.Id;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            SHomeForm home = new SHomeForm();
            ((Form)this.TopLevelControl).Hide();
            home.ShowDialog();
            ((Form)this.TopLevelControl).Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            SRegisterCourseForm register = new SRegisterCourseForm();
            ((Form)this.TopLevelControl).Hide();
            register.ShowDialog();
            ((Form)this.TopLevelControl).Close();
        }

        private void viewQuizButton_Click(object sender, EventArgs e)
        {
            SViewQuizForm view = new SViewQuizForm();
            ((Form)this.TopLevelControl).Hide();
            view.ShowDialog();
            ((Form)this.TopLevelControl).Close();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            SResultsForm results = new SResultsForm();
            ((Form)this.TopLevelControl).Hide();
            results.ShowDialog();
            ((Form)this.TopLevelControl).Close();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Connection connect = Connection.GetInstance();
            SqlConnection con = connect.GetConnection();
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);

            if (result == DialogResult.Yes)
            {
                con.Close();
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {

            }
        }
    }
}
