using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Lista2ex8
{
    class Program
    {
        public static string triangulo(int v1,int v2,int v3){
 
            if((v1 + v2 > v3) && (v1 + v3 > v2) && (v2 + v3 > v1)){

                if (v1 == v2 && v2 == v3){
                    return "Triangulo Retangulo";
                }
                else if(v1 == v2 && v1 != v3 && v2 != v3){
                    return "Triângulo isósceles";
                }
                else{
                    return "Triângulo  escaleno";
                }
            }
            else{
                return "nao triangulo";
            }
            
        }
        static void Main(string[] args)
        {
            int t1,t2,t3;

            Console.WriteLine("Digite o primeiro valor do triangulo: ");
            t1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor do triangulo: ");
            t2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o terceiro valor do triangulo: ");
            t3 = int.Parse(Console.ReadLine());

            Console.WriteLine(triangulo(t1,t2,t3));

            Console.ReadKey();
            

        }
    }
}
