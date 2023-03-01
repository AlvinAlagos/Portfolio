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
    public partial class TCreateQuiz : Form
    {
        private String choice1;
        private String choice2;
        private String choice3;
        private String choice4;
        private String answer;
        Quiz quiz = Quiz.GetInstance();

        DataSet set = new DataSet();
        public TCreateQuiz()
        {
            InitializeComponent();
            quiz.CurrentNumber = 1;
            questionNumberLabel.Text = "Question " + quiz.CurrentNumber;
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
           
            Connection connect = Connection.GetInstance();
            SqlConnection con = connect.GetConnection();

          

            if (string.IsNullOrEmpty(choiceTextBox1.Text) || string.IsNullOrEmpty(choiceTextBox2.Text))
            {
                MessageBox.Show("Default: Choice 1 and 2 must be filled in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!string.IsNullOrEmpty(choiceTextBox1.Text) && !string.IsNullOrEmpty(choiceTextBox2.Text))
            {
                choice1 = choiceTextBox1.Text;
                choice2 = choiceTextBox2.Text;
            }

            if (string.IsNullOrEmpty(choiceTextBox3.Text))
            {
                choice3 = null;
            }
            else if (!string.IsNullOrEmpty(choiceTextBox3.Text))
            {
                choice3 = choiceTextBox3.Text;
            }

            if (string.IsNullOrEmpty(choiceTextBox4.Text))
            {
                choice4 = null;
            }
            else if (!string.IsNullOrEmpty(choiceTextBox4.Text))
            {
                choice4 = choiceTextBox4.Text;
            }

            if (string.IsNullOrEmpty(answerTextBox.Text))
            {
                MessageBox.Show("Answer must be filled");
            }
            else if (!string.IsNullOrEmpty(answerTextBox.Text))
            {
                answer = answerTextBox.Text;
            }

            try
            {
                if (!String.IsNullOrEmpty(questionTextbox.Text))
                {

                    if (!String.IsNullOrEmpty(answerTextBox.Text))
                    {
                        if (quiz.CurrentNumber < quiz.NumOfQuestions)
                        {
                         
                            SqlCommand insert = new SqlCommand("insert into MultipleChoice values('" + questionTextbox.Text + "','" + choice1 + "','" + choice2 + "','" + choice3 + "','" + choice4 + "','" + answer + "','" + quiz.QuizId + "')", con);
                            insert.ExecuteNonQuery();
                            RefreshPage();
                            quiz.CurrentNumber++;
                            questionNumberLabel.Text = "Question " + quiz.CurrentNumber;
                        }
                        else if (quiz.CurrentNumber == quiz.NumOfQuestions)
                        {
                            
                            SqlCommand insert = new SqlCommand("insert into MultipleChoice values('" + questionTextbox.Text + "','" + choice1 + "','" + choice2 + "','" + choice3 + "','" + choice4 + "','" + answer + "','" + quiz.QuizId + "')", con);
                            insert.ExecuteNonQuery();
                            MessageBox.Show("Quiz has been filled successfuly!", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            THomeForm home = new THomeForm();
                            this.Hide();
                            home.ShowDialog();
                            this.Close();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Answer Box must be filled in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Question Box must be filled in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void removeChoice3Button_Click(object sender, EventArgs e)
        {
            choiceTextBox3.Clear();
            choiceLabel3.Visible = false;
            choiceTextBox3.Visible = false;
            cLabel.Visible = false;
            removeChoice3Button.Visible = false;

        }

        private void removeChoice4Button_Click(object sender, EventArgs e)
        {
            choiceTextBox4.Clear();
            choiceLabel4.Visible = false;
            dLabel.Visible = false;
            choiceTextBox4.Visible = false;
            removeChoice4Button.Visible = false;
        }

        public void RefreshPage()
        {
            questionTextbox.Clear();
            choiceTextBox1.Clear();
            choiceTextBox2.Clear();
            choiceTextBox3.Clear();
            choiceLabel3.Visible = true;
            choiceTextBox3.Visible = true;
            cLabel.Visible = true;
            removeChoice3Button.Visible = true;
            choiceTextBox4.Clear();
            choiceLabel4.Visible = true;
            dLabel.Visible = true;
            choiceTextBox4.Visible = true;
            removeChoice4Button.Visible = true;
            answerTextBox.Clear();
        }

        private void createQuizPage1_Load(object sender, EventArgs e)
        {

        }

        private void TCreateQuiz_Load(object sender, EventArgs e)
        {

        }
    }
}
