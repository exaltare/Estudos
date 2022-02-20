using System;
class Aula17{
    static void Main(){
        int [] n=new int[5]; //0-4 ou seja 5 posicoes
        string[] veiculos=new string[3];

        n[0] = 10;
        n[1] = n[0]+1;
        n[2] = n[1]*2;
        n[3] = n[0]*55;
        n[4] = 600;

        veiculos[0] = "AVIAO";
        veiculos[1] = "MOTO";
        veiculos[2] = "CARRO";



        Console.WriteLine(n[1]);
        Console.WriteLine(n[2]);
        Console.WriteLine(n[3]);
        Console.WriteLine(n[4]);
        Console.WriteLine(veiculos[0]);
        Console.WriteLine(veiculos[1]);
        Console.WriteLine(veiculos[2]);
        
    }
}