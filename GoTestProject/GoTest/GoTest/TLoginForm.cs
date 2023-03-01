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
    public partial class TLoginForm : Form
    {
        public TLoginForm()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            Connection connect = Connection.GetInstance();
            SqlConnection con = connect.GetConnection();

            con.Open();
            String userName = userNameTextBox.Text;
            String password = passwordTextBox.Text;


            String query = "select * from TLogInfo where TeacherUserName = '" + userName + "' and TeacherPassWord = '" + password + "'";
            String queryTeacherId = "select TeacherId from Teacher where TeacherUserName = '" + userName + "'";
            String queryTeacherFirstN = "select FirstName from Teacher where TeacherUserName = '" + userName + "'";
            String queryTeacherLastN = "select LastName from Teacher where TeacherUserName = '" + userName + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommand cmd = new SqlCommand(queryTeacherId, con);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                this.Hide();
                User user = User.GetInstance();
                user.Id = (int)cmd.ExecuteScalar();

                cmd = new SqlCommand(queryTeacherFirstN, con);
                user.FirstName = (String)cmd.ExecuteScalar();

                cmd = new SqlCommand(queryTeacherLastN, con);
                user.LastName = (String)cmd.ExecuteScalar();

                THomeForm main = new THomeForm();

                main.ShowDialog();
                this.Close();
                
            }
            else
            {
                userNameTextBox.Clear();
                passwordTextBox.Clear();
                errorLabel.Text = "*Incorrect username or password ";
                con.Close();
            }
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TRegisterForm register = new TRegisterForm();
            register.ShowDialog();
        }
    }
}
