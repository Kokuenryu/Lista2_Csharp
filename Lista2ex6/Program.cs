using System;
using System.Xml.Serialization;

namespace Lista2ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,p;
            Console.WriteLine("Digite o seu peso em kg: ");
            p = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o sua altura em metros: ");
            a = double.Parse(Console.ReadLine());
            Double imc = p/(a*a);
            Console.Clear();
            if (imc < 20){
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc < 25 && imc >= 20){
                Console.WriteLine("Peso ideal");
            }
            else if (imc >= 25){
                Console.WriteLine("Acima do peso");
            }
            Console.ReadKey();
            

        }
    }
}
/*
R < 20 Abaixo do peso 
20 <= R < 25 Peso ideal 
R >= 25 Acima do peso 
*/