﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Day13_Generics_Assignments
{
    public class Refactor_Generic_Method
    {
        public T findMaximum<T>(T first, T second, T third) where T : struct, IComparable<T>
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("The Maximum is : " + first);
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("The Maximum is : " + second);
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                Console.WriteLine("The Maximum is: " + third);
                return third;
            }
            return default;
        }
    }
}
