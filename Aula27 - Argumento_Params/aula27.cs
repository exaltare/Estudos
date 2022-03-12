using System;
class aula27{
    static void Main(){

        soma(2 , 4 , 5 , 7 , 9);
    }

    static void soma (params int[]n){

        int res=0;

        if (n.Length < 1 ){
            Console.WriteLine("Não Existem valores a serem somados");
        
        }else if (n.Length < 2 ){
            Console.WriteLine("Valores insuficientes para a soma : {0}", n[0]);

        }else{
            for (int i = 0 ; i < n.Length; i++){
                res += n [i];
            }
        Console.WriteLine("A Soma dod valores é : {0}", res);
        }

        
        
    }
}