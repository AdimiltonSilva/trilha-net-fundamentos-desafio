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
            // Implementado !!!!!
            string placa;
            Boolean opcao = true;
            
            while (opcao)
            {
                Console.Clear();
                Console.WriteLine("Cadastrando um veículo");
                Console.WriteLine("----------------------");
                Console.WriteLine("Digite a placa do veículo para estacionar ou não digite nada para retornar ao menu:");
                placa = Console.ReadLine();

                if (placa == "") 
                    opcao = false;
                else 
                {
                    if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                    {
                        Console.WriteLine($"{placa}, veículo já cadastrado! Tente novamente.");
                    } else
                    {
                        veiculos.Add(placa);
                        Console.WriteLine($"{placa}, veículo cadastrado com sucesso!");
                    }

                    Console.WriteLine("Pressiona uma tecla para continuar...");
                    Console.ReadLine();
                }
            }
        }

        public void RemoverVeiculo()
        {
            // Implementado !!!!!
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = "";
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int horas = 0;
                decimal valorTotal = 0;

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                horas = Convert.ToInt32(Console.ReadLine());

                valorTotal = this.precoInicial + (this.precoPorHora * ((horas > 0 ) ? (horas - 1) : (0) ));

                this.veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: {valorTotal.ToString("C")}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Implementado !!!!!
            
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                Console.WriteLine("-----------------------------");

                int indice = 0;
                foreach (string placa in veiculos)
                {
                    Console.WriteLine($"{indice + 1} => {placa}");
                    indice++;
                }
                if (indice > 0)
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine($"Total de {indice} veículos estacionados.");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
