using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamExaminationSystem
{
    public abstract class MCQ : Question
    {
        int RightValidAnswerchooser;
        public MCQ()
        {
        }
        //This Impelemntation Should Not Be here !!
        public override string Header { get => "MCQ Questions"; }
        //public override string Body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public override string Mark { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void QuestionAdder()
        {
            Console.WriteLine(Header);
            Console.WriteLine("Question Adding Utility \n Enter Your Question To Be Added");
            Body = Console.ReadLine() ?? "No Data Registerd ";
            int mark;
            do { Console.WriteLine("Making System \n Mark Your Question"); } while (int.TryParse(Console.ReadLine(), out mark)); //Store The Mark For The Question Needed !
            Mark = mark;

            Console.WriteLine("Choices Adder \n Add Your 4 Choices One By One !!!");
            AnswersList = new Answer[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Enter Your {i + 1} Choice Number :");
                AnswersList[i] = new Answer(i + 1, Console.ReadLine() ?? "Wrong Input ReType Your Choice Again !"); //To Avoid  Wrong Input !!
            }

            do
            {
                Console.WriteLine("Enter A Vaild Answer From [1 To 4 ]");

            } while (!int.TryParse(Console.ReadLine(), out RightValidAnswerchooser) && (RightValidAnswerchooser < 1 || RightValidAnswerchooser > 4));
            //RISTRICT INPUT FROM USER TO ONLY 4 ANSWERS !!
            RightAnswer = new Answer(AnswersList[RightValidAnswerchooser - 1].ID, AnswersList[RightValidAnswerchooser - 1].AnswerText);
            //RightAnswer = new Answer(AnswersList[RightValidAnswerchooser - 1]).AnswerText;
        }
    }
}
