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
            Console.WriteLine("\nDigite a placa do veículo:\n");
            veiculos.Add(Console.ReadLine());
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("\nDigite a placa do veículo:\n");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("\nDigite a quantidade de horas que o veículo permaneceu estacionado:\n");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;
                veiculos.Remove(placa);
                Console.WriteLine($"\nO veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}\n");
            }
            else
            {
                Console.WriteLine("\nDesculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.\n");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("\nOs veículos estacionados são:\n");
                int aux = 0;
                foreach (string i in veiculos)
                {
                    Console.WriteLine(i);
                    aux++;
                }
            }
            else
            {
                Console.WriteLine("\nNão há veículos estacionados.\n");
            }
        }
    }
}
