using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_heranca
{
    class ContratoAluguel : Ajuda
    {
        public int Cli;
        public int Tipo;
        public int Veiculo;

        public int GetCli()
        {
            Cli = Readint();
            Cli = Cli - 1;
            return Cli;
        }
        public int GetVc()
        {
            Print("+----------------------------+");
            Print("| Digite o numero do veiculo |");
            Print("+----------------------------+");
            Print(" ");
            Veiculo = Readint();
            return Veiculo;
        }
    }
}
