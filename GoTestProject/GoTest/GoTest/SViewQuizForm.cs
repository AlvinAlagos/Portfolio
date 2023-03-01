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
    public partial class SViewQuizForm : Form
    {
       
        public SViewQuizForm()
        {
            InitializeComponent();
            try
            {
                Connection connect = Connection.GetInstance();
                SqlConnection con = connect.GetConnection();
                SqlDataAdapter adapter = new SqlDataAdapter("select QuizId, Title from Quiz", con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                quizDataGridView.DataSource = table;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            try
            {
                User user = User.GetInstance();
                Connection connect = Connection.GetInstance();
                SqlConnection con = connect.GetConnection();
                SqlCommand check = new SqlCommand("select Title from Quiz where QuizId=" + quizTextBox.Text + "", con);
                SqlCommand selectQuizId = new SqlCommand("select QuizId from Quiz where QuizId=" + quizTextBox.Text + "", con);
                SqlCommand numOfQuestions = new SqlCommand("select NumberOfQuestions from Quiz where QuizId="+quizTextBox.Text+"", con);
                SqlCommand checkResults = new SqlCommand("select * from Results where StudentId=" + user.Id + " AND QuizId=" + quizTextBox.Text + "",con);
                SqlDataAdapter adapter = new SqlDataAdapter(check);
                SqlDataAdapter resultsAdapter = new SqlDataAdapter(checkResults);
                DataSet set = new DataSet();
                DataSet resultSet = new DataSet();

                adapter.Fill(set);
                resultsAdapter.Fill(resultSet); 
                int rows = set.Tables[0].Rows.Count;
                int resultsRows = resultSet.Tables[0].Rows.Count;
                if (resultsRows == 0)
                {

                    if (rows > 0)
                    {
                        Quiz quiz = Quiz.GetInstance();
                        quiz.QuizId = Convert.ToString((int)selectQuizId.ExecuteScalar());
                        quiz.Title = quizTextBox.Text;
                        quiz.CurrentNumber = 1;
                        quiz.NumOfQuestions = (int)numOfQuestions.ExecuteScalar();
                        quizTextBox.Clear();
                        playQuiz.Visible = true;
                        viewLabel.Visible = false;

                    }
                    else if (rows == 0)
                    {
                        throw new Exception();
                    }
                }
                else if(resultsRows > 0)
                {
                    MessageBox.Show("You have already taken this quiz!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Incorrect quizId inputted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SViewQuizForm_Load(object sender, EventArgs e)
        {

        }
    }
}
