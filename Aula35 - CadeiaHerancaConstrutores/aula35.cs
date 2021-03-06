using System;

class Veiculo {	//classe base
    public int velMax;
    private int rodas; //!
    private bool ligado;

    public Veiculo (int rodas) => this.rodas = rodas;     //construtor 
    public void ligar() => ligado = true; 
    public void desligar() => ligado = false ;
    public string getLigado() => ligado ? "Ligado Sim" : "Ligado Não";
    public int getRodas() => rodas ; 
    public int setRodas(int rodas) => (rodas > 40) ? 4 : 0 ;

	/*this.rodas < 0 ? this.rodas = 0; 
	this.rodas > 40 ? this.rodas = 4 : null; pelo visto não existe ternário sem o else, e o null não funcionou*/
    
}

class Carro: Veiculo {
    public string nome; // por padrão é private?
    public string cor;

    public Carro(string nome, string cor):base(4) { // construtor

        desligar();
        // rodas = 4;
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
        
    }
}

class CarroCombate:Carro {
    public int municao;

    public CarroCombate():base("Carro de batalha", "verde") {
	municao = 100;
	ligar();
	setRodas(6);
	// só dá para mudar o número de rodas com um setRodas() ou deixando-a pública. Não existe base da base.
    }

}

class Aula34 {
    static void Main() {
	Carro c1 = new Carro("Fiat", "azul");    
	
	Console.WriteLine("-=-=-=-=-=-=");

	Console.WriteLine(c1.nome);
	Console.WriteLine(c1.cor);
	Console.WriteLine(c1.velMax);
	Console.WriteLine(c1.getLigado());
	Console.WriteLine(c1.getRodas());


	CarroCombate c2 = new CarroCombate(); // não precisa passar parâmetros pois seu próprio construtor passa para a classe base

	Console.WriteLine("-=-=-=-=-=-=");

	Console.WriteLine(c.nome);
	Console.WriteLine(c2.cor);
	Console.WriteLine(c2.velMax);
	Console.WriteLine(c2.getLigado());
	Console.WriteLine(c2.getRodas());
	Console.WriteLine(c2.municao);
	
	

    }
}