using System.Security.Cryptography;

public abstract class Veiculo
{
    public string Id { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }

    public Veiculo(string marca, string modelo, int ano)
    {
        Id = Convert
                .ToHexString(RandomNumberGenerator.GetBytes(20))
                .ToLower()
                .Substring(0, 7);
            
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }

    // public abstract void ExibirInformacoes();
}