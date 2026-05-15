

public abstract class DeCarga : Veiculo
{
    public string TipoCarga { get; set; }
    protected DeCarga(string placa, string marca, string modelo, int ano, decimal valor, string tipoCarga) : base(placa, marca, modelo, ano, valor)
    {
        TipoCarga = tipoCarga;
    }
}