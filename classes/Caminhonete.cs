public class Caminhonete : DeCarga
{
    public Caminhonete(string placa, string marca, string modelo, int ano, decimal valor, string tipoCarga) : base(placa, marca, modelo, ano, valor, tipoCarga)
    {

    }

    public override string ExibirInformacoes()
    {
        return $"Caminhonete: {Marca} {Modelo} ({Ano}) ({TipoCarga})";
    }
}