using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamExaminationSystem
{
    public abstract class Question
    {
        //Question Class Define The Class Diagram -- Check For Chaining 
        public abstract string Header { get; } 
        public abstract string Body { get; set; }
        public abstract float Mark { get; set; }
        public Answer[] AnswersList{ get; set; }
        public Answer RightAnswer { get; set; }
        public Answer InputedAnswer { get; set; }

        public Question() {
            //check for This Again
            RightAnswer = new Answer();
            InputedAnswer = new Answer();
        }
        public abstract void QuestionAdder();
        public override string ToString()
        {
            return $"{Header} {Mark} \n {Body}";
        }

    }
}
