using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_heranca
{
    class Geral : Ajuda
    {
        public string Menu()
        {
            string a;
            Clear();
            Print("    +-------------------+");
            Print("    | Menu              |");
            Print("    +-------------------+");
            Print(" ");
            Print("+---+-------------------+");
            Print("| 1 | Cadastrar         |");
            Print("+---+-------------------+");
            Print("| 2 | Alugar            |");
            Print("+---+-------------------+");
            Print("| 3 | Detalhes          |");
            Print("+---+-------------------+");
            Print("| 9 | Sair              |");
            Print("+---+-------------------+");
            Print(" ");
            a = Read();
            return a;
            
        }// Menu;
        public void Menu_cadastrar()
        {
            Clear();
            Print("    +-------------------+");
            Print("    | Menu Cadastrar    |");
            Print("    +-------------------+");
            Print(" ");
            Print("+---+-------------------+");
            Print("| 1 | Cliente           |");
            Print("+---+-------------------+");
            Print("| 2 | Empresa           |");
            Print("+---+-------------------+");
            Print("| 3 | Veiculo           |");
            Print("+---+-------------------+");
            Print("| 9 | Voltar            |");
            Print("+---+-------------------+");
            Print(" ");
        }// Menu de Cadastro;
        public void Menu_veiculo()
        {
            Clear();
            Print("    +-------------------+");
            Print("    | Tipo de Veiculo   |");
            Print("    +-------------------+");
            Print(" ");
            Print("+---+-------------------+");
            Print("| 1 | Caminhão          |");
            Print("+---+-------------------+");
            Print("| 2 | Carro de Passeio  |");
            Print("+---+-------------------+");
            Print("| 3 | Carro Esportivo   |");
            Print("+---+-------------------+");
            Print("| 4 | Ultilitario       |");
            Print("+---+-------------------+");
            Print(" ");
        }// Menu de Veiculos;
        public string Menu_Detalhes()
        {
            string a;
            Clear();
            Print("    +-------------------+");
            Print("    | Menu de Detalhes  |");
            Print("    +-------------------+");
            Print(" ");
            Print("+---+-------------------+");
            Print("| 1 | Clientes          |");
            Print("+---+-------------------+");
            Print("| 2 | Empresas          |");
            Print("+---+-------------------+");
            Print("| 3 | Veiculos          |");
            Print("+---+-------------------+");
            Print("| 9 | Voltar            |");
            Print("+---+-------------------+");
            Print(" ");
            a = Read();
            return a;
        } // Menu de Detalhes;
        public void Ds_cliente()
        {
            Clear();
            Print("          +----------+");
            Print("          | Clientes |");
            Print("          +----------+");
            Print(" ");
            Print("+---+-------------------------------------------------------------------------------");
        } // Detalhes de Clientes;
        public void Ds_empresa()
        {
            Clear();
            Print("          +----------+");
            Print("          | Empresas |");
            Print("          +----------+");
            Print(" ");
            Print("+---+----------------------------------------------------------------");
        } // Detalhes de Empresas;
        public void Ds_veiculo()
        {
            Clear();
            Print("          +----------+");
            Print("          | Veículos |");
            Print("          +----------+");
            Print(" ");
            Print("+--------------------------------------------------------------------");
        }
        public string Sl_Veiculo()
        {
            string a;
            Clear();
            Print("+------------------------------+");
            Print("| Selecione o tipo de Veiculos |");
            Print("+------------------------------+");
            Print(" ");
            Print("+---+-------------------+");
            Print("| 1 | Caminhão          |");
            Print("+---+-------------------+");
            Print("| 2 | Esportivo         |");
            Print("+---+-------------------+");
            Print("| 3 | Passeio           |");
            Print("+---+-------------------+");
            Print("| 4 | Utilitario        |");
            Print("+---+-------------------+");
            Print(" ");
            a = Read();
            return a;
        }
        public void Sl_Cliente()
        {
            Clear();
            Print("+--------------------------------------+");
            Print("| Cliente que deseja alugar um veículo |");
            Print("+--------------------------------------+");
            Print(" ");
            Console.WriteLine("+---+-------------------------------------------------------------------------------");
        }
        public string Veiculo_select()
        {
            string a;
            Clear();
            Print("    +-------------------+");
            Print("    | Tipos de Veiculos |");
            Print("    +-------------------+");
            Print(" ");
            Print("+---+-------------------+");
            Print("| 1 | Caminhão          |");
            Print("+---+-------------------+");
            Print("| 2 | Esportivo         |");
            Print("+---+-------------------+");
            Print("| 3 | Passeio           |");
            Print("+---+-------------------+");
            Print("| 4 | Utilitario        |");
            Print("+---+-------------------+");
            Print(" ");
            a = Read();
            return a;
        }
        public void Veiculo_vend()
        {
            Clear();
            Print("+---------------------------------+");
            Print("| Selecione o vendedor do veículo |");
            Print("+---------------------------------+");
            Print(" ");
            Console.WriteLine("+-----------------------------------------------------------------------------------");
        }
        public void Erro()
        {
            Clear();
            Print("ERRO \nCARACTERE INVALIDO");
            Readkey();
        }
        public int confirma()
        {
            int a;
            Print("+----------------------------+");
            Print("| Pressione 1 para confirmar |");
            Print("+----------------------------+");
            Print(" ");
            a = Readint();
            return a;
        }
        public void confirmaa()
        {
            Clear();
            Print("+-------------+");
            Print("| Confirmação |");
            Print("+-------------+");
            Print(" ");
        }

    }
}
