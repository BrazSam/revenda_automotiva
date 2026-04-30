using System.Security.Cryptography;

public abstract class Veiculo
{
    public string Id { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public decimal Valor { get; set; }

    protected Veiculo(string marca, string modelo, int ano, decimal valor)
    {
        Id = Convert
                .ToHexString(RandomNumberGenerator.GetBytes(20))
                .ToLower()
                .Substring(0, 7);

        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Valor = valor;
    }


    public abstract string ExibirInformacoes();
}