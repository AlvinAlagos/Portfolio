using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTest
{
    class Quiz
    {
        public String QuizId { get; set; }
        public String Title { get; set; }
        public int NumOfQuestions { get; set; } 
        public int CurrentNumber { get; set; }

        public int correctAnswers { get; set; }

        private static Quiz quiz;

        private Quiz()
        {

        }
        public static Quiz GetInstance()
        {
            if (quiz == null)
            {
                quiz = new Quiz();
            }
            return quiz;
        }

    }
}
