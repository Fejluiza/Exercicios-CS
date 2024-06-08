using System;

class exercicio15{
    public static void Main(string[]args){
        Console.WriteLine("Programa que le o peso e a altura de uma pessoa, calculando o IMC e informando a categoria.");
        Console.WriteLine("Digite seu peso: ");
        double peso = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite sua altura: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double calculo = peso/(altura*altura);

        Console.WriteLine($"Seu IMC é: {Math.Round(calculo,2)}");

        if (calculo <= 18.5)
        {
            Console.WriteLine("Você está abaixo do peso.");
        }

        else if (calculo >= 18.5 && calculo <=24.9)
        {
            Console.WriteLine("Você está com o peso ideal.");
        }

        else if (calculo >=25 && calculo <=29.9)
        {
            Console.WriteLine("Você está no sobrepeso.");
        }

        else if (calculo >= 30 && calculo <=34.9)
        {
            Console.WriteLine("Você está com obesidade grau I.");
        }
        else if (calculo >= 35 && calculo <=39.9)
        {
            Console.WriteLine("Você está com obesidade grau II.");
        }
        else
        {
            Console.WriteLine("Você está com obesidade grau III.");
        }

    }
}


/*
Abaixo do peso: IMC < 18.5 

Peso normal: 18.5 <= IMC < 24.9 

Sobrepeso: 25 <= IMC < 29.9 

Obesidade grau I: 30 <= IMC < 34.9 

Obesidade grau II: 35 <= IMC < 39.9 

Obesidade grau III: IMC >= 40 
*/