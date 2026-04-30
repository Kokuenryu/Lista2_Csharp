namespace Lista2ex10;

class Program
{
    static void Main(string[] args)
    {
        double p1, p2;
        double m;
        Console.WriteLine("Digite a primeira nota: ");
        p1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota: ");
        p2 = double.Parse(Console.ReadLine());
        m = (p1 + (2*p2))/3;
        m = Math.Round(m, 2);
        if (m >= 5){
            Console.WriteLine("Aprovado");
            
        }
        else{
            Console.WriteLine("Reprovado");
            
        }
        Console.ReadKey();
    }
}
