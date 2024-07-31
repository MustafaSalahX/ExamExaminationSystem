using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamExaminationSystem
{
    public class Answer
    {
        public Answer() { }
        public int ID { get; set; }
        public string AnswerText { get; set; }

        public Answer(int id, string Answer) {
            ID = id;
            Answer = AnswerText;
        }

        public override string ToString()
        {
            return $"{ID}.{AnswerText}";
        }
    }
}
