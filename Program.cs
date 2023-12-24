using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.Clear();
Console.Write("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial: R$ ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.Write("Agora digite o preço por hora: R$ ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção: \n");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
    Console.Write("\n  Opção: ");


    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            Console.Clear();
            Console.WriteLine("   Encerrando código");

            for(int contador = 0; contador < 5; contador++)
            {
                Console.WriteLine(".");
                Thread.Sleep(1000);
            }

            Console.WriteLine("   Thayso: Obrigado por testar meu código em C# \n \n");
            Thread.Sleep(4000);
            return;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    Console.WriteLine("\n Pressione a tecla Enter para continuar");
    Console.ReadLine();
}