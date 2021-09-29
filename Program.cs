using System;

namespace Day13_Generics_Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding Maximum Number");


            ////****************UC1--Maximium Integer Number*******************
            //int check1 = UC1_MaxIntNumCheck.MaximumIntNumber(60, 50, 40);
            //Console.WriteLine("Maximum Number:" + check1);


            ////****************UC2--Maximum Floating Point Number*******************
            //float check2 = UC2_MaxFloatNumCheck.MaxFloatNumber(23.45f, 45.6f, 38.65f);
            //Console.WriteLine("Maximum Number:" + check2);


            ////****************UC3--Maximum String*******************
            //string check3 = UC3_MaxStringNumCheck.MaximumStringNumber("67", "56", "38");
            //Console.WriteLine("Maximum Number:" + check3);


            //****************Refactor1******************
            int checkInt3 = Refactor_Generic_Method<int>.MaximumIntNumber(87, 299, 389);
            Console.WriteLine("Maximum Number:" + checkInt3);
            float checkFloat3 = Refactor_Generic_Method<float>.MaxFloatNumber(67.5f, 35.47f, 88.65f);
            Console.WriteLine("Maximum Number:" + checkFloat3);
            string checkString3 = Refactor_Generic_Method<string>.MaximumStringNumber("12", "73", "76");
            Console.WriteLine("Maximum Number:" + checkString3);


            ////****************Refactor2******************
            //int checkInt = Refactor2_Generic_Class<int>.MaximumIntNumber(37, 1, 180);
            //Console.WriteLine("Maximum Number:" + checkInt);
            //float checkFloat = Refactor2_Generic_Class<float>.MaxFloatNumber(36.7f, 125.69f, 25.65f);
            //Console.WriteLine("Maximum Number:" + checkFloat);
            //string checkString = Refactor2_Generic_Class<string>.MaximumStringNumber("17", "86", "92");
            //Console.WriteLine("Maximum Number:" + checkString);



            //#region UC4_MaxValue

            ////By using Array taking more than 3 parameters

            //int[] intArray1 = { 937, 68, 431, 529, 736 };
            //UC4_Sorting<int> checkInt1 = new UC4_Sorting<int>(intArray1);
            //int i = checkInt1.MaxValue(intArray1);
            //Console.WriteLine(i);

            //float[] floatArray1 = { 5.6f, 67.54f, 32.2f, 57.89f, 12.2f };
            //UC4_Sorting<float> checkFloat1 = new UC4_Sorting<float>(floatArray1);
            //float f = checkFloat1.MaxValue(floatArray1);
            //Console.WriteLine(f);

            //string[] stringArray1 = { "325", "836", "238", "759", "479" };
            //UC4_Sorting<string> checkString1 = new UC4_Sorting<string>(stringArray1);
            //string s = checkString1.MaxValue(stringArray1);
            //Console.WriteLine(s);

            //#endregion


            //#region UC5_Extending_Method

            //int[] intArray = { 937, 68, 2826, 529, 736 };
            //UC5_Extending_Method<int> checkInt2 = new UC5_Extending_Method<int>(intArray);
            //checkInt2.PrintMaxValue();

            //float[] floatArray = { 5.6f, 67.54f, 32.2f, 57.89f, 12.2f };
            //UC5_Extending_Method<float> checkFloat2 = new UC5_Extending_Method<float>(floatArray);
            //checkFloat2.PrintMaxValue();

            //string[] stringArray = { "325", "536", "238", "75", "479" };
            //UC5_Extending_Method<string> checkString2 = new UC5_Extending_Method<string>(stringArray);
            //checkString2.PrintMaxValue();

            //#endregion
        }
    }
}
