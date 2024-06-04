using System;

class Exercicio01 {
    static void Main(string[] args){
        Console.Write("Verificando se a idade informada é de uma criança, um adolescente, um adulto ou um idoso.");
        Console.Write("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade <0){
            Console.WriteLine("Numero inválido");
        } 
        else if (idade <=12){
            Console.WriteLine("Idade de uma criança.");
        }
        else if (idade <=17){
            Console.WriteLine("Idade de um adolescente.");
        }
        else if (idade <=59){
            Console.WriteLine("Idade de uma adulto.");
        } 
        else if (idade > 60){
            Console.WriteLine("Idade de um idoso");
        }
    }
}