using System;

class Exercicio03 {
    static void Main(string[] args){
        Console.WriteLine("Identificando qual dos números informados é maior");
        Console.Write("Digite um número: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        if(numero1 > numero2)
        {
            Console.Write("O maior número é: " +numero1);
        }
        else
        {
            Console.Write("O maior número é: " +numero2);
        }
    }
}