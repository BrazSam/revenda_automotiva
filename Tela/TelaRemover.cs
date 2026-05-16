using System;
using System.Collections.Generic;

public class TelaRemover
{
    public void ExibirMenuRemover(List<Veiculo> listaVeiculos)
    {
        if (listaVeiculos == null || listaVeiculos.Count == 0)
        {
            Console.WriteLine("Não há veículos cadastrados para remover.");
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
            return;
        }

        string? opcaoRemover;

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

            opcaoRemover = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(opcaoRemover) &&
                (opcaoRemover == "1" || opcaoRemover == "2" || opcaoRemover == "3" || opcaoRemover == "4" || opcaoRemover == "5" || opcaoRemover == "6"))
            {
                Console.Clear();
                break;
            }

            Console.WriteLine("Opção inválida, por favor selecione uma opção válida.");
        }

        switch (opcaoRemover)
        {
            case "1":
                RemoverVeiculoDoTipo(listaVeiculos, typeof(Bicicleta));
                break;
            case "2":
                RemoverVeiculoDoTipo(listaVeiculos, typeof(Automovel));
                break;
            case "3":
                RemoverVeiculoDoTipo(listaVeiculos, typeof(Motocicleta));
                break;
            case "4":
                RemoverVeiculoDoTipo(listaVeiculos, typeof(Caminhonete));
                break;
            case "5":
                RemoverVeiculoDoTipo(listaVeiculos, typeof(Caminhao));
                break;
            case "6":
                RemoverVeiculoDoTipo(listaVeiculos, typeof(Utilitario));
                break;
            default:
                Console.WriteLine("Digite uma das opções acima!");
                break;
        }
    }

    private void RemoverVeiculoDoTipo(List<Veiculo> listaVeiculos, Type tipoVeiculo)
    {
        bool encontrouAlgum = false;

        foreach (Veiculo veiculo in listaVeiculos)
        {
            if (veiculo.GetType() == tipoVeiculo)
            {
                Console.WriteLine(veiculo.ExibirInformacoes());
                encontrouAlgum = true;
            }
        }

        if (!encontrouAlgum)
        {
            Console.WriteLine("Nenhum veículo desse tipo foi encontrado.");
            return;
        }

        Console.Write("Digite a placa do veículo que deseja remover: ");
        string? placaRemover = Console.ReadLine()?.Trim();

        if (string.IsNullOrWhiteSpace(placaRemover))
        {
            Console.WriteLine("Placa inválida, por favor tente novamente.");
            return;
        }

        Veiculo? veiculoParaRemover = null;

        foreach (Veiculo veiculo in listaVeiculos)
        {
            if (veiculo.GetType() == tipoVeiculo && veiculo.Placa.Equals(placaRemover, StringComparison.OrdinalIgnoreCase))
            {
                veiculoParaRemover = veiculo;
                break;
            }
        }

        if (veiculoParaRemover == null)
        {
            Console.WriteLine("Veículo não encontrado para a placa informada.");
            return;
        }

        listaVeiculos.Remove(veiculoParaRemover);
        Console.WriteLine("Veículo removido com sucesso!");
    }
}
