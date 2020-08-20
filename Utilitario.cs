using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_heranca
{
    class Utilitario : VeiculoAlugado
    {
        public int capPess;

        public int GetPessoa()
        {
            Clear();
            Print("+-------------------------------------------+");
            Print("| Digite a capacidade de pessoas do veiculo |");
            Print("+-------------------------------------------+");
            capPess = Readint();
            return  capPess;

        }
    }
}
