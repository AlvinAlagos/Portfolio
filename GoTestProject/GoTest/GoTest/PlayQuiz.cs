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
    public partial class PlayQuiz : UserControl
    {
        int questionId = 0;
        public PlayQuiz()
        {
            InitializeComponent();

            
        }

        

        private void enterButton_Click(object sender, EventArgs e)
        {
            Quiz quiz = Quiz.GetInstance();
            Connection connect = Connection.GetInstance();
            SqlConnection con = connect.GetConnection();
            SqlCommand selectAns = new SqlCommand("select Answer from MultipleChoice where id=" + (questionId - 1) +"", con);

            if (answerTextBox.Text.Equals((String)selectAns.ExecuteScalar()))
            {
                quiz.correctAnswers++;
                answerTextBox.Clear();
                
            }
            else if (!answerTextBox.Text.Equals((String)selectAns.ExecuteScalar()))
            {
                answerTextBox.Clear();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            
            Quiz quiz = Quiz.GetInstance();
            Connection connect = Connection.GetInstance();
            SqlConnection con = connect.GetConnection();
            SqlCommand selectTop = new SqlCommand("select TOP 1 id from MultipleChoice where QuizId='" + quiz.QuizId + "'", con);
            questionId = (int)selectTop.ExecuteScalar();

            SqlCommand selectQuestion = new SqlCommand("select Question from MultipleChoice where id=" + questionId + "", con);
            SqlCommand choiceA = new SqlCommand("select Choice1 from MultipleChoice where id=" + questionId + "", con);
            SqlCommand choiceB = new SqlCommand("select Choice2 from MultipleChoice where id=" + questionId + "", con);
            SqlCommand choiceC = new SqlCommand("select Choice3 from MultipleChoice where id=" + questionId + "", con);
            SqlCommand choiceD = new SqlCommand("select Choice4 from MultipleChoice where id=" + questionId + "", con);

       

                try
                {
                    numLabel.Text = "Question " + quiz.CurrentNumber;
                    currentQuestionLabel.Text = quiz.CurrentNumber + "/" + quiz.NumOfQuestions;
                    questionNumLabel.Text = (String)selectQuestion.ExecuteScalar();
                    aLabel.Text = "a)" + (String)choiceA.ExecuteScalar();
                    bLabel.Text = "b)" + (String)choiceB.ExecuteScalar();

                    if (String.IsNullOrEmpty((String)choiceC.ExecuteScalar()))
                    {
                        cLabel.Visible = false;
                    }
                    else if (!String.IsNullOrEmpty((String)choiceC.ExecuteScalar()))
                    {
                        cLabel.Visible = true;
                        cLabel.Text = "c)" + (String)choiceC.ExecuteScalar();
                    }

                    if (String.IsNullOrEmpty((String)choiceD.ExecuteScalar()))
                    {
                        dLabel.Visible = false;
                    }
                    else if (!String.IsNullOrEmpty((String)choiceD.ExecuteScalar()))
                    {
                        dLabel.Visible = true;
                        dLabel.Text = "d)" + (String)choiceC.ExecuteScalar();
                    }
                    nextButton.Visible = true;
                    startButton.Visible = false;
                    quiz.CurrentNumber++;
                    questionId++;
            }
                catch (Exception ex)
                {

                }
            
       

        }

        private void nextButton_Click(object sender, EventArgs e)
        {

            Quiz quiz = Quiz.GetInstance();
            Connection connect = Connection.GetInstance();
            SqlConnection con = connect.GetConnection();
            

            SqlCommand selectQuestion = new SqlCommand("select Question from MultipleChoice where id=" + questionId + "", con);
            SqlCommand choiceA = new SqlCommand("select Choice1 from MultipleChoice where id=" + questionId + "", con);
            SqlCommand choiceB = new SqlCommand("select Choice2 from MultipleChoice where id=" + questionId + "", con);
            SqlCommand choiceC = new SqlCommand("select Choice3 from MultipleChoice where id=" + questionId + "", con);
            SqlCommand choiceD = new SqlCommand("select Choice4 from MultipleChoice where id=" + questionId + "", con);

            if (quiz.CurrentNumber <= quiz.NumOfQuestions)
            {
               
                    try
                    {
                        numLabel.Text = "Question " + quiz.CurrentNumber;
                        currentQuestionLabel.Text = quiz.CurrentNumber + "/" + quiz.NumOfQuestions;
                        questionNumLabel.Text = (String)selectQuestion.ExecuteScalar();
                        aLabel.Text = "a)" + (String)choiceA.ExecuteScalar();
                        bLabel.Text = "b)" + (String)choiceB.ExecuteScalar();

                        if (String.IsNullOrEmpty((String)choiceC.ExecuteScalar()))
                        {
                            cLabel.Visible = false;
                        }
                        else if (!String.IsNullOrEmpty((String)choiceC.ExecuteScalar()))
                        {
                            cLabel.Visible = true;
                            cLabel.Text = "c)" + (String)choiceC.ExecuteScalar();
                        }

                        if (String.IsNullOrEmpty((String)choiceD.ExecuteScalar()))
                        {
                            dLabel.Visible = false;
                        }
                        else if (!String.IsNullOrEmpty((String)choiceD.ExecuteScalar()))
                        {
                            dLabel.Visible = true;
                            dLabel.Text = "d)" + (String)choiceD.ExecuteScalar();
                        }
                        quiz.CurrentNumber++;
                        questionId++;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                

            }
            else if (quiz.CurrentNumber > quiz.NumOfQuestions)
            {
                User user = User.GetInstance();

                SqlCommand insert = new SqlCommand("insert into Results values(" + user.Id + ",'" + quiz.correctAnswers + "/" + quiz.NumOfQuestions + "'," + quiz.QuizId + ")", con);
                insert.ExecuteNonQuery();
                MessageBox.Show("You have reached the end of the quiz!", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }
    }
}
