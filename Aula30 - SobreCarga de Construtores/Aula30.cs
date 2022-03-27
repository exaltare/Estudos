//------ESBOÇO DA CLASSE MOSTRADA NA AULA:---------------------------------------//
// 
//      O QUE É UMA CLASSE? É UM TIPO DE DADO COMPOSTO POR MEMBROS, OS MEMBROS SAO PROPRIEDADES E METODOS (FUNCOES)
//      
//          
//
//
//      [ModificadorClasse] class NOME_DA_CLASSE (DEFINI A VISIBILDIADE DA CLASSE)
//      {
//      Variáveis / Propriedades
//      [EspecificadorAcesso] tipo NOME_PROPRIEDADE;
//      
//      Metodos
//      [EspecificadorAcesso] retorno NOME_METODO([arg1,...])
//      {
//      corpo do método
//      }
// }

//-------O QUE SÃO E APLICAÇÕES:-----------------------------------------------//

//      [ModificadorClasse]: Define a visibilidade da classe.
//      public: pública, sem restrição de visualização. (ELA NAO TEM RESTRICAO DE VISUALIZACAO E ACESSO )
//      abstract: Classe-Base para outrsas classes, (não podem ser instanciados a objetos desta classe )
//      sealed: Classe não pode ser herdada
//      static: Classe não permite a instanciação de objetos e seus membros devem ser "static"
//
//      [EspecificadorAcesso]: Onde um membro da classe pode ser acessado
//      public: pública, sem restrição de acesso.
//      private: Só podem ser acessados pela própria classe.
//      protected: Podem ser acessados na própria classe e nas classes derivadas
//      abstract: Os métodos não tem implementação somente os cabeçalhos
//      sealed: O método não pode ser redefinido.
//      virtual: O método pode ser redefinido em uma classe derivada.
//      static: o método pode ser chamado mesmo sem a instanciação de um objeto.

 using System;
 
   public class Jogador{                 //Nome de Classe sempre iniciar com Letra Maiusula

    public int energia;                  // Instanciacao da classe
    public bool vivo;
    public string nome;
    public Jogador(string n){            //Para definir o modo contrutor basta ter o memso nome da classe
      energia=100;
      vivo=true;
      nome=n;        
    
      }
      
   }

  
 class Aula29{
     static void Main(){
        string nome1;
        string nome2;
        
        Console.WriteLine("DIGITE O NOME DO JOGADOR 1 :");
        nome1=Console.ReadLine();

        Console.WriteLine("DIGITE O NOME DO JOGADOR 2 :");
        nome2=Console.ReadLine();


        Jogador j1=new Jogador(nome1);                              // criar um objeto da classe jogador 
        Jogador j2=new Jogador(nome2); 
        
        // new vai reservar a memoria e vai retornar o endereco da memoria alocada 
        // alterar a energia antes de imprimir como acessar uma propriedade publica pode ler ou alterar 

        Console.WriteLine(" O Nome do Jogador 1: {0}", j1.nome);
        Console.WriteLine(" O Nome do Jogador 2: {0}", j2.nome);
      }  

   }




