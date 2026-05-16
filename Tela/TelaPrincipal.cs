public class TelaPrincipal
{

    public string ExibirMenuPrincipal()
    {
        while (true)
        {
            Console.WriteLine("Bem-vindo ao ABC BOLAS carros && Motos!");
            System.Console.WriteLine("Selecione o que deseja realizar:");
            System.Console.WriteLine("1 - Cadastrar Veiculo");
            System.Console.WriteLine("2 - Listar todos os Veiculos");
            System.Console.WriteLine("3 - Listar por Tipo de Veiculo");
            System.Console.WriteLine("4 - Atualizar Veículo cadastrado");
            System.Console.WriteLine("5 - Remover Veículo");
            System.Console.WriteLine("0 - Sair");
            System.Console.Write("> ");

            string? opcao = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(opcao) &&
                (opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4" || opcao == "5" || opcao == "0"))
            {
                Console.Clear();
                return opcao;
            }

            System.Console.WriteLine("Opção inválida, por favor selecione uma opção válida.");
        }
    }
}