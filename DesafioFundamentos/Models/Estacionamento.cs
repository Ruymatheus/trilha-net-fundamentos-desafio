namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Solicita ao usuario a placa do veiculo e armazena na lista veiculos
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());
        }

        public void RemoverVeiculo()
        {
            // Solicita ao usuario a placa do veiculo
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            Boolean indicacaovalida = false;
            do{
            // Verifica se o veículo existe
                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                 Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

               
                
                // Realiza o calculo de custo total e retira a placa da lista de veículos
                int horas = 0;
                decimal valorTotal = 0; 
                horas= Convert.ToInt32(Console.ReadLine());
                valorTotal = precoInicial + (precoPorHora * horas); 
                veiculos.Remove(placa);
                // saida do loop apenas em caso identificação correta da placa
                indicacaovalida = true;
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                else
                {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                Console.WriteLine("Tente digitar a placa do veículo novamente:");
                placa = Console.ReadLine();
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
