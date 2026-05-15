public class Bicicleta : DePassageiros
{
    public Bicicleta(string placa, string marca, string modelo, int ano, decimal valor, int capacidadePassageiros) : base(placa, marca, modelo, ano, valor, capacidadePassageiros)
    {

    }

    public override string ExibirInformacoes()
    {
        return ($"Bicicleta: {Marca} {Modelo} ({Ano})");
    }
}