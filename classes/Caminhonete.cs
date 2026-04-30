public class Caminhonete : DeCarga
{
    public Caminhonete(string marca, string modelo, int ano, string tipoCarga, decimal valor) : base(marca, modelo, ano, tipoCarga, valor)
    {

    }

    public override string ExibirInformacoes()
    {
        return $"Caminhonete: {Marca} {Modelo} ({Ano}) ({TipoCarga})";
    }
}