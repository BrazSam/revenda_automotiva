internal class Program
{
    //Samuel Braz dos Santos e Thiago Kovalski
    private static void Main(string[] args)
    {
        List<Veiculo> listaVeiculos = new List<Veiculo>();       
        TelaPrincipal tela = new TelaPrincipal();
        TelaCadastrar cadastrar = new();
        
        while (true)
        {
        //obter oq o usuario quer fazer, cadastrar ou listar
        string opcaoDigitadaMenuPrincipal = tela.ExibirMenuPrincipal();


        if(opcaoDigitadaMenuPrincipal == "1")
            {

                string opcaoDigitada = cadastrar.ExibirCadastro();

                    switch (opcaoDigitada)
                {
                    
                    case "1":
                        Veiculo bicicleta = cadastrar.CadastrarBicicleta();
                        listaVeiculos.Add(bicicleta);
                        break;
                    case "2":
                        Veiculo automovel = cadastrar.CadastrarAutomovel();
                        listaVeiculos.Add(automovel);
                        break;
                    case "3":
                        Veiculo motocicleta = cadastrar.CadastrarMotocicleta();
                        listaVeiculos.Add(motocicleta);
                        break;
                    case "4":
                        Veiculo caminhonete = cadastrar.CadastrarCaminhonete();
                        listaVeiculos.Add(caminhonete);
                        break;
                    case "5":
                        Veiculo caminhao = cadastrar.CadastrarCaminhao();
                        listaVeiculos.Add(caminhao);
                        break;
                    case "6":
                        Veiculo utilitario = cadastrar.CadastrarUtilitario();
                        listaVeiculos.Add(utilitario);
                        break;
                    default:                    
                        Console.WriteLine("Digite uma das opções acima!");
                        break;
                }
            }
            
        if(opcaoDigitadaMenuPrincipal == "2")
            {
                TelaListar listar = new();
                listar.ListarNormal(listaVeiculos);
            }
        
        if(opcaoDigitadaMenuPrincipal == "3")
            {
                TelaListar listar = new();
                listar.ListarPorTipo(listaVeiculos);
            }
    }
}
}