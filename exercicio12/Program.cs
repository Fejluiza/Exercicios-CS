using System;

 class exercicio12
{
    public static void Main(string[] args)
    {
        Console.WriteLine("verificando se ele o valor informado é maior que 100.");
            Console.Write("Digite um valor: ");
        int valor = Convert.ToInt32(Console.ReadLine());
           
           if (valor >= 100){
            Console.WriteLine("Número informado é maior que 100.");
           }
           else {
            Console.WriteLine($"O número é menor que 100, o dobro do seu valor é: {valor*2}");
           }
    }
}