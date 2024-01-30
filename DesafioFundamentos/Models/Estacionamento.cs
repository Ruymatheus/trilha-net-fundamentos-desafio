namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        private readonly List<string> nom = new List<string>();
        private List<string> cpf = new List<string>();
        private DateTime horarioDeEntrada;
        private string Nome;
        public Cliente cliente=new Cliente();
        public Funcionario funcionario=new Funcionario();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite o seu nome:");
            Nome =Console.ReadLine().ToUpper();
            if(Pessoa.nomesCadastradosClientes.Contains(Nome)||Pessoa.nomesCadastradosFuncionarios.Contains(Nome))
                { // Solicita ao usuário a placa do veículo e armazena na lista veiculos.
                Console.WriteLine("Digite a placa do veículo para estacionar:");
                veiculos.Add(Console.ReadLine());
                horarioDeEntrada = DateTime.Now;
                }
            else
            {
             Console.WriteLine("Cadastre um cliente ou um funcionário antes de adicionar um veículo:"); 
            }    
        }

        public void RemoverVeiculo()
        {
            // Solicita ao usuario a placa do veiculo
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            Boolean indicacaovalida = false;
            do
            {
                    // Verifica se o veículo existe
                if  (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                    {Console.WriteLine("Digite seu nome");
                     Nome=Console.ReadLine().ToUpper();
                     //Verifica se a pessoa é um funcionário
                    if(Pessoa.nomesCadastradosFuncionarios.Contains(Nome))                                                  //*Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                        {
                            veiculos.Remove(placa);
                            indicacaovalida = true;
                            Console.WriteLine($"O veículo {placa} foi removido e até o próximo dia de trabalho");
                        }                                                                                                       //*Realiza o calculo de custo total e retira a placa da lista de veículos
                                                                                                                            //*int horas = 0;
                    else
                    {
                        if(Pessoa.nomesCadastradosClientes.Contains(Nome))
                        {
                        decimal valorTotal = 0;                                                                                                     //*horas= Convert.ToInt32(Console.ReadLine());
                        DateTime horaSaida = DateTime.Now;
                        TimeSpan tempoEstacionado = horaSaida - horarioDeEntrada;
                        int horasEstacionadas = (int)Math.Floor(tempoEstacionado.TotalHours);
                        valorTotal = precoInicial + (precoPorHora * horasEstacionadas);                                                                                                        //*valorTotal = precoInicial + (precoPorHora * horas); 
                        veiculos.Remove(placa);
                        indicacaovalida = true;
                        Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                        }
                    }
                    }
                else
                {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                Console.WriteLine("Tente digitar a placa do veículo novamente:");
                indicacaovalida = true;
                }
          
            }while(indicacaovalida == false);
              
        ;}
        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine($"Os veículos estacionados são:{string.Join(", ", veiculos)}");
               
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
 




    }
}
