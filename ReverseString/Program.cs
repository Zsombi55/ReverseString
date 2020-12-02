/*
 * Created by SharpDevelop.
 * User: Zsombor
 * Date: 2020-12-02
 * Time: 21:20
 */
using System;

namespace reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text: ");
            string text = Console.ReadLine();
            ReverseString(text);
            Console.WriteLine(text);
        }

        static string ReverseString(string input) {
            if (string.IsNullOrEmpty(input)) {
                return string.Empty;
            }
            
            string reversed = "";

            int length = input.Length;
            StringBuilder reversed = new Stringbuilder();

            while (index >= 0)
            {
                //Console.WriteLine($"{text[index]}");
                //reversed += $"{text[index]}";
                reversed.Append($"{input[index]}");
                index--;
            }
            return reversed.ToString();
        }
    }
}
