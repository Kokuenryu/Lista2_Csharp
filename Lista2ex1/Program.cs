using System;

namespace Lista2ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Digite o primeiro numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Clear();
            if (n1 > n2){
                Console.WriteLine("o Primeiro numero é o maior.");
            }
            else if(n2 > n1){
            Console.WriteLine("o Segundo numero é o maior.");
            }
            Console.ReadKey();
        }
    }
}