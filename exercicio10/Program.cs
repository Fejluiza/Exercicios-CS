using System;

 class exercicio10
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Calculo de soma, subtração, multiplicação e divisão.");
            Console.Write("Digite o primeiro valor: ");
        int valor1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
        int valor2 = Convert.ToInt32(Console.ReadLine());
    
            Console.Write("Digite o sinal para o calculo: ");
        string sinal = Console.ReadLine();

        if (sinal == "+"){
            Console.WriteLine(valor1+valor2);
        } else if (sinal == "-"){
             Console.WriteLine(valor1-valor2);
        } else if (sinal == "*"){
             Console.WriteLine(valor1*valor2);
        } else if (sinal == "/"){
             Console.WriteLine(valor1/valor2);
        }
    }
}