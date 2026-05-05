public class TelaListar
{


    public void ListarNormal(List<Veiculo> listaVeiculos)
    {
        foreach(Veiculo v in listaVeiculos)
        {
            System.Console.WriteLine(v.ExibirInformacoes());
        }
        Console.ReadLine();
    }
    public void ListarPorTipo(List<Veiculo> listaVeiculos)
    {
                System.Console.WriteLine("Digite o tipo de veiculo que deseja listar:");
                System.Console.WriteLine("1 - Bicicleta"); 
                System.Console.WriteLine("2 - Automóvel"); 
                System.Console.WriteLine("3 - Motocicleta");
                System.Console.WriteLine("4 - Caminhonete");
                System.Console.WriteLine("5 - Caminhão");
                System.Console.WriteLine("6 - Utilitario");
                System.Console.Write("> ");
                string? opcaoListar = Console.ReadLine();

                switch (opcaoListar)
                {
                    case "1":
                        foreach(Veiculo v in listaVeiculos)
                        {
                            if(v is Bicicleta)
                            {
                                System.Console.WriteLine(v.ExibirInformacoes());
                            }
                        }
                        break;
                    case "2":
                        foreach(Veiculo v in listaVeiculos)
                        {
                            if(v is Automovel)
                            {
                                System.Console.WriteLine(v.ExibirInformacoes());
                            }
                        }
                        break;
                    case "3":
                        foreach(Veiculo v in listaVeiculos)
                        {
                            if(v is Motocicleta)
                            {
                                System.Console.WriteLine(v.ExibirInformacoes());
                            }
                        }
                        break;
                    case "4":
                        foreach(Veiculo v in listaVeiculos)
                        {
                            if(v is Caminhonete)
                            {
                                System.Console.WriteLine(v.ExibirInformacoes());
                            }
                        }
                        break;
                    case "5":
                        foreach(Veiculo v in listaVeiculos)
                        {
                            if(v is Caminhao)
                            {
                                System.Console.WriteLine(v.ExibirInformacoes());
                            }
                        }
                        break;
                    case "6":
                        foreach(Veiculo v in listaVeiculos)
                        {
                            if(v is Utilitario)
                            {
                                System.Console.WriteLine(v.ExibirInformacoes());
                            }
                        }
                        break;
                    default:
                    Console.WriteLine("Digite uma das opções acima!");
                    break;
                }

                Console.ReadLine();
    }
}