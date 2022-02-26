using System;
class ExercicioMaioridade{
    static void Main(){
        int NumeroPessoas , idade;
        int i=0;
        int maioridade =0;
        double IdadesTotal =0 ;        

        Console.WriteLine("QUAL A QUANTIDADE DE PESSOAS QUE DESEJA COMPARAR : ");
        NumeroPessoas = int.Parse(Console.ReadLine());
        int[] numero = new int[NumeroPessoas];

        

        while (i < NumeroPessoas){
            
            i = i +1; 
            Console.WriteLine("QUAL A IDADE DA {0}ª PESSOA " ,i);
            idade = int.Parse(Console.ReadLine());    
            IdadesTotal += idade;        

                if (idade >= 18){
                    maioridade = maioridade + 1;
                   
                } 
           
        }
        Console.WriteLine(" ||||||DADOS COLETADOS|||||| ");
        Console.WriteLine("TOTAL DE DADOS COLETADO {0} : " ,NumeroPessoas);
        Console.WriteLine("NO TOTAL {0} PESSOAS SÃO MAIORES DE IDADE ", maioridade );
        Console.WriteLine("A MEDIA DE IDADE É DE {0}" ,IdadesTotal / NumeroPessoas);

    }
}