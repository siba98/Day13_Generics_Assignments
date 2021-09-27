using System;

namespace Day13_Generics_Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding Maximum Number");
            int check1 = UC1_MaxIntNumCheck.MaximumIntNumber(60, 50, 40);
            Console.WriteLine("Maximum Number:" + check1);

            float check2 = UC2_MaxFloatNumCheck.MaxFloatNumber(23.45f, 45.6f, 38.65f);
            Console.WriteLine("Maximum Number:" + check2);

            string check = UC3_MaxStringNumCheck.MaximumStringNumber("67", "56", "38");
            Console.WriteLine("Maximum Number:" + check);

        }
    }
}
