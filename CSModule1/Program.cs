﻿using System;

namespace CSModule1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = MyIntMethod(25, 4);
            int b = MyIntMethodTwo(100, 10);
            string c = MyStringMethod("Jonathan ", "Marquez");

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
        static int MyIntMethod(int myValue1, int myValue2)
        {
            int result = 0;

            result = myValue1 * myValue2;

            return result;
        }
        static int MyIntMethodTwo(int myOtherValue1, int myOtherValue2)
        {
            int answer = 0;

            answer = myOtherValue1 / myOtherValue2;

            return answer;
        }
        static string MyStringMethod(string myString1, string myString2)
        {
            string stringResult = "0";

            stringResult = myString1 + myString2;

            return stringResult;
        }
    }
}
