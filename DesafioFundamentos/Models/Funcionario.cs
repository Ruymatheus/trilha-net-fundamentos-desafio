using System;

namespace DesafioFundamentos.Models
{
    public class Funcionario : Pessoa
    {
        public override void CadastrarUsuario()
        {
            Console.WriteLine("Indique seu nome:");
            nome = Console.ReadLine().ToUpper();

            // Verifica se o nome já está cadastrado
            if (nomesCadastradosFuncionarios.Contains(nome)||nomesCadastradosClientes.Contains(nome))
            {
                Console.WriteLine("Este nome já está cadastrado.");
                return; // Sai do método sem adicionar o nome à lista
            }
            string senha="123";
            Console.WriteLine("Indique sua senha:");
            string possivelSenha=Console.ReadLine();
            if(possivelSenha==senha)
            {
                Console.WriteLine("Indique seu CPF:");
                CPF = Console.ReadLine();

                // Adiciona o nome e o CPF às listas de nomes e CPFs cadastrados
                nomesCadastradosFuncionarios.Add(nome);
                cpfsCadastradosFuncionarios.Add(CPF);

                Console.WriteLine($"Seja bem vindo {nome}!");
                Console.WriteLine($"Boa sorte no seu novo emprego");
            }
            else
            {
                Console.WriteLine("Senha Incorreta");
            }
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
