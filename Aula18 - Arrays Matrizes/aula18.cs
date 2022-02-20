using System;
class Aula17{
    static void Main(){
        int [,] n=new int[3,5]; 
        int [,] numero=new int[2,2]{{10,20},{30,40}};
         
        /*
        10 20 30 40 50 
        60 70 80 90 0
        11 12 13 14 15
        */
        
        n[0,0]=10; n[0,1]=20; n[0,2]=30; n[0,3]=40; n[0,4]=50;
        n[1,0]=60; n[1,1]=70; n[1,2]=80; n[1,3]=90; n[1,4]=0;
        n[2,0]=11; n[2,1]=12; n[2,2]=13; n[2,3]=14; n[2,4]=15;

        Console.WriteLine(n[1,1]);
        Console.WriteLine(numero[1,0]);
        




        
        
    }
}