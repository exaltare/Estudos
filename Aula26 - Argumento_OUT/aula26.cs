using System;
class aula26{
    static void Main(){

    int divid, divis,quoc,rest;
    divid=10;
    divis=5;
    quoc=Divide(divid,divis,out rest);
    Console.WriteLine("{0} / {1}: = {2} e Resto= {3}",divid,divis,quoc,rest);

        
    }

    static int Divide(int dividendo, int divisor, out int resto){
        int quociente;
        quociente=dividendo/dividendo;
        resto=dividendo%divisor;
        return quociente;

    }
    
}