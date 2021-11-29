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

            Console.WriteLine("Teste do Palindromo \n");

            var check = false;

            do
            {
                Console.WriteLine("Informe a palavra");
                string c = Console.ReadLine();

                var d = ReverseString(c);
                Console.WriteLine(ReverseString($"\n{c}"));

                if (c == d)
                {
                    Console.WriteLine("Parabéns. \nÉ um Palindromo.");
                    check = true;
                }
                else
                {
                    Console.WriteLine("Não é um Palindromo. \nInforme uma nova palavra. \n");
                }

            }
            while (check != true);

        }
    }
}