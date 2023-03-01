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
    public partial class TViewQuiz : Form
    {
        public TViewQuiz()
        {
            InitializeComponent();
        }

        private void TViewQuiz_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            try
            {
                User user = User.GetInstance();
                Connection connect = Connection.GetInstance();
                SqlConnection con = connect.GetConnection();
                SqlDataAdapter adapter = new SqlDataAdapter("select * FROM Quiz WHERE TeacherId='" + user.Id + "'", con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                studentsDataGridView.DataSource = table;
            
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Connection connect = Connection.GetInstance();
            SqlConnection con = connect.GetConnection();
            try
            {
                SqlCommand deleteQuiz = new SqlCommand("DELETE FROM Quiz WHERE QuizId=" + Convert.ToInt32(quizIdTextBox.Text) + " ", con);
                SqlCommand deleteResults = new SqlCommand("DELETE FROM Results WHERE QuizId=" + Convert.ToInt32(quizIdTextBox.Text) + " ", con);
                SqlCommand deleteMultipleChoice = new SqlCommand("DELETE FROM MultipleChoice WHERE QuizId=" + Convert.ToInt32(quizIdTextBox.Text) + " ", con);

                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM Quiz WHERE QuizId="+quizIdTextBox.Text+"", con);
                DataTable dtableQuiz = new DataTable();
                sda1.Fill(dtableQuiz);
   
                if (dtableQuiz.Rows.Count > 0)
                {
                        deleteMultipleChoice.ExecuteNonQuery();
                        deleteResults.ExecuteNonQuery();
                        deleteQuiz.ExecuteNonQuery();
                        MessageBox.Show("The quiz has been successfully removed!","Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                 
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Id does not match any in the database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void resultsButton_Click(object sender, EventArgs e)
        {
            try
            {
                User user = User.GetInstance();
                Connection connect = Connection.GetInstance();
                SqlConnection con = connect.GetConnection();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT r.QuizId, Result, r.StudentId, c.CourseId FROM Results r, Course c WHERE c.TeacherId ="+user.Id+"", con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                studentsDataGridView.DataSource = table;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
