using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_heranca
{
    class CarroEsporte : VeiculoAlugado
    {
        public int potencia;

        public int GetPotencia()
        {
            Clear();
            Print("+----------------------------+");
            Print("| Digite a potencia do carro |");
            Print("+----------------------------+");
            potencia = Readint();
            return potencia;
        }
    }
}
