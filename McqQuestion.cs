using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class McqQuestion : Question
    {
        public override string Header => "MCQ Question";

        public McqQuestion()
        {
            Answers = new Answer[4];
        }

        public override void AddQuestion()
        {
            
            Console.WriteLine(Header);

            

            do
            {
                Console.WriteLine("Please Enter Question Body");
                Body = Console.ReadLine();
            } while (!(Body is  string));

            

            int mark;
            do
            {
                Console.WriteLine("Please Enter Question Mark");
                mark= int .Parse(Console.ReadLine());
            } while (!(mark > 0));
            Mark = mark;

            
            Console.WriteLine("Choices Of Question");

            for (int i = 0;i< Answers.Length;i++)
            {
                Answers[i] = new Answer() { Id = i+1 };

               
                do
                {
                    Console.WriteLine($"Please Enter Choice Number {i+1}");
                    Answers[i].Text = Console.ReadLine();
                } while (!((Answers[i].Text)is  string));

            }

            

            int rightAnswerId;
            do
            {
                Console.WriteLine("Please Enter the number of the right Answer ");
                rightAnswerId= int .Parse(Console.ReadLine());
            } while (! (rightAnswerId is 1 or 2 or 3 or 4));

            RightAnswer.Id = rightAnswerId;
            RightAnswer.Text = Answers[rightAnswerId - 1].Text;
            Console.Clear();
        }
    }
}
