public class Motocicleta : DePassageiros
{
    public Motocicleta(string marca, string modelo, int ano, int capacidadePassageiro, decimal valor) : base(marca, modelo, ano, capacidadePassageiro,valor)
    {
        
    }

    public override string ExibirInformacoes()
    {
        return $"Motocicleta: {Marca} {Modelo} ({Ano})";
    }
}