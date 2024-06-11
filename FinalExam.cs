using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exam02__Examination_very_long_Project_
{



    public class FinalExam : Exam
    {
        public List<Question> Questions { get; set; }
        public int Grade { get; set; }

        public FinalExam(DateTime timeOfExam, int numberOfQuestions, Subject examSubject)
            : base(timeOfExam, numberOfQuestions, examSubject)
        {
            Questions = new List<Question>();
        }

        public override void ShowExam()
        {


            int YourGrade = 0;
            int totalMarks = 0;

            foreach (var question in Questions)
            {


                if (question is TrueOrFalseQuestion trueFalseQuestion)
                {
                    Console.WriteLine($" True | False Question       Mark({question.Mark})");
                    Console.WriteLine($"{question.Body}");

                    foreach (var choice in trueFalseQuestion.Answers)
                    {
                        Console.Write($"{choice.AnswerId}. {choice.AnswerText}           ");
                    }
                    Console.WriteLine("\n-----------------------------------------------");


                    int selectedAnswer = int.Parse(Console.ReadLine()) - 1;

                    question.selectAnswer = selectedAnswer;


                    Console.WriteLine("");
                    Console.WriteLine("======================================================================");
                }
                else if (question is MCQQuestion mcqQuestion)
                {
                    Console.WriteLine($"Choose one Answer Question        Mark({question.Mark})");
                    Console.WriteLine($"{question.Body}");
                    for (int i = 0; i < mcqQuestion.Answers.Count; i++)
                    {
                        Console.Write($"{i + 1}. {mcqQuestion.Answers[i].AnswerText}         ");
                    }

                    Console.WriteLine("\n-----------------------------------------------");
                    int selectedAnswer = int.Parse(Console.ReadLine()) - 1;
                  
                    question.selectAnswer = selectedAnswer;
                  
                    Console.WriteLine("");
                    Console.WriteLine("======================================================================");

                }

            }



            Console.Clear();


            Console.WriteLine("Your Answers : ");



            foreach (var question in Questions)
            {

                Console.WriteLine($"Q{Questions.Count}) {question.Body}: ( Your Answer :{question.Answers[question.selectAnswer].AnswerText})  ====> ( correct Answer :{question.Answers[question.RightAnswer].AnswerText}) ");


                if (question.selectAnswer == question.RightAnswer)
                {
                    totalMarks += question.Mark;
                    YourGrade += question.Mark;
                }
                else
                {
                    totalMarks += question.Mark;

                }
            }
            Console.WriteLine($"Your Exam Grade is {YourGrade} from {totalMarks}");

        }


    }



}
          
    

