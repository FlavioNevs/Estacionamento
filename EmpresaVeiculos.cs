using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_heranca
{
    class EmpresaVeiculos : Ajuda
    {
        public string Nome { get; set; }
        public int CNPJ { get; set; }
        public string Email { get; set; }

        public string GetNome()
        {
            Clear();
            Print("+--------------------------+");
            Print("| Digite o Nome da Empresa |");
            Print("+--------------------------+");
            Nome = Read();
            return Nome;
        } // Lê o nome da empresa e retorna pro programa;
        public string GetEmail()
        {
            Clear();
            Print("+-----------------+");
            Print("| Digite o E-mail |");
            Print("+-----------------+");
            Email = Read();
            return Email;
        } // Lê o Email da empresa e retorna pro programa;
        public int GetCNPJ()
        {
            Clear();
            Print("+---------------+");
            Print("| Digite o CNPJ |");
            Print("+---------------+");
            CNPJ = Readint();
            return CNPJ;
        } // Lê o CNPJ da empresa e retorna pro programa;
    }
}
