using System;

class Exercicio01 {
    static void Main(string[] args){
        Console.Write("Identificando se o número informado é par ou impar");
        Console.Write("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if(numero % 2 == 0)
        {
            Console.Write("O número informado é par! " + numero);
        }
        else
        {
            Console.Write("O número informado é impar! " + numero);
        }
    }
} 