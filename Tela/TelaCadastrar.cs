public class TelaCadastrar
{

    public string ExibirCadastro()
    {
        while(true)
        {
            Console.WriteLine("Bem-vindo ao ABC BOLAS carros && Motos!");
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
        
        if(!String.IsNullOrWhiteSpace(opcao) && (opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4" || opcao == "5" || opcao == "6" || opcao == "0"))
            Console.Clear();
            return opcao;
        
        System.Console.WriteLine("Opção inválida, por favor selecione uma opção válida.");
        }
    }

    // public string Marca { get; set; }
    // public string Modelo { get; set; }
    // public int Ano { get; set; }
    // public decimal Valor { get; set; }

    //encapsulamento 
    private void CadastroDadosBase(Veiculo veiculo) //caminhete marca modelo ano valor
    {
        System.Console.Write("Digite A MARCA do Veiculo: ");
        veiculo.Marca = Console.ReadLine();

        System.Console.Write("Digite O MODELO do Veiculo: ");
        veiculo.Modelo = Console.ReadLine();

        System.Console.Write("Digite O ANO do Veiculo: ");
        veiculo.Ano = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Digite O VALOR do Veiculo: R$");
        veiculo.Valor = Convert.ToDecimal(Console.ReadLine());

    }

    public Caminhonete CadastrarCaminhonete()
    {
        Caminhonete c = new Caminhonete("", "", 0, "", 0);
        CadastroDadosBase(c); //aqui pega os dados bases
        
        System.Console.Write("Digite o tipo de carga: ");
        c.TipoCarga = Console.ReadLine();

        return c;
    }

    public Automovel CadastrarAutomovel()
    {
        Automovel a = new Automovel("", "", 0, 0, 0);
        CadastroDadosBase(a); //aqui pega os dados bases
        
        System.Console.Write("Digite a CAPACIDADE de passageiros: ");
        a.CapacidadePassageiros = Convert.ToInt32(Console.ReadLine());
        
        return a;
    }

    public Motocicleta CadastrarMotocicleta()
    {
        Motocicleta m = new Motocicleta("", "", 0, 0, .0m);
        CadastroDadosBase(m); //aqui pega os dados bases
        
        System.Console.Write("Digite a CAPACIDADE de passageiros: ");
        m.CapacidadePassageiros = Convert.ToInt32(Console.ReadLine());
        
        return m;
    }
    public Bicicleta CadastrarBicicleta()
    {
        Bicicleta b = new Bicicleta("", "", 0, 0, 0);
        CadastroDadosBase(b); //aqui pega os dados bases
        
        System.Console.Write("Digite a CAPACIDADE de passageiros: ");
        b.CapacidadePassageiros = Convert.ToInt32(Console.ReadLine());
        
        return b;
    }

    public Utilitario CadastrarUtilitario()
    {
        Utilitario u = new Utilitario("", "", 0, "", 0);
        CadastroDadosBase(u); //aqui pega os dados bases
        
        System.Console.Write("Digite os outros detalhes: ");
        u.Outros = Console.ReadLine();
        
        return u;
    }
    public Caminhao CadastrarCaminhao()
    {
        Caminhao c = new Caminhao("", "", 0, "", 0);

        System.Console.Write("Digite o tipo de carga: ");
        c.TipoCarga = Console.ReadLine();
        
        return c;
    }
    
}