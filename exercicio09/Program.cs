using System;

 class exercicio09
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Verifiando o produto de acordo com seu codigo e informar a sua categoria.");
            Console.Write("Digite o código do produto:");
        int codigo = Convert.ToInt32(Console.ReadLine());

        if (codigo <=10)
        {
            Console.WriteLine("Alimento não-perecível");
        } else if (codigo <=20)
        {
            Console.WriteLine("Alimento perecível");
        }
        else if (codigo <= 30)
        {
            Console.WriteLine("Vestuário");
        }
        else if (codigo <= 40)
        {
            Console.WriteLine("Eletrônicos");
        } else if(codigo >=50)
        {
            Console.WriteLine("Código inválido.");
        }
    }
}