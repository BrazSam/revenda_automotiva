using System;
using System.Collections.Generic;

public class TelaRemover
{
    private List<Veiculo> listaVeiculos = new List<Veiculo>();

    public void ExibirMenuRemover()
    {
        string? opcaoRemover = Console.ReadLine();

        while (true)
        {
            Console.WriteLine("ABC BOLAS carros && Motos!");
            Console.WriteLine("Selecione o tipo de veículo que deseja remover:");
            Console.WriteLine("1 - Bicicleta");
            Console.WriteLine("2 - Automóvel");
            Console.WriteLine("3 - Motocicleta");
            Console.WriteLine("4 - Caminhonete");
            Console.WriteLine("5 - Caminhão");
            Console.WriteLine("6 - Utilitario");
            Console.Write("> ");


            if (string.IsNullOrWhiteSpace(opcaoRemover) ||
                (opcaoRemover != "1" && opcaoRemover != "2" && opcaoRemover != "3" && opcaoRemover != "4" && opcaoRemover != "5" && opcaoRemover != "6"))
            {
                Console.WriteLine("Opção inválida, por favor selecione uma opção válida.");
                continue;
            }

            Console.Clear();
            break;
        }

        switch (opcaoRemover)
        {
            case "1":
                foreach (Veiculo v in listaVeiculos)
                {
                    if (v is Bicicleta)
                    {
                        Console.WriteLine(v.ExibirInformacoes());
                    }
                    RemoverVeiculo(v);
                }

                break;
            case "2":
                foreach (Veiculo v in listaVeiculos)
                {
                    if (v is Automovel)
                    {
                        Console.WriteLine(v.ExibirInformacoes());
                    }
                    RemoverVeiculo(v);
                }
               
                break;
            case "3":
                foreach (Veiculo v in listaVeiculos)
                {
                    if (v is Motocicleta)
                    {
                        Console.WriteLine(v.ExibirInformacoes());
                    }
                    RemoverVeiculo(v);
                }
                
                break;
            case "4":
                foreach (Veiculo v in listaVeiculos)
                {
                    if (v is Caminhonete)
                    {
                        Console.WriteLine(v.ExibirInformacoes());
                    }
                    RemoverVeiculo(v);
                }
               
                break;
            case "5":
                foreach (Veiculo v in listaVeiculos)
                {
                    if (v is Caminhao)
                    {
                        Console.WriteLine(v.ExibirInformacoes());
                    }
                    RemoverVeiculo(v);
                }
                
                break;
            case "6":
                foreach (Veiculo v in listaVeiculos)
                {
                    if (v is Utilitario)
                    {
                        Console.WriteLine(v.ExibirInformacoes());
                    }
                    RemoverVeiculo(v);
                }
                
                break;
            default:
                Console.WriteLine("Digite uma das opções acima!");
                break;
        }
    }

    private void RemoverVeiculo(Veiculo veiculo)
    {
        Console.WriteLine("Digite a placa do veículo que deseja remover:");
        string? placaRemover = Console.ReadLine()?.Trim();

        if (string.IsNullOrWhiteSpace(placaRemover))
        {
            Console.WriteLine("Placa inválida, por favor tente novamente.");
            return;
        }

        foreach (Veiculo v in listaVeiculos)
        {
            if (v == veiculo)
            {
                listaVeiculos.Remove(veiculo);
                Console.WriteLine("Veículo removido com sucesso!");
                return;
            }
        }

        Console.WriteLine("Placa inválida, por favor tente novamente.");

    }
}
