using System;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            static string ReverseString(string a)
            {
                char[] b = a.ToCharArray();
                Array.Reverse(b);
                return new string(b);
            }

            Console.WriteLine(ReverseString("Felipe"));

            Console.WriteLine("Informe o nome");
            string c = Console.ReadLine();

            Console.WriteLine(ReverseString(c));
        }
    }
}