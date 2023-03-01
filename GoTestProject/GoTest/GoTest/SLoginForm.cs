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
    public partial class SLoginForm : Form
    {
        public SLoginForm()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            Connection connect = Connection.GetInstance();
            SqlConnection con = connect.GetConnection();

            con.Open();
            String id = studentIdTextBox.Text;
            String password = passwordTextBox.Text;


            String query = "select * from Student where StudentId = '" + id + "' and Password = '" + password + "'";
            String queryStudentId = "select StudentId from Student where StudentId = '" + id + "'";
            String queryStudentFirstN = "select FirstName from Student where StudentId = '" + id + "'";
            String queryStudentLastN = "select LastName from Student where StudentId = '" + id + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommand cmd = new SqlCommand(queryStudentId, con);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            try
            {
                if (dtable.Rows.Count > 0)
                {
                    this.Hide();
                    User user = User.GetInstance();
                    user.Id = (int)cmd.ExecuteScalar();

                    cmd = new SqlCommand(queryStudentFirstN, con);
                    user.FirstName = (String)cmd.ExecuteScalar();

                    cmd = new SqlCommand(queryStudentLastN, con);
                    user.LastName = (String)cmd.ExecuteScalar();
                    SHomeForm home = new SHomeForm();
                    home.ShowDialog();
                    this.Close();
                    con.Close();
                }
                else
                {
                    studentIdTextBox.Clear();
                    passwordTextBox.Clear();
                    errorLabel.Text = "*Incorrect username or password ";
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Incorrect Format for StudentId", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SRegisterForm register = new SRegisterForm();
            register.ShowDialog();
        }
    }
}
