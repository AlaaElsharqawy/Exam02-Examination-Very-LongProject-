using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02__Examination_very_long_Project_
{
    




        public class Subject
        {
            public int SubjectId { get; set; }
            public string SubjectName { get; set; }
            public Exam Exam { get; set; }

            public Subject(int id, string name)
            {
                SubjectId = id;
                SubjectName = name;
            }

        
            public void CreateExam()
            {

                Console.Write("Enter The Type Of Exam You Want To Create (1 for practical and 2 for Final): ");

            int examType;
            while (!int.TryParse(Console.ReadLine(), out examType) || (examType != 1 && examType != 2))
            {
                Console.WriteLine("Invalid input.\nEnter The Type Of Exam You Want To Create (1 for practical and 2 for Final):  ");
            }


            Console.Write("Please Enter The Time Of Exam in Minutes: ");
            int time;
            while (!int.TryParse(Console.ReadLine(), out time) )
            {
                Console.WriteLine("Invalid input.\n Please Enter The Time Of Exam in Minutes: ");
            }

            Console.Write("Enter The Number of Questions you Want To Create : ");
                int numberOfQuestion ;

            while (!int.TryParse(Console.ReadLine(), out numberOfQuestion) )
            {
                Console.WriteLine("Invalid input.\n Enter The Number of Questions you Want To Create : ");
            }

            Console.Clear();

                switch (examType)
                {
                    case 1:
                        Exam = new PracticalExam(DateTime.Now.AddMinutes(time), numberOfQuestion, this);

                    for (int i = 1; i <= numberOfQuestion; i++)
                    {
                        Console.WriteLine("Choose one Answer Question : ");
                        Console.WriteLine($"Please Enter The Body Of Question {i}: ");
                        string questionBody;

                        while (string.IsNullOrWhiteSpace(questionBody = Console.ReadLine()))
                        {


                            Console.WriteLine("Invalid input.\n Enter The Number of Questions you Want To Create :  ");
                        }

                        Console.Write("Please Enter The Marks Of Question :");
                        int questionMark;


                        while (!int.TryParse(Console.ReadLine(), out questionMark))
                        {
                            Console.WriteLine("Invalid input.\n Please Enter The Marks Of Question :  ");
                        }


                        Console.WriteLine("The Choice of Question : ");
                        List<Answer> choices = new List<Answer>();
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write($"Please Enter The Choice Number {j + 1}: ");
                            var choice = Console.ReadLine();

                            while (string.IsNullOrWhiteSpace(choice))
                            {
                                Console.Write($"Please Enter The Choice Number {j + 1}: ");
                                choice = Console.ReadLine();

                            }
                            choices.Add(new Answer(j + 1, choice));

                        }
                            Console.WriteLine("Please Specify The Right Choice Of Question : ");

                            int correctAnswer ;


                        
                        

                            while (!int.TryParse(Console.ReadLine(), out correctAnswer) || correctAnswer <1 || correctAnswer > choices.Count)
                            {
                                Console.WriteLine( "Invalid Input \n Please Specify The Right Choice Of Question : ");
                            }




                  

                        ((PracticalExam)Exam).Questions.Add(new MCQQuestion(questionBody, questionMark, choices, correctAnswer));
                            Console.Clear();



                      
                    }

                        break;





                    case 2:

               
                        Exam = new FinalExam(DateTime.Now.AddMinutes(time), numberOfQuestion, this);

        

                    for (int i = 1; i <= numberOfQuestion; i++)


                        {
                            Console.Write($"Please Choose The Type Of Question Number {i} (1 for True/False || 2 for MCQ): ");
                            int questionType ;

                        while (!int.TryParse(Console.ReadLine(), out questionType))
                        {
                            Console.WriteLine($"Invalid input.\n Please Choose The Type Of Question Number {i} (1 for True/False || 2 for MCQ): \" ");
                        }


                        Console.Clear();

                            if (questionType == 1)
                            {
                                Console.WriteLine("True || False Question");
                                Console.WriteLine($"Please Enter The Body Of Question {i}: ");
                            string questionBody;
                            while (string.IsNullOrWhiteSpace(questionBody = Console.ReadLine()))
                            {
                                Console.WriteLine($"Please Enter The Body Of Question {i}: ");
                            }

                                Console.Write("Please Enter The Marks Of Question :");
                                int questionMark ;

                            while (!int.TryParse(Console.ReadLine(), out questionMark))
                            {
                                Console.WriteLine("Invalid input.\n Please Enter The Marks Of Question : \" ");
                            }



                            List<Answer> choices = new List<Answer>
                        {
                            new Answer ( 1,  "True" ),
                            new Answer ( 2, "False" )
                        };

                                Console.Write("Please Enter The Right Answer Of Question (1 for True and 2 for False): ");
                                int correctAnswer ;

                            while (!int.TryParse(Console.ReadLine(), out correctAnswer) || (correctAnswer != 1 && correctAnswer != 2))
                            {
                           
                                Console.WriteLine("Invalid input.\n Please Enter The Right Answer Of Question (1 for True and 2 for False):\" ");
                            }

                                ((FinalExam)Exam).Questions.Add(new TrueOrFalseQuestion( questionBody, questionMark,
                                    choices, correctAnswer));
                            Console.Clear() ;
                            }
                            else if (questionType == 2)
                            {Console.Clear();
                                Console.WriteLine("Choose one Answer Question : ");
                                Console.WriteLine("Please Enter The Body Of Question : ");
                            string questionBody;


                            while (string.IsNullOrWhiteSpace(questionBody = Console.ReadLine()))
                            {
                                Console.WriteLine(" invalid Input \n Please Enter The Body Of Question : ");
                            }
                                Console.WriteLine("Please Enter The Marks Of Question :");
                                int questionMark ;

                            while (!int.TryParse(Console.ReadLine(), out questionMark))
                            {
                                Console.WriteLine("Invalid Input \nPlease Enter The Marks Of Question :");
                            }


                            Console.WriteLine("The Choices of Questions :");
                                List<Answer> choices = new List<Answer>();
                                for (int j = 0; j < 3; j++)
                                {
                                    Console.Write($"Please Enter The Choice Number {j + 1}: ");
                                    var choice = Console.ReadLine();




                                while (string.IsNullOrWhiteSpace(choice))
                                {
                                    Console.Write($"Please Enter The Choice Number {j + 1}: ");
                                    choice = Console.ReadLine();

                                }
                         
                                choices.Add(new Answer(j + 1, choice));
                                }

                                Console.Write("Please Specify The Right Choice Of Question : ");
                                int correctAnswer ;

                            
                                while (!int.TryParse(Console.ReadLine(), out correctAnswer) || correctAnswer < 1 || correctAnswer > choices.Count)
                            {
                                Console.WriteLine("Invalid Input \n Please Specify The Right Choice Of Question : ");
                            }

                                ((FinalExam)Exam).Questions.Add(new MCQQuestion( questionBody, questionMark,
                                    choices, correctAnswer));
                            }
                        
                        }
                        break;
                }
            }

          
            public override string ToString()
            {
                return $"Subject ID: {SubjectId}, Subject Name: {SubjectName}";
            }
        }
    }

