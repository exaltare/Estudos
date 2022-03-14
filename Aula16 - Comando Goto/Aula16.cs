using System;

class Aula12
{
    public static void Main()
    {
        int tempo = 0;
        char escolha= 'a';

        inicio: //label
        Console.Clear();

        Console.WriteLine("De Rio de Janeiro até Espirito Santo");
        Console.WriteLine("Escolha um tranposte: \n1 - Avião \n2 - Onibus \n3 - Carro");
        escolha = char.Parse(Console.ReadLine());

        switch (escolha)
        {
            case '1':
                tempo = 50;
                break;
            case '2':
                tempo = 660;
                break;
            case '3':
                tempo = 480;
                break;
            default:
                tempo = -1;
                break;

        }

        if(tempo < 0 ){
            Console.WriteLine("Transporte Indisponivel");

        }
        else {
            Console.WriteLine("Para o transporte escolhido o tempo é: {0} minutos", tempo);
        }

        Console.Write("Calcular outro transporte?[s/n]: ");
        escolha=char.Parse(Console.ReadLine());
        if (escolha == 's' || escolha == 'S')
        {
            goto inicio;
        }
        else {
            Console.Clear();
            Console.WriteLine("Fim do programa");
        }
    }
}