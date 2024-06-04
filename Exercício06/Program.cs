using System;

class Exercicio06 {
    static void Main(string[] args){
        Console.Write("Verificando se ano informado é bissexto.");
        Console.Write("Digite um ano a ser verificado: ");
        int ano = Convert.ToInt32(Console.ReadLine());

        if(ano % 4 == 0)
        { 
            if(ano % 100 != 0){
            Console.Write("Ano Bissexto! " + ano);}
            else if( ano % 400 == 0){
                Console.Write("Ano Bissexto! " + ano);
            } 
            else { Console.Write("Não é ano bissexto! " + ano);}
        }
        else { Console.Write("Ano informado não é bissexto! " + ano);}
    }
}