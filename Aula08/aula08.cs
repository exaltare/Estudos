using System;
class Aula08{
    static void Main(){
        int v1 , v2 , v3,  soma , media;
        string nome;

        Console.WriteLine("FAVOR ENTRE COM O SEU NOME : ");
        nome=Console.ReadLine();
        Console.WriteLine("Favor entre com o primeiro valor :");
        v1=int.Parse(Console.ReadLine());
        Console.WriteLine("favor entre com o segundo valor :");
        v2=int.Parse(Console.ReadLine());
        Console.WriteLine("favor entre com o terceiro valor :");
        v3=int.Parse(Console.ReadLine());
        soma= v1 + v2 + v3;
        media= (soma / 3);
        Console.WriteLine("A SOMA DOS VALORES É {0} e a média é {1}",soma ,media);
        
    }
}