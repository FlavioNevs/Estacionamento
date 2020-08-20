using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_heranca
{
    class VeiculoAlugado : Ajuda
    {
        public string Cor;
        public string Fabricante;
        public string Ano;
        public string Modelo;
        public double Preço;
        public int Vendedor;
        
        public string GetCor()
        {
            Clear();
            Print("+-------------------------+");
            Print("| Digite a cor do veículo |");
            Print("+-------------------------+");
            Cor = Read();
            return Cor;
        } // Lê a cor do Veiculo;
        public string GetFabricante()
        {
            Clear();
            Print("+--------------------------------+");
            Print("| Digite a Fabricante do veículo |");
            Print("+--------------------------------+");
            Fabricante = Read();
            return Fabricante;
        } // Lê a fabricante do veículo;
        public string GetModelo()
        {
            Clear();
            Print("+----------------------------+");
            Print("| Digite o Modelo do veículo |");
            Print("+----------------------------+");
            Modelo = Read();
            return Modelo;
        } // Lê a fabricante do veículo;
        public string GetAno()
        {
            Clear();
            Print("+-------------------------+");
            Print("| Digite o ano do veículo |");
            Print("+-------------------------+");
            Ano = Read();
            return Ano;
        } // Lê a cor do Veiculo;
        public Double GetPreco()
        {
            Clear();
            Print("+-----------------------------------------------+");
            Print("| Digite o preco de aluguel do veículo ( $/Dia) |");
            Print("+-----------------------------------------------+");
            Preço = ReadDouble();
            return Preço;
        } // Lê a fabricante do veículo;
        public int GetVend()
        {
            Vendedor = Readint();
            Vendedor = Vendedor - 1;
            return Vendedor;
        } // Lê vendedor do veículo;
    }
}
