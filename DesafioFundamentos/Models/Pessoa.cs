using System;
using System.Collections.Generic;

namespace DesafioFundamentos.Models
{
    public abstract class Pessoa
    {
        public static List<string> nomesCadastradosFuncionarios = new List<string>();
        public static List<string> nomesCadastradosClientes = new List<string>();
        protected static List<string> cpfsCadastradosFuncionarios = new List<string>();
        protected static List<string> cpfsCadastradosClientes = new List<string>();

        public string Nome { get; set; }
        public string CPF { get; set; }

        public virtual void CadastrarUsuario()
        {
            
        }

        public virtual void ListarCadastrados()
        {
            
           
        }
    }
}
