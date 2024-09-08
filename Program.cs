using System.ComponentModel.Design;
using System.Diagnostics;

namespace ExaminationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Subject sub1 = new Subject(1, "Basics Of OOP");

            Console.WriteLine("You Must Start As a teacher ");

            sub1.CreateExam();
            Console.Clear();
                       
            int user;
            do
            {
                Console.WriteLine("Do You Want To Start As a Teacher or a Student  (1 for Teacher | 2 For Student)");
                user = int.Parse(Console.ReadLine());
            } while (!(user is 1 or 2));

            if (user == 1) {
                sub1.CreateExam();
                Console.Clear();
            } else {
                char Char;
                do
                {
                    Console.WriteLine("Do You Want To Start Exam (Y|N)");
                    Char = char.Parse(Console.ReadLine());
                } while (!(Char == 'y' || Char == 'n'));

                if (Char == 'y')
                {
                    Console.Clear();

                    Stopwatch sw = new Stopwatch();

                    sw.Start();

                    sub1.Exam.ShowExam();

                    sw.Stop();


                    Console.WriteLine($"Time = {sw}");
                }

            }
            Console.WriteLine("Good Luck");
            
        }
    }
}
    

