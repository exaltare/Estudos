using System;
class ExercicioMaioridade{
    static void Main(){
        int NumeroPessoas;
        int idade;
        int i=0;
        

        Console.WriteLine("QUAL A QUANTIDADE DE PESSOAS QUE DESEJA COMPARAR : ");
        NumeroPessoas = int.Parse(Console.ReadLine());

        int[] numero = new int[NumeroPessoas];
        while (i< NumeroPessoas){
            
            i = i +1; 
            Console.WriteLine("QUAL A IDADE DA {0}ª PESSOA " ,i);
            idade = int.Parse(Console.ReadLine());

        } 
        Console.WriteLine(" ||||||DADOS COLETADOS|||||| ");
        Console.WriteLine("UM TOTAL DE {0} : " ,NumeroPessoas);
        Console.WriteLine(contador);

        
        

    }
}