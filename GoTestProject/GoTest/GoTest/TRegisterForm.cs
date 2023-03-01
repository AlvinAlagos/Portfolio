using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace GoTest
{
    public partial class TRegisterForm : Form
    {
        
        public TRegisterForm()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            Connection connect = Connection.GetInstance();
                SqlConnection con = connect.GetConnection();
                SqlCommand insert = new SqlCommand("insert into TLogInfo values('" + userNameTextBox.Text + "','" + passwordTextBox.Text + "')", con);
                SqlCommand insertTeacher = new SqlCommand("insert into Teacher values('" + firstNameTextBox.Text + "','" + lastNameTextBox.Text + "','" + userNameTextBox.Text + "')", con);
                SqlCommand check = new SqlCommand("select TeacherUserName from TeacherLogInfo where TeacherUserName='" + userNameTextBox.Text + "'", con);

            try
            {
                

                if (userNameTextBox.Text.Equals(check))
                {
                    throw new Exception();

                }
                else
                {
                    if (string.IsNullOrEmpty(passwordTextBox.Text) || passwordTextBox.Text.Length < 5)
                    {
                        throw new ArgumentException();
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
                            insertTeacher.ExecuteNonQuery();
                            MessageBox.Show("Your account has been successfully created!");
                            this.Close();
                            con.Close();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                
                userNameTextBox.Clear();
                passwordTextBox.Clear();
                MessageBox.Show("User already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException p)
            {
                MessageBox.Show("Password Length must be greater than 5", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
          
        }
    }
}
