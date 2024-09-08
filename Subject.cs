using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class Subject
    {
        public Subject(int id=0, string name=null)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; } 
        public string Name { get; set; } 
        public Exam Exam { get; set; }

        public void CreateExam()
        {
            int examType, time, numberOfQuestions;
            

            do
            {
                Console.WriteLine($"Please Enter The Type Of Exam (1 For Practical | 2 For final)");
                examType= int.Parse(Console.ReadLine());
            } while (!(examType is 1 or 2));


            do
            {
                Console.WriteLine("Please Enter the time For Exam More Than 30 min");
                time = int.Parse(Console.ReadLine());
            } while (!(time >= 30));

            do
            {
                Console.WriteLine("Please Enter the Number Of questions");
                numberOfQuestions= int.Parse(Console.ReadLine());
            } while (!(numberOfQuestions > 0));

            if(examType == 1)
                Exam = new PracticalExam(time, numberOfQuestions);
            else
                Exam = new FinalExam(time, numberOfQuestions);

            Console.Clear();

            Exam.CreateListOfQuestions();
        }
    }
}
