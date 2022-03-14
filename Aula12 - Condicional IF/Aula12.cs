using System;

class Aula12 {
    static void Main() {
        int n1,n2,n3,n4, res;
        n1=n2=n3=n4=res=0;

        Console.Write("Digite a nota 1: ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        n2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        n3 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 4: ");
        n4 = int.Parse(Console.ReadLine());

        res= n1 + n2+ n3+ n4;
        
        string resultado = "Reprovado";



        if(res >= 60) {
            Console.WriteLine("Aprovado");
        }
        else {
        Console.WriteLine("Reprovado");

        }

    }
}