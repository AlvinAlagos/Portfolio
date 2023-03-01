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
    public partial class CreateQuizPage : UserControl
    {
        DataSet set = new DataSet();
        public CreateQuizPage()
        {
            InitializeComponent();
        }

        private void createQuiz_Click(object sender, EventArgs e)
        {

            Connection connect = Connection.GetInstance();
            SqlConnection con = connect.GetConnection();
            try
            {

                
                SqlCommand insert = new SqlCommand("insert into Quiz values('" + quizNameTextBox.Text + "','" + courseTextBox.Text + "','" + int.Parse(teacherIdTextBox.Text) + "','" + numOfQuestionsNumericeUpdown.Value + "')", con);
                SqlCommand check = new SqlCommand("select CourseId from Course where CourseId='" + courseTextBox.Text + "'", con);
                SqlCommand selectQuizId = new SqlCommand("select QuizId from Quiz where Title='" + quizNameTextBox.Text + "'", con);
                SqlCommand selectTitle = new SqlCommand("select Title from Quiz where Title='" + quizNameTextBox.Text + "'", con);
                SqlDataAdapter adapter = new SqlDataAdapter(check);
                adapter.Fill(set);
                int i = set.Tables[0].Rows.Count;
               
                if (i > 0)
                {
                    
                    insert.ExecuteNonQuery();


                    Quiz quiz = Quiz.GetInstance();


                    quiz.QuizId = Convert.ToString((int)selectQuizId.ExecuteScalar());
                    quiz.Title = (string)selectTitle.ExecuteScalar();
                    quiz.NumOfQuestions = Decimal.ToInt32(numOfQuestionsNumericeUpdown.Value);
                    quiz.CurrentNumber = 1;
                    this.Visible = false;


                 
                }
                else if (i == 0)
                {
                    
                    throw new Exception();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Criteria Was not filled in properly. Please Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show(ex.Message);
                TCreateQuiz create = new TCreateQuiz();
                ((Form)TopLevelControl).Hide();
                create.ShowDialog();
                ((Form)TopLevelControl).Close();
            }
            
        }

   
    }
}
