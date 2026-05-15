using System.Security.Cryptography;

public abstract class Veiculo
{
    public string Placa { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public decimal Valor { get; set; }

    protected Veiculo(string placa, string marca, string modelo, int ano, decimal valor)
    {
        Placa = placa;
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Valor = valor;
    }


    public abstract string ExibirInformacoes();
}