using System;
class AumentoSalario{
    static void Main(){

        double salario =0;
        double aumento =0;
        int quantidade;

        Console.WriteLine("Quantos funcionarios deseja calcular ?");
        quantidade = int.Parse(Console.ReadLine());
        Console.Clear();
        
        for ( int i = 0 ; i < quantidade ; i++) {
            Console.WriteLine("QUAL O VALOR DO SALARIO DO FUNCIONÁRIO ? ");
            
            salario = double.Parse(Console.ReadLine());
            
            
            if (salario <=300){
                aumento = ((0.50 * salario) + salario);               
            }
            else{
                aumento = ((0.30 * salario) + salario);
            }
            
        Console.WriteLine("O FUNCIONARIO PASSARÁ A GANHAR R${0} POR MES" ,aumento);
        Console.WriteLine("");

        }
        
    }
}