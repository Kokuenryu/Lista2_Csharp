using System;

namespace Lista2ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            double c,l;
            

            Console.WriteLine("Digite o valor referente ao comprimento do terreno: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor referente a largura do terreno: ");
            l = double.Parse(Console.ReadLine());

            double final = c*l;
            if(final >= 100){
                Console.WriteLine("Terreno Grande com {0} metros quadrados", final);
            }
            else{
                Console.WriteLine("Terreno Pequeno com {0} metros quadrados", final);
            }
            Console.ReadKey();


        }
    }
}