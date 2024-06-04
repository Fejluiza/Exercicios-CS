using System;

class Exercicio04 {
    static void Main(string[] args){
        Console.WriteLine("Identificando se os valores informados formam um triângulo válido");
        Console.Write("Digite o valor do primeiro lado do triangulo: ");
        int valor1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o valor do segundo lado do triangulo: ");
        int valor2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o valor do terceiro lado do triangulo: ");
        int valor3 = Convert.ToInt32(Console.ReadLine());

        int soma = (valor1 + valor2);
        int soma2 = (valor1 + valor3);
        int soma3 = (valor2 + valor3);

        if (soma > valor3 && soma2 > valor2 && soma3 > valor1) {
            Console.WriteLine("Formam um triângulo válido");
        } else {
            Console.WriteLine("Os valores informados não formam um triângulo válido");
        }
    }
}