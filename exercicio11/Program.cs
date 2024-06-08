using System;

 class exercicio11
{
    public static void Main(string[] args)
    {
        Console.WriteLine("verificando se ele o valor informado no intervalo de 10 a 20.");
            Console.Write("Digite um valor: ");
        int valor = Convert.ToInt32(Console.ReadLine());
           
           if (valor>=10 && valor <=20){
            Console.WriteLine("O valor está entre o intervalo de 10 a 20.");
           } else{
            Console.WriteLine("Valor fora do intervalo de 10 a 20.");
           }
    }
}