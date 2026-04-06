using System;

namespace Lista2ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3;

            Console.WriteLine("Digite o primeiro numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro numero: ");
            n3 = int.Parse(Console.ReadLine());

            Console.Clear();

            if (n1 > n2 && n1 > n3){
                Console.WriteLine("O maior valor é {0}", n1);
            }
            else if (n2 > n1 && n2 > n3){
                Console.WriteLine("O maior valor é {0}", n2);
            }
            else if (n3 > n1 && n3 > n2){
                Console.WriteLine("O maior valor é {0}", n3);
            }
            else if (n1 == n2 && n1 == n3){
                Console.WriteLine("Todos os numeros sao iguais.");
            }
            else if (n1 == n2){
                Console.WriteLine("O primeiro numero e o segundo sao iguais");
            }
            else if (n1 == n3){
                Console.WriteLine("O primeiro numero e terceiro sao iguais");
            }
            else if (n2 == n3){
                Console.WriteLine("O segundo numero e igual ao terceiro.");
            }
            
            
            Console.ReadKey();
        }
    }
}