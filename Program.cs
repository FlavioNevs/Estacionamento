using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variaveis
            string a,b,c;
            int contalu = 0;
            int contemp = 0;
            int contcli = 0;
            int contca = 0;
            int cont = 1;
            int contes = 0;
            int u = 1;
            int contpa = 0;
            int contul = 0;
            Geral geral = new Geral();
            List<EmpresaVeiculos> empresa = new List<EmpresaVeiculos>();
            List<Cliente> cliente = new List<Cliente>();
            List<ContratoAluguel> contrato = new List<ContratoAluguel>();
            List<Caminhão> caminhao = new List<Caminhão>();
            List<CarroEsporte> esporte = new List<CarroEsporte>();
            List<CarroPasseio> passeio = new List<CarroPasseio>();
            List<Utilitario> utilitario = new List<Utilitario>();
            while (1 == 1)
            {
                a = geral.Menu(); // Mostra menu de principal;
                switch (a)
                {
                    case "1":
                        int k = 0;
                        while (k == 0)
                        {
                            geral.Menu_cadastrar(); // Mostra menu de cadastro;
                            b = Console.ReadLine();
                            switch (b)
                            {
                                case "1":
                                    cliente.Add(new Cliente());
                                    cliente[contcli].Nome = cliente[contcli].GetNome();
                                    cliente[contcli].Idade = cliente[contcli].GetIdade();
                                    cliente[contcli].CPF = cliente[contcli].GetCPF();
                                    cliente[contcli].Email = cliente[contcli].GetEmail();
                                    contcli++;
                                    break; // Cadastra um novo cliente;
                                case "2":
                                    empresa.Add(new EmpresaVeiculos());
                                    empresa[contemp].Nome = empresa[contemp].GetNome();
                                    empresa[contemp].CNPJ = empresa[contemp].GetCNPJ();
                                    empresa[contemp].Email = empresa[contemp].GetEmail();
                                    contemp++;
                                    break; // Cadastra uma nova empresa;
                                case "3":
                                    string g;
                                    g = geral.Veiculo_select();
                                    switch (g)
                                    {
                                        case "1":
                                            caminhao.Add(new Caminhão());
                                            geral.Veiculo_vend();
                                            foreach (EmpresaVeiculos emp in empresa)
                                            {
                                                Console.WriteLine("| " + cont + " | " + emp.Nome + " - CNPJ: " + emp.CNPJ + " - Email: " + emp.Email);
                                                Console.WriteLine("+---+----------------------------------------------------------------");
                                                cont++;
                                            } // Mostra as empresas cadastradas;
                                            cont = 1;
                                            caminhao[contca].Vendedor = caminhao[contca].GetVend();
                                            caminhao[contca].Fabricante = caminhao[contca].GetFabricante();
                                            caminhao[contca].Modelo = caminhao[contca].GetModelo();
                                            caminhao[contca].Cor = caminhao[contca].GetCor();
                                            caminhao[contca].Ano = caminhao[contca].GetAno();
                                            caminhao[contca].volume = caminhao[contca].GetVolume();
                                            caminhao[contca].Preço = caminhao[contca].GetPreco();
                                            contca++;
                                            break;
                                        case "2":
                                            geral.Veiculo_vend();
                                            foreach (EmpresaVeiculos emp in empresa)
                                            {
                                                Console.WriteLine("| " + cont + " | " + emp.Nome + " - CNPJ: " + emp.CNPJ + " - Email: " + emp.Email);
                                                Console.WriteLine("+---+----------------------------------------------------------------");
                                                cont++;
                                            } // Mostra as empresas cadastradas;
                                            cont = 1;
                                            esporte.Add(new CarroEsporte());
                                            esporte[contes].Vendedor = esporte[contes].GetVend();
                                            esporte[contes].Fabricante = esporte[contes].GetFabricante();
                                            esporte[contes].Modelo = esporte[contes].GetModelo();
                                            esporte[contes].Cor = esporte[contes].GetCor();
                                            esporte[contes].Ano = esporte[contes].GetAno();
                                            esporte[contes].potencia = esporte[contes].GetPotencia();
                                            esporte[contes].Preço = esporte[contes].GetPreco();
                                            contes++;
                                            break;
                                        case "3":
                                            geral.Veiculo_vend();
                                            foreach (EmpresaVeiculos emp in empresa)
                                            {
                                                Console.WriteLine("| " + cont + " | " + emp.Nome + " - CNPJ: " + emp.CNPJ + " - Email: " + emp.Email);
                                                Console.WriteLine("+---+----------------------------------------------------------------");
                                                cont++;
                                            } // Mostra as empresas cadastradas;
                                            cont = 1;
                                            passeio.Add(new CarroPasseio());
                                            passeio[contpa].Vendedor = passeio[contpa].GetVend();
                                            passeio[contpa].Fabricante = passeio[contpa].GetFabricante();
                                            passeio[contpa].Modelo = passeio[contpa].GetModelo();
                                            passeio[contpa].Cor = passeio[contpa].GetCor();
                                            passeio[contpa].Ano = passeio[contpa].GetAno();
                                            passeio[contpa].Preço = passeio[contpa].GetPreco();
                                            contpa++;
                                            break;
                                        case "4":
                                            geral.Veiculo_vend();
                                            foreach (EmpresaVeiculos emp in empresa)
                                            {
                                                Console.WriteLine("| " + cont + " | " + emp.Nome + " - CNPJ: " + emp.CNPJ + " - Email: " + emp.Email);
                                                Console.WriteLine("+---+----------------------------------------------------------------");
                                                cont++;
                                            } // Mostra as empresas cadastradas;
                                            cont = 1;
                                            utilitario.Add(new Utilitario());
                                            utilitario[contul].Vendedor = utilitario[contul].GetVend();
                                            utilitario[contul].Fabricante = utilitario[contul].GetFabricante();
                                            utilitario[contul].Modelo = utilitario[contul].GetModelo();
                                            utilitario[contul].Cor = utilitario[contul].GetCor();
                                            utilitario[contul].Ano = utilitario[contul].GetAno();
                                            utilitario[contul].capPess = utilitario[contul].GetPessoa();
                                            utilitario[contul].Preço = utilitario[contul].GetPreco();
                                            contul++;
                                            break;
                                        default:
                                            geral.Erro();
                                            break;
                                    }
                                    break; // Cadastra um novo veículo;
                                case "9":
                                    k = 1;
                                    break;
                                default:
                                    geral.Erro();
                                    break; // Apresenta um erro pro usuario;
                            } // Switch do Menu de Cadastro;
                        }
                        break;
                    case "2":
                        int f = 1;
                        contrato.Add(new ContratoAluguel());
                        geral.Sl_Cliente();
                        foreach (Cliente cli in cliente)
                        {
                            Console.WriteLine("| " + f + " | " + cli.Nome + " - " + cli.Idade + " Anos - CPF: " + cli.CPF + " - Email: " + cli.Email);
                            Console.WriteLine("+---+-------------------------------------------------------------------------------");
                            f++;
                        } // Mostra os usuarios cadastrados;
                        contrato[contalu].Cli = contrato[contalu].GetCli();
                        Console.Clear();
                        switch (geral.Sl_Veiculo())
                        {
                            case "1":
                                contrato[contalu].Tipo = 0;
                                geral.Ds_veiculo();
                                foreach (Caminhão cam in caminhao)
                                {
                                    Console.WriteLine("| "+u+" |   " + cam.Modelo);
                                    Console.WriteLine("+---+");
                                    Console.WriteLine("|    ");
                                    Console.WriteLine("|Fabricante: " + cam.Fabricante);
                                    Console.WriteLine("|Ano: " + cam.Ano);
                                    Console.WriteLine("|Cor: " + cam.Cor + " Capacidade de carga: " + cam.volume + "KG");
                                    Console.WriteLine("|Vendedor: " + empresa[cam.Vendedor].Nome + " CNPJ: " + empresa[cam.Vendedor].CNPJ);
                                    Console.WriteLine("|Preço: R$" + cam.Preço + "/Dia");
                                    Console.WriteLine("+-------------------------------------------------------------------");
                                    u++;
                                }
                                u = 1;
                                break;
                            case "2":
                                contrato[contalu].Tipo = 1;
                                geral.Ds_veiculo();
                                foreach (CarroEsporte cam in esporte)
                                {
                                    Console.WriteLine("| " + u + " |   " + cam.Modelo);
                                    Console.WriteLine("+---+");
                                    Console.WriteLine("|    ");
                                    Console.WriteLine("|Fabricante: " + cam.Fabricante);
                                    Console.WriteLine("|Ano: " + cam.Ano);
                                    Console.WriteLine("|Cor: " + cam.Cor + " Potencia: " + cam.potencia+"Hp");
                                    Console.WriteLine("|Vendedor: " + empresa[cam.Vendedor].Nome+" CNPJ: " + empresa[cam.Vendedor].CNPJ);
                                    Console.WriteLine("|Preço: R$" + cam.Preço + "/Dia");
                                    Console.WriteLine("+-------------------------------------------------------------------");
                                    u++;
                                }
                                u = 1;
                                break;
                            case "3":
                                contrato[contalu].Tipo = 2;
                                geral.Ds_veiculo();
                                foreach (CarroPasseio cam in passeio)
                                {
                                    Console.WriteLine("| " + u + " |   " + cam.Modelo);
                                    Console.WriteLine("+---+");
                                    Console.WriteLine("|    ");
                                    Console.WriteLine("|Fabricante: " + cam.Fabricante);
                                    Console.WriteLine("|Ano: " + cam.Ano);
                                    Console.WriteLine("|Cor: " + cam.Cor);
                                    Console.WriteLine("|Vendedor: " + empresa[cam.Vendedor].Nome + " CNPJ: " + empresa[cam.Vendedor].CNPJ);
                                    Console.WriteLine("|Preço: R$" + cam.Preço + "/Dia");
                                    Console.WriteLine("+-------------------------------------------------------------------");
                                    u++;
                                }
                                u = 1;
                                break;
                            case "4":
                                contrato[contalu].Tipo = 3;
                                geral.Ds_veiculo();
                                foreach (Utilitario cam in utilitario)
                                {
                                    Console.WriteLine("| " + u + " |   " + cam.Modelo);
                                    Console.WriteLine("+---+");
                                    Console.WriteLine("|    ");
                                    Console.WriteLine("|Fabricante: " + cam.Fabricante);
                                    Console.WriteLine("|Ano: " + cam.Ano);
                                    Console.WriteLine("|Cor: " + cam.Cor + " Capacidade: "+cam.capPess+" pessoa(s)");
                                    Console.WriteLine("|Vendedor: " + empresa[cam.Vendedor].Nome + " CNPJ: " + empresa[cam.Vendedor].CNPJ);
                                    Console.WriteLine("|Preço: R$" + cam.Preço + "/Dia");
                                    Console.WriteLine("+-------------------------------------------------------------------");
                                    u++;
                                }
                                u = 1;
                                break;
                            default:
                                geral.Erro();
                                break;
                        }
                        contrato[contalu].Veiculo = contrato[contalu].GetVc();
                        contrato[contalu].Veiculo = contrato[contalu].Veiculo - 1;
                        switch (contrato[contalu].Tipo)
                        {
                            case 0:
                                geral.confirmaa();
                                Console.WriteLine("|Comprador: "+ cliente[contrato[contalu].Cli].Nome + " - " + cliente[contrato[contalu].Cli].Idade + " Anos - CPF: " + cliente[contrato[contalu].Cli].CPF + " - Email: " + cliente[contrato[contalu].Cli].Email);
                                Console.WriteLine("|Modelo: "+caminhao[contrato[contalu].Veiculo].Modelo);
                                Console.WriteLine("|Fabricante: " + caminhao[contrato[contalu].Veiculo].Fabricante);
                                Console.WriteLine("|Ano: " + caminhao[contrato[contalu].Veiculo].Ano);
                                Console.WriteLine("|Cor: " + caminhao[contrato[contalu].Veiculo].Cor +" Capacidade de carga: " + caminhao[contrato[contalu].Veiculo].volume + "KG");
                                Console.WriteLine("|Vendedor: " + empresa[caminhao[contrato[contalu].Veiculo].Vendedor].Nome + " CNPJ: " + empresa[caminhao[contrato[contalu].Veiculo].Vendedor].CNPJ);
                                Console.WriteLine("|Preço: R$" + caminhao[contrato[contalu].Veiculo].Preço + "/Dia");
                                Console.WriteLine("+-------------------------------------------------------------------");
                                break;
                            case 1:
                                geral.confirmaa();
                                Console.WriteLine("|Comprador: " + cliente[contrato[contalu].Cli].Nome + " - " + cliente[contrato[contalu].Cli].Idade + " Anos - CPF: " + cliente[contrato[contalu].Cli].CPF + " - Email: " + cliente[contrato[contalu].Cli].Email);
                                Console.WriteLine("|Modelo: " + esporte[contrato[contalu].Veiculo].Modelo);
                                Console.WriteLine("|Fabricante: " + esporte[contrato[contalu].Veiculo].Fabricante);
                                Console.WriteLine("|Ano: " + esporte[contrato[contalu].Veiculo].Ano);
                                Console.WriteLine("|Cor: " + esporte[contrato[contalu].Veiculo].Cor + " Potencia: " + esporte[contrato[contalu].Veiculo].potencia + "Hp");
                                Console.WriteLine("|Vendedor: " + empresa[esporte[contrato[contalu].Veiculo].Vendedor].Nome + " CNPJ: " + empresa[esporte[contrato[contalu].Veiculo].Vendedor].CNPJ);
                                Console.WriteLine("|Preço: R$" + esporte[contrato[contalu].Veiculo].Preço + "/Dia");
                                Console.WriteLine("+-------------------------------------------------------------------");
                                break;
                            case 2:
                                geral.confirmaa();
                                Console.WriteLine("|Comprador: " + cliente[contrato[contalu].Cli].Nome + " - " + cliente[contrato[contalu].Cli].Idade + " Anos - CPF: " + cliente[contrato[contalu].Cli].CPF + " - Email: " + cliente[contrato[contalu].Cli].Email);
                                Console.WriteLine("|Modelo: " + passeio[contrato[contalu].Veiculo].Modelo);
                                Console.WriteLine("|Fabricante: " + passeio[contrato[contalu].Veiculo].Fabricante);
                                Console.WriteLine("|Ano: " + passeio[contrato[contalu].Veiculo].Ano);
                                Console.WriteLine("|Cor: " + passeio[contrato[contalu].Veiculo].Cor);
                                Console.WriteLine("|Vendedor: " + empresa[passeio[contrato[contalu].Veiculo].Vendedor].Nome + " CNPJ: " + empresa[passeio[contrato[contalu].Veiculo].Vendedor].CNPJ);
                                Console.WriteLine("|Preço: R$" + passeio[contrato[contalu].Veiculo].Preço + "/Dia");
                                Console.WriteLine("+-------------------------------------------------------------------");
                                break;
                            case 3:
                                geral.confirmaa();
                                Console.WriteLine("|Comprador: " + cliente[contrato[contalu].Cli].Nome + " - " + cliente[contrato[contalu].Cli].Idade + " Anos - CPF: " + cliente[contrato[contalu].Cli].CPF + " - Email: " + cliente[contrato[contalu].Cli].Email);
                                Console.WriteLine("|Modelo: " + utilitario[contrato[contalu].Veiculo].Modelo);
                                Console.WriteLine("|Fabricante: " + utilitario[contrato[contalu].Veiculo].Fabricante);
                                Console.WriteLine("|Ano: " + utilitario[contrato[contalu].Veiculo].Ano);
                                Console.WriteLine("|Cor: " + utilitario[contrato[contalu].Veiculo].Cor + " Capacidade: " + utilitario[contrato[contalu].Veiculo].capPess + " pessoa(s)");
                                Console.WriteLine("|Vendedor: " + empresa[utilitario[contrato[contalu].Veiculo].Vendedor].Nome + " CNPJ: " + empresa[utilitario[contrato[contalu].Veiculo].Vendedor].CNPJ);
                                Console.WriteLine("|Preço: R$" + utilitario[contrato[contalu].Veiculo].Preço + "/Dia");
                                Console.WriteLine("+-------------------------------------------------------------------");
                                break;
                            default:
                                geral.Erro();
                                break;
                        }
                        if (geral.confirma() == 1)
                        {
                            switch (contrato[contalu].Tipo)
                            {
                                case 0:
                                    caminhao.Remove(caminhao[contrato[contalu].Veiculo]);
                                    break;
                                case 1:
                                    esporte.Remove(esporte[contrato[contalu].Veiculo]);
                                    break;
                                case 2:
                                    passeio.Remove(passeio[contrato[contalu].Veiculo]);
                                    break;
                                case 3:
                                    utilitario.Remove(utilitario[contrato[contalu].Veiculo]);
                                    break;
                            }
                        }
                        break;// Faz o Aluguel;
                    case "3":
                        int l = 0;
                        while (l == 0)
                        {
                        c = geral.Menu_Detalhes(); // Mostra menu de detalhes;
                            switch (c)
                            {
                                case "1":
                                    int d = 1;
                                    geral.Ds_cliente();
                                    foreach (Cliente cli in cliente)
                                    {
                                        Console.WriteLine("| " + d + " | " + cli.Nome + " - " + cli.Idade + " Anos - CPF: " + cli.CPF + " - Email: " + cli.Email);
                                        Console.WriteLine("+---+-------------------------------------------------------------------------------");
                                        d++;
                                    } // Mostra os usuarios cadastrados;
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    int e = 1;
                                    geral.Ds_empresa();
                                    foreach (EmpresaVeiculos emp in empresa)
                                    {
                                        Console.WriteLine("| " + e + " | " + emp.Nome + " - CNPJ: " + emp.CNPJ + " - Email: " + emp.Email);
                                        Console.WriteLine("+---+----------------------------------------------------------------");
                                        e++;
                                    } // Mostra as empresas cadastradas;
                                    Console.ReadKey();
                                    break;
                                case "3":
                                    switch (geral.Sl_Veiculo())
                                    {
                                        case "1":
                                            geral.Ds_veiculo();
                                            foreach (Caminhão cam in caminhao)
                                            {
                                                Console.WriteLine("| " + u + " |   " + cam.Modelo);
                                                Console.WriteLine("+---+");
                                                Console.WriteLine("|    ");
                                                Console.WriteLine("|Fabricante: " + cam.Fabricante);
                                                Console.WriteLine("|Ano: " + cam.Ano);
                                                Console.WriteLine("|Cor: " + cam.Cor + " Capacidade de carga: "+cam.volume+"KG");
                                                Console.WriteLine("|Vendedor: " + empresa[cam.Vendedor].Nome);
                                                Console.WriteLine("|Preço: R$" + cam.Preço + "/Dia");
                                                Console.WriteLine("+-------------------------------------------------------------------");
                                                u++;
                                            }
                                            u = 1;
                                            Console.ReadKey();
                                            break; // Mostra Caminhoes cadastrados;
                                        case "2":
                                            geral.Ds_veiculo();
                                            foreach (CarroEsporte cam in esporte)
                                            {
                                                Console.WriteLine("| " + u + " |   " + cam.Modelo);
                                                Console.WriteLine("+---+");
                                                Console.WriteLine("|    ");
                                                Console.WriteLine("|Fabricante: " + cam.Fabricante);
                                                Console.WriteLine("|Ano: " + cam.Ano);
                                                Console.WriteLine("|Cor: " + cam.Cor + " Potencia: " + cam.potencia + "Hp");
                                                Console.WriteLine("|Vendedor: " + empresa[cam.Vendedor].Nome);
                                                Console.WriteLine("|Preço: R$" + cam.Preço + "/Dia");
                                                Console.WriteLine("+-------------------------------------------------------------------");
                                                u++;
                                            }
                                            u = 1;
                                            Console.ReadKey();
                                            break;// Mostra Carros esportivos cadastrados;
                                        case "3":
                                            geral.Ds_veiculo();
                                            foreach (CarroPasseio cam in passeio)
                                            {
                                                Console.WriteLine("| " + u + " |   " + cam.Modelo);
                                                Console.WriteLine("+---+");
                                                Console.WriteLine("|    ");
                                                Console.WriteLine("|Fabricante: " + cam.Fabricante);
                                                Console.WriteLine("|Ano: " + cam.Ano);
                                                Console.WriteLine("|Cor: " + cam.Cor);
                                                Console.WriteLine("|Vendedor: " + empresa[cam.Vendedor].Nome);
                                                Console.WriteLine("|Preço: R$" + cam.Preço + "/Dia");
                                                Console.WriteLine("+-------------------------------------------------------------------");
                                                u++;
                                            }
                                            u = 1;
                                            Console.ReadKey();
                                            break;// Mostra carros de passeio cadastrados;
                                        case "4":
                                            geral.Ds_veiculo();
                                            foreach (Utilitario cam in utilitario)
                                            {
                                                Console.WriteLine("| " + u + " |   " + cam.Modelo);
                                                Console.WriteLine("+---+");
                                                Console.WriteLine("|    ");
                                                Console.WriteLine("|Fabricante: " + cam.Fabricante);
                                                Console.WriteLine("|Ano: " + cam.Ano);
                                                Console.WriteLine("|Cor: " + cam.Cor + " Capacidade: " + cam.capPess + " pessoa(s)");
                                                Console.WriteLine("|Vendedor: " + empresa[cam.Vendedor].Nome);
                                                Console.WriteLine("|Preço: R$" + cam.Preço + "/Dia");
                                                Console.WriteLine("+-------------------------------------------------------------------");
                                                u++;
                                            }
                                            u = 1;
                                            Console.ReadKey();
                                            break;// Mostra Utilitarios cadastrados;
                                        default:
                                            geral.Erro();
                                            break;
                                    }
                                    break;
                                case "9":
                                    l = 1;
                                    break;
                                default:
                                    geral.Erro();
                                    break;
                            } // Switch do menu de detalhes
                        }
                        break;
                    case "9":
                        Environment.Exit(0);
                        break; // Sai do programa;
                    default:
                        geral.Erro();
                        break; // Apresenta um erro pro usuario;
                } // Switch do Menu Principal;
            }
        }
    }
}