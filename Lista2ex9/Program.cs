namespace Lista2ex9;

class Program
{
    static void Main(string[] args)
    {
       double p;
       double a; 
       string sexo;
       double r;

       Console.WriteLine("Digite seu sexo(m para masculino) (f para feminino): ");
       sexo = Console.ReadLine();
       Console.WriteLine("Digite sua altura em metros: ");
       a = double.Parse(Console.ReadLine());
       Console.WriteLine("Digite sua peso em kilos: ");
       p = double.Parse(Console.ReadLine());

       r = p/(a*a);
       /*Console.Clear();
       Console.WriteLine(r);
       Console.ReadKey();
       Console.Clear();*/

        if (sexo == "m" || sexo == "M" || sexo == "maculino" || sexo == "masculino"){
            if (r < 20){
                Console.WriteLine("Abaixo do peso");
                
            }
            else if(r >= 20 && r < 25){
                Console.WriteLine("Peso ideal ");
            }
            else if(r >= 25){
                Console.WriteLine("Acima do peso ");
            }
        }
        else if(sexo == "Feminino" || sexo == "F" || sexo == "feminino" || sexo == "f"){
            if (r < 19){
                Console.WriteLine("Abaixo do peso");
            }
            else if(r >= 19 && r < 24){
                Console.WriteLine("Peso ideal ");
            }
            else if(r >= 24){
                Console.WriteLine("Acima do peso ");
            }
        }
        Console.ReadKey();
    }
}
