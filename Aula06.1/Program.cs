using System;

class Aula06{

static void Main(){
    
    double valorCompra=5.50;
    double valorVenda;
    double lucro=0.1;
    string produto="Pastel";

    valorVenda=valorCompra+(valorCompra*lucro);

    Console.WriteLine("Produto..............:{0,15}",produto);
    Console.WriteLine("Val.Compra...........:{0,15:c}",valorCompra);       //C para saida de unidade monetaria
    Console.WriteLine("Lucro................:{0,15:p}",lucro);             //P para saida de porcentagem
    Console.WriteLine("Val.Venda............:{0,15:c}",valorVenda);
    Console.WriteLine();
}
}
