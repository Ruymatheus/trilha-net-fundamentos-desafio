using DesafioFundamentos.Models;
using System;

namespace DesafioFundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal precoInicial = 0;
            decimal precoPorHora = 0;

            
            bool teste = false;
            while(teste==false)
            {
                Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                              "Digite o preço inicial:");
                string auxiliar = Console.ReadLine();
                try
                {
                precoInicial = Convert.ToDecimal(auxiliar);
                teste=true;
                }
                catch (Exception)
                {
                Console.WriteLine("Por favor digite um valor numérico!");
                }
            }    
            teste = false;
            while(teste==false)
            {   Console.WriteLine("Agora digite o preço por hora:");
                string auxiliar=Console.ReadLine();
                try
                {
                precoPorHora = Convert.ToDecimal(auxiliar);
                teste=true;
                }
                catch (Exception)
                {
                Console.WriteLine("Por favor digite um valor numérico!");
                }
                
            }
            // Instancia as classes Estacionamento,Funcionario e cliente.
            Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);
            Funcionario funcionario = new Funcionario();
            Cliente cliente=new Cliente();

            string opcao = string.Empty;
            bool exibirMenu = true;

            // Realiza o loop do menu
            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Adicionar veículo");
                Console.WriteLine("2 - Remover veículo");
                Console.WriteLine("3 - Listar veículos");
                Console.WriteLine("4 - Cadastrar Funcionario");
                Console.WriteLine("5 - Cadastrar Cliente");
                Console.WriteLine("6 - Listar Funcionários");
                Console.WriteLine("7 - Listar Clientes");
                Console.WriteLine("8 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        estacionamento.AdicionarVeiculo();
                        break;

                    case "2":
                        estacionamento.RemoverVeiculo();
                        break;

                    case "3":
                        estacionamento.ListarVeiculos();
                        break;
                    case "4":
                        funcionario.CadastrarUsuario();
                    
                        break;
                    case"5":
                        cliente.CadastrarUsuario();                     
                        break;
                    case"6":
                        funcionario.ListarCadastrados();
                        break;
                    case"7":
                        cliente.ListarCadastrados();
                        break;
                    case "8":
                        exibirMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine();
            }

            Console.WriteLine("O programa se encerrou");
        }
    }
}
