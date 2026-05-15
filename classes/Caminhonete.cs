public class Caminhonete : DeCarga
{
    public Caminhonete(string placa, string marca, string modelo, int ano, string tipoCarga, decimal valor) : base(placa, marca, modelo, ano, tipoCarga, valor)
    {

    }

    public override string ExibirInformacoes()
    {
        return $"Caminhonete: {Marca} {Modelo} ({Ano}) ({TipoCarga})";
    }
}