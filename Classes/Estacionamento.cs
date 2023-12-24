using System.Threading;

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
            // Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.Write("Digite a placa do veículo para estacionar: ");

            string PlacaNova = Console.ReadLine().ToUpper().Trim();
            Console.Write($"\n    Veículo de placa {PlacaNova} está estacionado.\n");
            veiculos.Add(PlacaNova);
            Thread.Sleep(3000);
        }

        public void RemoverVeiculo()
        {
            Console.Write("Digite a placa do veículo para remover: ");
            
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string PlacaRemovida = Console.ReadLine().ToUpper().Trim();
            

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == PlacaRemovida.ToUpper()))
            {
                Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");

                // Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                

                int horas = Convert.ToInt32(Console.ReadLine().Trim());
                decimal valorTotal = precoInicial + horas*precoPorHora;

                // Remover a placa digitada da lista de veículos

                veiculos.Remove(PlacaRemovida);
                Console.WriteLine($"\n O veículo {PlacaRemovida} foi removido e o preço total foi de: R$ {valorTotal.ToString("F2")}\n");
            }
            else
            {
                Console.WriteLine("\n Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string n in veiculos)
                        {
                            Console.WriteLine(n);
                        }
                // Realizar um laço de repetição, exibindo os veículos estacionados
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
