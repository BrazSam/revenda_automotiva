public class Motocicleta : DePassageiros
{
    public Motocicleta(string placa, string marca, string modelo, int ano, decimal valor, int capacidadePassageiro) : base(placa, marca, modelo, ano, valor, capacidadePassageiro)
    {
        
    }

    public override string ExibirInformacoes()
    {
        return $"Motocicleta: {Marca} {Modelo} ({Ano})";
    }
}