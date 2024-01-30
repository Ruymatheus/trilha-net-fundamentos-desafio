using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Cliente:Pessoa
    {
        Random random = new Random();
        string cupom;
        
        public override void CadastrarUsuario()
        {
            Console.WriteLine("Indique seu nome:");
            nome = Console.ReadLine().ToUpper();

            // Verifica se o nome já está cadastrado
            if (nomesCadastradosClientes.Contains(nome)||nomesCadastradosFuncionarios.Contains(nome))
            {
                Console.WriteLine("Este nome já está cadastrado.");
                return; // Sai do método sem adicionar o nome à lista
            }

            Console.WriteLine("Indique seu CPF:");
            CPF = Console.ReadLine();

            // Adiciona o nome e o CPF às listas de nomes e CPFs cadastrados
            nomesCadastradosClientes.Add(nome);
            cpfsCadastradosClientes.Add(CPF);
            cupom = random.Next(10000, 99999).ToString();
            Console.WriteLine($"Seja bem vindo {nome}!\nQue sorte! Você Ganhou um cupom de desconto: {cupom}");
            
        }
        public override void ListarCadastrados()
        {
            
            if (nomesCadastradosClientes.Any())
            {
                Console.WriteLine($"Os clientes cadastrados são:{string.Join(", ",nomesCadastradosClientes)}");
               
            }
            else
            {
                Console.WriteLine("Não há clientes cadastrados.");
            }
        }
     
        

    }
}
