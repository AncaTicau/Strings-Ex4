using System;
using System.Text;

namespace Strings_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = ReverseString("This is a string");
            Console.WriteLine(test);

            test = ReverseString("This is a stringgg");
            Console.WriteLine(test);
        }

        //Write a method that reverses a string if it's length is a multiple of 4

        public static string ReverseString(string input)
        {
            if (input.Length % 4 != 0)
            {
                return input;
            }

            StringBuilder sb = new StringBuilder();

            for (int j = input.Length - 1; j >= 0; j--)
            {
                sb.Append(input[j]);
            }

            return sb.ToString();
        }
    }
}
