using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GoTest
{
    public partial class TNavigation : UserControl
    {
        public TNavigation()
        {
            InitializeComponent();
            User user = User.GetInstance();
            userLabel.Text = "User: " + user.FirstName +" "+ user.LastName+ "\nid: "+user.Id;
        }



      

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void homeButton_Click_1(object sender, EventArgs e)
        {
            THomeForm home = new THomeForm();
            ((Form)this.TopLevelControl).Hide();
            home.ShowDialog();
            ((Form)this.TopLevelControl).Close();
        }

        private void classButton_Click_2(object sender, EventArgs e)
        {
            TClassesForm classes = new TClassesForm();
            ((Form)this.TopLevelControl).Hide();
            classes.ShowDialog();
            ((Form)this.TopLevelControl).Close();
        }

        private void createButton_Click_1(object sender, EventArgs e)
        {
            TCreateQuiz create = new TCreateQuiz();
            ((Form)this.TopLevelControl).Hide();
            create.ShowDialog();
            ((Form)this.TopLevelControl).Close();
        }

        private void viewButton_Click_1(object sender, EventArgs e)
        {
            TViewQuiz view = new TViewQuiz();
            ((Form)this.TopLevelControl).Hide();
            view.ShowDialog();
            ((Form)this.TopLevelControl).Close();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Connection connect = Connection.GetInstance();
            SqlConnection con = connect.GetConnection();
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
            
            if(result == DialogResult.Yes)
            {
                con.Close();
                Application.Exit();
            } 
            else if(result == DialogResult.No)
            {

            }
        }
    }
}
