using System;

class Exercicio05 {
    static void Main(string[] args){
        Console.Write("Identificando se o aluno foi aprovado ou não.");
        Console.Write("Digite a primeira nota: ");
        int nota1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a segunda nota: ");
        int nota2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a terceira nota: ");
        int nota3 = Convert.ToInt32(Console.ReadLine());
        int media = ((nota1 + nota2 + nota3) / 3);

        if (media >= 7){
            Console.Write("Aluno aprovado! " + media);
        } else if (media >= 5){
            Console.Write("Aluno em recuperação! " + media)
        } else {
            Console.Write("Aluno reprovado!" + media)
        }
    }
}