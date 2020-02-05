using System;

namespace LiftoffLiveCoding
{
    class Program
    {
        static void Main(string[] arg)
        {
            double answer_one = Calculate_candy(.1, 0);
            double answer_two = Calculate_candy(.25, -.05);
            double answer_three = Calculate_candy(-.25, .2);

            Console.WriteLine(answer_one);
            Console.WriteLine(answer_two);
            Console.WriteLine(answer_three);

        }
        public static double Calculate_candy(double x, double y)
        {
            double candytotal = (250 * 3) * (x + y) + (250 * 3);
            return candytotal;

        }
    }
}
