using System;

class Exercicio05 {
    static void Main(string[] args){
        Console.WriteLine("Convertendo a nota do aluno.");
        Console.Write("Digite a nota do aluno: ");
        int nota = Convert.ToInt32(Console.ReadLine());

        if (nota >= 9){
            Console.WriteLine("Nota A");
        } else if (nota >=7 ){
            Console.WriteLine("Nota B" );
        } else if (nota >=5 ){
            Console.WriteLine("Nota C" );
        } else if (nota >=3 ){
            Console.WriteLine("Nota D" );
        }else if (nota <=2 ){
            Console.WriteLine("Nota F" );
        }
    }
}