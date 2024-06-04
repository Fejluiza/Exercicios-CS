using System;

class Exercicio02 {
    static void Main(string[] args){
        Console.Write("Identificando se o número informado é positivo ou negativo.");
        Console.Write("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if(numero >= 1)
        {
            Console.Write("O número informado é positivo! " + numero);
        }
        else if(numero == 0)
        {
            Console.Write("O número informado é zero " +numero);
        } else{
            Console.Write("O número informado é negativo! " + numero);
        }
    }
}