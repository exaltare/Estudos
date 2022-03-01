using System;
class AumentoSalario{
    static void Main(){

        double salario =0;
        double aumento =0;
        int quantidade;
        string[] ListaFuncionarios; 

        Console.WriteLine("Quantos funcionarios deseja calcular ?");
        quantidade = int.Parse(Console.ReadLine());
        ListaFuncionarios= new string [quantidade];

        Console.Clear();
        
        for ( int i = 0 ; i < quantidade ; i++) {
            Console.WriteLine("DIGITE O NOME DESTE FUNCIONARIO ");
            string  NomeFuncionario = Console.ReadLine();

            Console.WriteLine("QUAL O VALOR DO SALARIO DO FUNCIONÁRIO ? ");
            salario = double.Parse(Console.ReadLine());           
            
            if (salario <=300){
                aumento = ((0.50 * salario) + salario);               
            }
            else{
                aumento = ((0.30 * salario) + salario);
            }

            ListaFuncionarios[i] = ("O "+NomeFuncionario+" com o Salario R$ "+salario+" , Passará a ganhar R$ "+aumento+" por mês ");

        }
        
        for ( int i = 0 ; i < ListaFuncionarios.Length ; i++){
            Console.WriteLine(ListaFuncionarios[i]);

        }

    }
}