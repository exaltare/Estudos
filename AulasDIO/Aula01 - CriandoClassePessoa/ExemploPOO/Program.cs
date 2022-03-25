using System;
using ExemploPOO.Models;

namespace ExemploPOO{
    class Program{    
    static void Main(string[] args)
    {

        Corrente c = new Corrente();
        c.Creditar(100);
        c.ExibirSaldo();
        // Claculadora calc = new Claculadora();
        // System.Console.WriteLine("RESULTADO DA PRIMEIRA SOMA: " + calc.Somar(10,10));
        // System.Console.WriteLine("RESULTADO DA PRIMEIRA SOMA: " + calc.Somar(10,10,10));


        // Aluno p1 = new Aluno();
        // p1.Nome = "Douglas";
        // p1.Idade = 34;
        // p1.Nota = 10;    
        // p1.Apresentar();

        // Professor p2 = new Professor();
        // p2.Nome = "Douglas";
        // p2.Idade = 34;
        // p2.Salario = 10000;    
        // p2.Apresentar();






        // // valores validos 
        // Retangulo r = new Retangulo();
        // r.DefinirMedidas(30 , 30 );
        // System.Console.WriteLine($"Area: {r.ObterArea()}");

        // // valores invalidos
        // Retangulo r2 = new Retangulo();
        // r2.DefinirMedidas(0 , 0 );
        // System.Console.WriteLine($"Area: {r2.ObterArea()}");


        
        // comentar tudo é a tecla crtl k c 
        
        // Pessoa p1 = new Pessoa();
        // p1.Nome = "Douglas";
        // p1.Idade = 34;
        // p1.Apresentar();

    }
}
}
