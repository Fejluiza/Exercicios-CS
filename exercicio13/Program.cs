using System;

class exercicio13{
    public static void Main(string[] args)
    {    
        Console.WriteLine("Digite o valor da sua compra.");
       double compra = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe sua categoria (1 para comum, 2 para associado e 3 para VIP): ");
       double categoria = Convert.ToInt32(Console.ReadLine());

        if (categoria == 1){
            Console.WriteLine($"Não tem desconto, valor final da compra: {compra}");
        } else if (categoria == 2){
            double desconto = compra /100 *10;
            double total = compra - desconto;
            Console.WriteLine($"Desconto de 10%, valor final da compra: {total}");
        } else if (categoria == 3){
            double desconto = compra /100 *20;
            double total = compra - desconto;
            Console.WriteLine($"Desconto de 10%, valor final da compra: {total}");
        }
    }
}