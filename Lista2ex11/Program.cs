using System.Security.Cryptography.X509Certificates;

namespace Lista2ex11;

class Program
{
    static void Main(string[] args)
    {
        double p1, p2;
        double f;
        Console.WriteLine("Digite a primeira nota: ");
        p1 = double.Parse(Console.ReadLine());
        f = p1 - 15;
        p2 = f/2;
        p2 = p2* -1;
        if(p2 > 0){
            Console.WriteLine("O aluno precisa tirar mais de {0} para passar", p2);            
        }


        Console.ReadKey();
    }
}
