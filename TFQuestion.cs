using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class TFQuestion : Question
    {
        public override string Header => $"True | False Question";

        public TFQuestion()
        {
            Answers = new Answer[2];
            Answers[0] = new Answer(1, "True");
            Answers[1] = new Answer(2, "False");
        }

        public override void AddQuestion()
        {
            
            Console.WriteLine(Header);

            

            do
            {
                Console.WriteLine("Please Enter Question Body");
                Body = Console.ReadLine();
            } while (!(Body is string));

            

            int mark;
            do
            {
                Console.WriteLine("Please Enter Question Mark");
                mark = int.Parse(Console.ReadLine());
            } while (! (mark> 0));
            Mark = mark;

           

            int rightAnswerId;
            do
            {
                Console.WriteLine("Please Enter the right Answer id (1 for true | 2 For False)");
                rightAnswerId= int.Parse(Console.ReadLine());
            } while (! (rightAnswerId is 1 or 2));

            RightAnswer.Id = rightAnswerId;
            RightAnswer.Text = Answers[rightAnswerId-1].Text;
            Console.Clear();
        }
    }
}
