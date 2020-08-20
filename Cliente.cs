using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_heranca
{
    class Cliente : Ajuda
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }

        public string GetNome()
        {
            Clear();
            Print("+---------------------------+");
            Print("| Digite o Nome e Sobrenome |");
            Print("+---------------------------+");
            Nome = Read();
            return Nome;
        } // Lê o nome e sobrenome do usuario e retorna pro programa;
        public int GetIdade()
        {
            Clear();
            Print("+----------------+");
            Print("| Digite a idade |");
            Print("+----------------+");
            Idade = Readint();
            return Idade;
        } // Lê a idade do usuario e retorna pro programa;
        public string GetCPF()
        {
            Clear();
            Print("+--------------+");
            Print("| Digite o CPF |");
            Print("+--------------+");
            CPF = Read();
            return CPF;
        } // Lê o CPF do usuario e retorna pro programa;
        public string GetEmail()
        {
            Clear();
            Print("+-----------------+");
            Print("| Digite o E-mail |");
            Print("+-----------------+");
            Email = Read();
            return Email;
        } // Lê o Email do usuario e retorna pro programa;
    }
}
