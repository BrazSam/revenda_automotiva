public class Bicicleta : DePassageiros
{
    public Bicicleta(string placa, string marca, string modelo, int ano, int capacidadePassageiros,  decimal valor) : base(placa, marca, modelo, ano, capacidadePassageiros,valor)
    {

    }

    public override string ExibirInformacoes()
    {
        return ($"Bicicleta: {Marca} {Modelo} ({Ano})");
    }
}