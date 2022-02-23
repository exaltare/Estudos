using System;
class aula15{
    static void Main(){
        
        char cidade ;
        char destino;
        
        Console.WriteLine(">>>>>EXALTARE TRAVEL<<<<<");
        Console .WriteLine("QUAL O DESTINA DA SUA VIAGEM? ");
        Console.WriteLine("[SP] ");
        Console.WriteLine("[RJ] ");
        Console.WriteLine("[DF] ");
        Console.WriteLine("[BH] ");

        cidade= Console.ReadLine();

        switch(cidade){
            //case "sp":
            case "SP":
                cidade="SÃO PAULO";
                break;

            case "rj":
            case "RJ":
                cidade="RIO DE JANEIRO";
                break;            
        }
        if(cidade = "SÃO PAULO"){
            Console.WriteLine(">>>>>EXALTARE TRAVEL<<<<<");
            Console.WriteLine("ESCOLHA O AEROPORTO DE DESTINO : ");
            Console.WriteLine("[GRU] Aeroporto Internacional de Guarulhos – SP ");
            Console.WriteLine("[CGH] Aeroporto Congonhas , VCP Viracopos ");
            Console.WriteLine("[VCP] Aeroporto Internacional de Viracopos ");
            
            destino=char.Parse(Console.ReadLine());

            switch(destino){
                case "GRU":
                    destino ="[GRU] Aeroporto Internacional de Guarulhos – SP";
                    break;
                
                case "CGH":
                    destino = "[CGH] Aeroporto Congonhas , VCP Viracopos ";
                    break;
                
                case "VCP":
                    destino = "[VCP] Aeroporto Internacional de Viracopos";
                    break;                
            } 
            }
            else if (cidade = "RIO DE JANEIRO"){
            Console.WriteLine(">>>>>EXALTARE TRAVEL<<<<<");
            Console.WriteLine("ESCOLHA O AEROPORTO DE DESTINO : ");
            Console.WriteLine("[SDU] Aeroporto Santos Dumont - RJ ");
            Console.WriteLine("[GIG] Aeroporto internacional Tom Jobim - Galeão – RJ ");
                        
            destino=char.Parse(Console.ReadLine());  

            switch(destino){
                case "SDU":
                    destino ="[SDU] Aeroporto Santos Dumont - RJ";
                    break;
                
                case "CGH":
                    destino = "[GIG] Aeroporto internacional Tom Jobim - Galeão – RJ ";
                    break;
                }        
            

            }
            
        }


    }
