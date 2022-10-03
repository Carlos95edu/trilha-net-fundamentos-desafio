using DesafioEstacionamento.Models;
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoHora = 0;

Console.WriteLine("Bem vindo ao nosso estacionamento\n"+
                  "Digite o preço inicial");
precoInicial = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite o preço por hora:");
precoHora = Convert.ToDecimal(Console.ReadLine());

ClasseEstacionamento opcao = new ClasseEstacionamento(precoInicial, precoHora);

bool exibirMenu = true;
Console.Clear();
Console.WriteLine("Digite a opção desejada:");

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a opção desejada:");
    Console.WriteLine("1 - Cadastrar veículo \n" +
                      "2 - Remover veículo\n" +
                      "3 - Listar veículos\n" +
                      "4 - Encerrar");
    switch (Console.ReadLine())
    { 
        case "1":
        opcao.AdicionarVeiculo();
            break;
        case "2":
        opcao.RemoverVeiculo();
            break;
        case "3":
        opcao.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    Console.WriteLine("Pressione uma tecla pra continuar");
    Console.ReadLine();
}
Console.WriteLine("Programa encerrado");

