public abstract class DePassageiros : Veiculo
{

    public int CapacidadePassageiros { get; set; }
    protected DePassageiros(string marca, string modelo, int ano, int capacidadePassageiros, decimal valor) : base(marca, modelo, ano, valor)
    {
        CapacidadePassageiros = capacidadePassageiros;
    }

    public DePassageiros(string marca, string modelo, int ano, decimal valor) : base(marca, modelo, ano, valor)
    {
    }
}