using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02__Examination_very_long_Project_
{



    public class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion( string body, int mark, List<Answer> answers, int rightAnswer)
            : base( body, mark, answers, rightAnswer)
        {

        }
    }
}
