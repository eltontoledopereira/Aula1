using System;

namespace MeuPrimeiroTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt1 = "Hello World!";
            string txt2 = "Elton, com idade de:";
            int idade = 36;
            string txt3 = $"{txt1} {txt2} {idade}";

            Console.WriteLine(txt3);
        }
    }
}
