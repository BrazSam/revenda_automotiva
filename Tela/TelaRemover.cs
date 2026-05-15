public class TelaRemover
{
    public string ExibirMenuRemover()
    {
        while(true)
        {
            Console.WriteLine("ABC BOLAS carros && Motos!");
            System.Console.WriteLine("Selecione o tipo de veículo que deseja remover:");
            System.Console.WriteLine("1 - Bicicleta"); 
            System.Console.WriteLine("2 - Automóvel"); 
            System.Console.WriteLine("3 - Motocicleta");
            System.Console.WriteLine("4 - Caminhonete");
            System.Console.WriteLine("5 - Caminhão");
            System.Console.WriteLine("6 - Utilitario");
            System.Console.Write("> ");

            string? opcao = Console.ReadLine();
        
        if(!String.IsNullOrWhiteSpace(opcao) && (opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4" || opcao == "5" || opcao == "6"))
            {
            Console.Clear();
            return opcao;
            }
        
        System.Console.WriteLine("Opção inválida, por favor selecione uma opção válida.");
        }
    }
}