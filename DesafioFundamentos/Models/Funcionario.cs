using System;

namespace DesafioFundamentos.Models
{
    public class Funcionario : Pessoa
    {
        public override void CadastrarUsuario()
        {
            Console.WriteLine("Indique seu nome:");
            Nome = Console.ReadLine().ToUpper();

            // Verifica se o nome já está cadastrado
            if (nomesCadastradosFuncionarios.Contains(Nome)||nomesCadastradosClientes.Contains(Nome))
            {
                Console.WriteLine("Este nome já está cadastrado.");
                return; // Sai do método sem adicionar o nome à lista
            }

            Console.WriteLine("Indique seu CPF:");
            CPF = Console.ReadLine();

            // Adiciona o nome e o CPF às listas de nomes e CPFs cadastrados
            nomesCadastradosFuncionarios.Add(Nome);
            cpfsCadastradosFuncionarios.Add(CPF);

            Console.WriteLine($"Seja bem vindo {Nome}!");
             Console.WriteLine($"Boa sorte no seu novo emprego");
        }
        public override void ListarCadastrados()
        {
            
            if (nomesCadastradosFuncionarios.Any())
            {
                Console.WriteLine($"Os Funcionarios cadastrados são:{string.Join(", ",nomesCadastradosFuncionarios)}");
               
            }
            else
            {
                Console.WriteLine("Não há Funcinarios cadastrados.");
            }
        }

    }
}
