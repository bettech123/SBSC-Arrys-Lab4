using System;
using System.Linq;

namespace ArrayLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int score1, score2, score3, score4, score5, totalSubjects;
            double Sum, PercentageGrade, TotalPercentageGrade;
            Console.WriteLine("Enter score");
            score1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter another score");
            score2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter another score");
            score3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter another score");
            score4 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter another score");
            score5 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Score you've entered so far are: " + score1  +", " + score2 + ", " + score3 + ", " + score4 + "and " + score5 );
            
            double [] Grades = {score1, score1, score3, score4, score5};
            totalSubjects = Grades.Length;

               Sum = Grades.Sum();
               Console.WriteLine("Total score: " + Sum);
               Console.WriteLine("CGPA: " + Sum/totalSubjects);
            
            foreach (var grade in Grades)
            {
                PercentageGrade = grade * 10;
                Console.WriteLine("You're Percentage grade for your subjects are as follow: " + " " + PercentageGrade);
                
            }
              
            Console.WriteLine();
        }
    }
}
