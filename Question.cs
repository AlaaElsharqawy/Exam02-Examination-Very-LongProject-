using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02__Examination_very_long_Project_
{
           public class Question : ICloneable
            {
            public string Header { get; set; }
            public string Body { get; set; }
            public int Mark { get; set; }
            public List<Answer> Answers { get; set; }
            public int RightAnswer { get; set; }
            public int selectAnswer {  get; set; }
            public Question( string body, int mark, List<Answer> answers, int rightAnswer)
            {
              
                Body = body;
                Mark = mark;
                Answers = answers;
                RightAnswer = rightAnswer;
            }

            public object Clone()
            {
                return MemberwiseClone();
            }
        }
    }

