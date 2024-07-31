using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExamExaminationSystem
{
    public abstract class Exam
    {
        public int Time {  get; set; }
        public  int NumOfQuestions { get; set; }
        public Question[] ListOfQuestions { get; set; }
        public Exam(int time, int numofQuestions) {
            Time = time;
            NumOfQuestions = numofQuestions;
             ListOfQuestions = new Question[NumOfQuestions];
            

        }
        public Exam() { }
        public abstract void CreateListOFQuestions();
        public abstract void ExamViewer();
    }
    
}
