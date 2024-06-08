using System;

class exercicio14{
    public static void Main(string[]args){

        Console.WriteLine("verificando um número e informando se ele é positivo ou negativo. Se for positivo, calcule a raiz quadrada; se for negativo, informe o número ao quadrado.");
        Console.WriteLine("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero >= 0){
            Console.WriteLine(Math.Round(Math.Sqrt(numero),2));
            // math.round limita as casas decimais, math.sqrt calcula a raiz quadrada
        } else{
            Console.WriteLine(Math.Pow(numero,2));
        }
        // math.pow, expoente do valor.
    }
}