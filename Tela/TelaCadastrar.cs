public class TelaCadastrar
{

    public string ExibirCadastro()
    {
        while (true)
        {
            Console.WriteLine("ABC BOLAS carros && Motos!");
            System.Console.WriteLine("Selecione uma opção para cadastrar:");
            System.Console.WriteLine("1 - Bicicleta");
            System.Console.WriteLine("2 - Automóvel");
            System.Console.WriteLine("3 - Motocicleta");
            System.Console.WriteLine("4 - Caminhonete");
            System.Console.WriteLine("5 - Caminhão");
            System.Console.WriteLine("6 - Utilitario");
            System.Console.WriteLine("0 - Sair");

            System.Console.Write("> ");

            string? opcao = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(opcao) && (opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4" || opcao == "5" || opcao == "6" || opcao == "0"))
            {
                Console.Clear();
                return opcao;
            }

            System.Console.WriteLine("Opção inválida, por favor selecione uma opção válida.");
        }
    }

    private (string Placa, string Marca, string Modelo, int Ano, decimal Valor) LerDadosBase()
    {
        string placa = LerTexto("Digite a placa do veículo: ");
        string marca = LerTexto("Digite A MARCA do Veiculo: ");
        string modelo = LerTexto("Digite O MODELO do Veiculo: ");
        int ano = LerInteiro("Digite O ANO do Veiculo: ");
        decimal valor = LerDecimal("Digite O VALOR do Veiculo: R$");

        return (placa, marca, modelo, ano, valor);
    }

    private string LerTexto(string mensagem)
    {
        Console.Write(mensagem);
        return Console.ReadLine() ?? string.Empty;
    }

    private int LerInteiro(string mensagem)
    {
        while (true)
        {
            Console.Write(mensagem);
            string? texto = Console.ReadLine()?.Trim();

            if (int.TryParse(texto, out int valor))
                return valor;

            Console.WriteLine("Digite um número inteiro válido.");
        }
    }

    private decimal LerDecimal(string mensagem)
    {
        while (true)
        {
            Console.Write(mensagem);
            string? texto = Console.ReadLine()?.Trim();

            if (decimal.TryParse(texto, out decimal valor))
                return valor;

            Console.WriteLine("Digite um valor decimal válido.");
        }
    }

    private int LerCapacidadePassageiros(string mensagem)
    {
        return LerInteiro(mensagem);
    }

    public Caminhonete CadastrarCaminhonete()
    {
        var dadosBase = LerDadosBase();
        string tipoCarga = LerTexto("Digite o tipo de carga: ");

        return new Caminhonete(dadosBase.Placa, dadosBase.Marca, dadosBase.Modelo, dadosBase.Ano, dadosBase.Valor, tipoCarga);
    }

    public Automovel CadastrarAutomovel()
    {
        var dadosBase = LerDadosBase();
        int capacidadePassageiros = LerCapacidadePassageiros("Digite a CAPACIDADE de passageiros: ");

        return new Automovel(dadosBase.Placa, dadosBase.Marca, dadosBase.Modelo, dadosBase.Ano, dadosBase.Valor, capacidadePassageiros);
    }

    public Motocicleta CadastrarMotocicleta()
    {
        var dadosBase = LerDadosBase();
        int capacidadePassageiros = LerCapacidadePassageiros("Digite a CAPACIDADE de passageiros: ");

        return new Motocicleta(dadosBase.Placa, dadosBase.Marca, dadosBase.Modelo, dadosBase.Ano, dadosBase.Valor, capacidadePassageiros);
    }

    public Bicicleta CadastrarBicicleta()
    {
        var dadosBase = LerDadosBase();
        int capacidadePassageiros = LerCapacidadePassageiros("Digite a CAPACIDADE de passageiros: ");

        return new Bicicleta(dadosBase.Placa, dadosBase.Marca, dadosBase.Modelo, dadosBase.Ano, dadosBase.Valor, capacidadePassageiros);
    }

    public Utilitario CadastrarUtilitario()
    {
        var dadosBase = LerDadosBase();
        string outros = LerTexto("Digite os outros detalhes: ");

        return new Utilitario(dadosBase.Placa, dadosBase.Marca, dadosBase.Modelo, dadosBase.Ano, dadosBase.Valor, outros);
    }

    public Caminhao CadastrarCaminhao()
    {
        var dadosBase = LerDadosBase();
        string tipoCarga = LerTexto("Digite o tipo de carga: ");

        return new Caminhao(dadosBase.Placa, dadosBase.Marca, dadosBase.Modelo, dadosBase.Ano, dadosBase.Valor, tipoCarga);
    }
}
