using System.Diagnostics;

namespace Exam02__Examination_very_long_Project_
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Subject subject = new Subject(1, "OOP");

          
            subject.CreateExam();

            Console.Clear();

            Console.Write("Do You Want To Start The Exam (y | n) : ");
            string startExam = Console.ReadLine();

            if (startExam.ToLower() == "y")
            {
                Console.Clear();
                Stopwatch sw = new Stopwatch();
                sw.Start();

             
                subject.Exam.ShowExam();

                sw.Stop();
                Console.WriteLine($"The Elapsed Time {sw.Elapsed}");
            }
            Console.ReadLine();
        }
    }
}
