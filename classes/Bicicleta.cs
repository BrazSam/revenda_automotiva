public class Bicicleta : DePassageiros
{
    public Bicicleta(string marca, string modelo, int ano, int capacidadePassageiros,  decimal valor) : base(marca, modelo, ano, capacidadePassageiros,valor)
    {

    }

    public override string ExibirInformacoes()
    {
        return ($"Bicicleta: {Marca} {Modelo} ({Ano})");
    }
}