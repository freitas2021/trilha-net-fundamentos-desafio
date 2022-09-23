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

            // Pedir para o usuário escolher o tipo de veiculos
            Console.WriteLine($"Escolha o tipo de veículo: \n");
            Console.WriteLine($"1 - Hatch\n2 - Sedan\n3 - Picape");

            string tipo = "";
            switch (Console.ReadLine())
            {
                //recebe os valores de acordo com o tipo de veículo escolhido
                //*IMPLEMENTADO!!*
                case "1":

                    tipo = "Hatch";
                    precoInicial = 5;
                    precoPorHora = 3;
                    Console.WriteLine($"Tipo: {tipo} - Preço Inicial: {precoInicial:c} - Preço por Hora: {precoPorHora:c} ");
                    break;

                case "2":
                    tipo = "Sedan";
                    precoInicial = 7;
                    precoPorHora = 4;
                    Console.WriteLine($"Tipo: {tipo} - Preço Inicial: {precoInicial:c} - Preço por Hora: {precoPorHora:c} ");
                    break;
                case "3":
                    tipo = "Picape";
                    precoInicial = 10;
                    precoPorHora = 5;
                    Console.WriteLine($"Tipo: {tipo} - Preço Inicial: {precoInicial:c} - Preço por Hora: {precoPorHora:c} ");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTADO!!*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTADO!!*
            string placa = "";
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                //// *IMPLEMENTADO!!*
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal   
                // *IMPLEMENTADO!!*             
                int horas = 0;
                decimal valorTotal = 0;
                horas = int.Parse(Console.ReadLine());
                valorTotal = precoInicial + (horas * precoPorHora);

                //Informa os valores a serem pagos
                //Remove a placa digitada da lista de veículos
                // *IMPLEMENTADO!!*
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: {valorTotal:c}");
                veiculos.Remove(placa);
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTADO!!*
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
