using System;
class Aula19{
    static void Main(){
        int[] num=new int[10];

        for (int i=0;i<num.Length;i++){
            num[i]=i;
        }
        for (int i=0;i<num.Length;i++){
            Console.WriteLine("O VALOR DE NUM NA POSICAO {0}: {1}",i,num[i]);
        }
    }                       
}
