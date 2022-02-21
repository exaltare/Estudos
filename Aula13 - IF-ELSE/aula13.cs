using System;
class aula13{
    static void Main(){
        float nota1 , nota2 , nota3, nota4 , media;
        //string aluno;

     Console.WriteLine("QUAL O NOME DO ALUNO ? ");
     string aluno = Console.ReadLine();

     Console.WriteLine("POR FAVOR ENTRE COM A PRIMEIRA NOTA DO {0}  ",aluno);
     nota1 = int.Parse(Console.ReadLine());
     
     Console.WriteLine("POR FAVOR ENTRE COM A SEGUNDA NOTA DO {0}  ",aluno);
     nota2 = int.Parse(Console.ReadLine());
     
     Console.WriteLine("POR FAVOR ENTRE COM A TERCEIRA NOTA DO {0}  ",aluno);
     nota3 = int.Parse(Console.ReadLine());
     
     Console.WriteLine("POR FAVOR ENTRE COM A QUARTA NOTA DO {0}  ",aluno);
     nota4 = int.Parse(Console.ReadLine());    

     media = (nota1+nota2+nota3+nota4) / 4;

     // >=7 APROVADO ,   >=5 E <7 RECUPERACAO ,  >=0 E <5 REPROVADO ,  <0 NOTA INVALIDA
     
     if (media >=7){
         Console.WriteLine("O {0} ESTA APROVADO COM MÉDIA {1}" ,aluno , media);
        
     }else if (media >=5 || media <7 ) {
         Console.WriteLine("O {0} ESTA EM RECUPERAÇÃO COM MÉDIA {1}" ,aluno , media);
                
     }else if (media >=0 || media <=5 ) {
         Console.WriteLine("O {0} ESTA EM REPROVADO COM MÉDIA {1}" ,aluno , media);
         
     }else if (media <0 ){
         Console.WriteLine("A NOTA DO ALUNO {0} ESTA INVALIDA, COM MÉDIA {1}" ,aluno , media);
     }        
    }
}