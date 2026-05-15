

public abstract class DeCarga : Veiculo
{
    public string TipoCarga { get; set; }
    protected DeCarga(string placa, string marca, string modelo, int ano, string tipoCarga, decimal valor) : base(placa, marca, modelo, ano, valor)
    {
        TipoCarga = tipoCarga;
    }
}