using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_POO
{
    public class ReservaMesa
    {
        public int NumeroMesa;
        public string Nome;
        public int Idade;
        public double Consumo;

        public ReservaMesa(int mesa , string Name, int Age, double Consumption)             //CONSTRUTOR SEM VALORES DEFINIDOS
        {
            NumeroMesa = mesa;
            Nome = Name;
            Idade = Age;
            Consumo = Consumption;

        }

    }
}
