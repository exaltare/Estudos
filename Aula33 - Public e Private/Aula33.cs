using System;
class Jogador {
	private int energia;
	private string nome;					//objeto 
	    
	public Jogador(string nome) {              //instanciacao do objeto 
		this.nome = nome;
		energia = 100;
		//idade = 14;  não precisa estar no construtor se já foi definido anteriormente
		
	}

    	public int getEnergia() {  		// Metodo GET para obter 
        	return energia; 			
    	}
    	public string getNome() {		
        	return nome;				//retorna a propriedade nome
    	}
    
    	public void setEnergia(int e) { // na verdade diminui energia   // energia nao pode ser <0 e nem >100
        	energia += e;
        	if (energia > 100) energia = 100;
        	if (energia < 0) energia = 0;
    	}
}
class Aula33 {
	static void Main() {

	Jogador j1 = new Jogador("Douglas");

	// Console.WriteLine(j1.nome);
	// Console.WriteLine(j1.energia);

        j1.setEnergia(60);

	    Console.WriteLine(j1.getNome());
        Console.WriteLine(j1.getEnergia());
		
	}
}