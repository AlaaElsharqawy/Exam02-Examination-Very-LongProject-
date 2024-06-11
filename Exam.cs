using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exam02__Examination_very_long_Project_
{
  

        public abstract class Exam
        {
            public DateTime TimeOfExam { get; set; }
            public int NumberOfQuestions { get; set; }
            public Subject ExamSubject { get; set; }

            public Exam(DateTime timeOfExam, int numberOfQuestions, Subject examSubject)
            {
                TimeOfExam = timeOfExam;
                NumberOfQuestions = numberOfQuestions;
                ExamSubject = examSubject;
            }

            public abstract void ShowExam();
        }


        }
    

