using PerlinkTest.BLL;

using System;

namespace PerlinkTest.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de números felizes e sortudos!");
            Console.WriteLine("Digite um número para saber se o mesmo é feliz e sortudo");
            int number = Convert.ToInt32(Console.ReadLine());

            string isHappyNumber = HappyLuckyNumberService.IsHappyNumber(number);

            Console.WriteLine("O número {0} é {1}", number, isHappyNumber);
            Console.WriteLine("Digite qualquer tecla para encerrar o programa");
            Console.ReadKey();
        }
    }
}
