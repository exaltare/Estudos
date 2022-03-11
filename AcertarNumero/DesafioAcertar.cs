using System;
class Principal {
    static void Main() {
        int chute; 
        int creditos;
        int gameover = 0;
        int contador = 0;

        Random myObject = new Random();
        int aleatorio= myObject.Next(1,50);

        Console.Write("SEJA BEM VINDO JOGADOR, QUANTOS CREDITOS DESEJA UTILIZAR : ");
        creditos = int.Parse(Console.ReadLine());

        do{ 
            Console.WriteLine("CHUTE UM NUMERO DE 1 ATE 50");
            chute = int.Parse(Console.ReadLine());
                       
            if (chute < aleatorio){
                creditos -=1;
                contador++;
                Console.WriteLine("O NUMERO É MAIS ALTO");
                
            } else if (chute > aleatorio){ 
                creditos -=1;
                contador++;
                Console.WriteLine("O NUMERO É MAIS BAIXO");
            } else {
                Console.WriteLine("NA MOSCA PARABENS VOCE ACERTOU COM {0} TENTATIVA(AS) E TINHA {1} CREDITO(S)",contador , creditos);
            }
        } while (chute!=aleatorio && creditos > gameover);         
        Console.WriteLine(" .....GAME OVER.....");
        Console.ReadKey();              
    }
}

        
           
