using System;
class aula24{
    static void Main(){

        //metodos sao conjuntos de instrucoes, um bloco de instrucoes que pode ser chamados a qualquer 
        //momento no nosso codigo. 
 
        soma(10,5);   
        int v1 , v2;
        v1= int.Parse(Console.ReadLine());
        v2= int.Parse(Console.ReadLine());
         Console.WriteLine(" A SOMA DE {0} E {1} É : {2} ", v1 , v2 , soma(v1,v2));

    }
    
    static int soma (int n1 , int n2){

        int somatorio = n1+n2;
        return somatorio;
       
    }

}