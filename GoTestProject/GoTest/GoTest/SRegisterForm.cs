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
    public partial class SRegisterForm : Form
    {
        public SRegisterForm()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            Connection connect = Connection.GetInstance();
            SqlConnection con = connect.GetConnection();
            SqlCommand insert = new SqlCommand("insert into Student values('" + firstNameTextBox.Text + "','" + lastNameTextBox.Text + "','"+passwordTextBox.Text+"')", con);
            SqlCommand selectId = new SqlCommand("select StudentId from Student where FirstName = '" + firstNameTextBox.Text + "' AND LastName='" + lastNameTextBox.Text + "'", con);
       


            try
            {
               
                    if (string.IsNullOrEmpty(passwordTextBox.Text) || passwordTextBox.Text.Length < 5)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        if (!confirmPassTextBox.Text.Equals(passwordTextBox.Text))
                        {
                            errorLabel.Text = "*Passwords do not match";
                            confirmPassTextBox.Clear();
                        }
                        else
                        {
                        con.Open();
                            insert.ExecuteNonQuery();
                            int id = (int)selectId.ExecuteScalar();
                            MessageBox.Show("Your account has been successfully created! \nThis is your new StudentId keept it safe: " + id);
                            this.Close();
                        con.Close();
                        }
                    }
                
            }

            catch (Exception p)
            {
                 MessageBox.Show("Password Length must be greater than 5", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            }
        }
    }
}
