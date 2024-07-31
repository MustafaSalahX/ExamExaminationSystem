using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamExaminationSystem
{
    public abstract class TrueFalseClass : Question 
    {
        int RightValidAnswerchooser;
        public override string Header => "True OR False Questions !";

        public override string Body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override float Mark { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public TrueFalseClass() {
            AnswersList = new Answer[2]{new Answer(1,"True"),new Answer(2,"False")}; // We CreateD A Default Answers In Our Class Constructor To Choose From Them !!
        }

        public override void QuestionAdder()
        {
            Console.WriteLine(Header);
            Console.WriteLine("Question Adding Utility \n Enter Your Question To Be Added");
            Body = Console.ReadLine() ?? "No Data Registerd ";
            int mark;
            do { Console.WriteLine("Making System \n Mark Your Question"); } while (int.TryParse(Console.ReadLine(), out mark)); //Store The Mark For The Question Needed !
            Mark = mark;
            // We CreateD A Default Answers In Our Class Constructor To Choose From Them !!
           
            do
            {
                Console.WriteLine("Enter A Vaild Answer True = [1] OR False = [2] ");

            } while (!int.TryParse(Console.ReadLine(), out RightValidAnswerchooser) && (RightValidAnswerchooser < 1 || RightValidAnswerchooser > 2));
            //RISTRICT INPUT FROM USER TO ONLY 2 ANSWERS True OR False !!
            RightAnswer = new Answer(AnswersList[RightValidAnswerchooser - 1].ID, AnswersList[RightValidAnswerchooser - 1].AnswerText); //RemoveFromStack..
            //RightAnswer = new Answer(AnswersList[RightValidAnswerchooser - 1]).AnswerText;
        }
    }
}
