using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamExaminationSystem
{
    public class PracticalExam : Exam
    {
        int inputAnswer;
        public PracticalExam(int time, int numofQuestions) : base(time, numofQuestions)
        {
        }

        public override void CreateListOFQuestions()
        {
            ListOfQuestions = new MCQ[NumOfQuestions];
            for(int i=0;i<ListOfQuestions?.Length;i++) {
                ListOfQuestions[i].QuestionAdder();
                Console.Clear(); //Took Me Half AN Hour To DO !
            }

        }

        public override void ExamViewer()
        {
            foreach (var Question in ListOfQuestions) {
                Console.WriteLine(Question.ToString());
                foreach (var Answer in Question.AnswersList)
                {
                    Console.WriteLine(Answer.ToString());
                }
                do
                {
                    Console.WriteLine("Input Utilty \n Type Your Answer : ");
                } while (!int.TryParse(Console.ReadLine(), out inputAnswer) && inputAnswer < 1 || inputAnswer > 4);
                Question.InputedAnswer = new Answer(inputAnswer - 1, Question.AnswersList[inputAnswer - 1].AnswerText);//RemoveFromStack..AndSet TheInputedAnswer with the corrct Value 
                //Double Check For This Funtion Its too hard and ask the menitor for inhansments !
            }
            Console.Clear(); //Clear Out The Screen .. Continue The Fun() Below !
            Console.WriteLine("Check Answer Utilty \n ");
            foreach (var Question in ListOfQuestions) {
                Console.WriteLine($"Q{NumOfQuestions-1}-{Question.Body}CORRECT Answer IS :{Question.RightAnswer.AnswerText}");
            }

        }
    }
}
