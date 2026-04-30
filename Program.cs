internal class Program
{
    //Samuel Braz dos Santos e Thiago Kovalski
    private static void Main(string[] args)
    {
        List<Veiculo> listaVeiculos = new List<Veiculo>();       
        TelaPrincipal tela = new TelaPrincipal();
        
        while (true)
        {
        string opcaoDigitada = tela.ExibirMenuPrincipal();
        
        if(opcaoDigitada == "0")
            break;

        //1 - Cadastrar dados veiculo
        if(opcaoDigitada == "1")
            {
                TelaCadastrar cadastrar = new();

                listaVeiculos.Add(cadastrar.CadastrarCaminhonete());

            }
        
        foreach(Veiculo v in listaVeiculos)
            {
                v.ExibirInformacoes();
            }
        Console.ReadLine();
        
        
        
        
        // else if(opcaoDigitada == "2")
        //     {
        //         TelaListar listar = new TelaListar();
        //         listar.ListarVeiculos(listaVeiculos);
        //     }
        // else if(opcaoDigitada == "3")
        //     {
                
        //     }
        //2 - listar os dados dos veiculos
        //3 - listar por tipo de veiculo
        }
    }
}