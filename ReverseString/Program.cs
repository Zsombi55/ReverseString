/*
 * Created by SharpDevelop.
 * User: Zsombor
 * Date: 2020-12-02
 * Time: 21:20
 */
using System;
using System.Text;

namespace reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text: ");
            string text = Console.ReadLine();
            
            Console.WriteLine(ReverseString(text));
        }

        static string ReverseString(string input) {
            if (string.IsNullOrEmpty(input)) {
                return string.Empty;
            }

            int length = input.Length;
            StringBuilder reversed = new StringBuilder(length);

            int index = length - 1;

            while (index >= 0) {
            	//Console.WriteLine($"{text[index]}");
                //reversed += $"{text[index]}";
                reversed.Append($"{input[index]}");
                index--;
            }

            return reversed.ToString();
        }
    }
}
