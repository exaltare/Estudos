using System;
class aula25{
    static void Main(){
        int num = 10 ;
        Dobrar(ref num);
        Console.WriteLine(num); 

    }      


    static void Dobrar(ref int valor){
    valor = valor * 2 ;
    
    }
}
    
