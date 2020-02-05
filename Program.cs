using System;

namespace LiftoffLiveCoding
{
    class Program
    {
        static void Main(string[] arg)
        {
            double clear = .1;
            double cloudy = 0;
            double raining = -.25;
            double fullmoon = .25;
            double forties = -.05;
            double fifties = 0;
            double sixties = .05;
            double seventies = .2;


            
            double answer_one = Calculate_candy(clear, fifties);
            double answer_two = Calculate_candy(fullmoon, forties);
            double answer_three = Calculate_candy(raining, seventies);

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
