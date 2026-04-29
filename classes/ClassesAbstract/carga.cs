

public abstract class DeCarga : Veiculo
{

    public string TipoCarga { get; set; }
    protected DeCarga(string marca, string modelo, int ano, string tipoCarga) : base(marca, modelo, ano)
    {
        TipoCarga = tipoCarga;
    }
}