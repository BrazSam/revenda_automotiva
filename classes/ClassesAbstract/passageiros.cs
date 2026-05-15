public abstract class DePassageiros : Veiculo
{

    public int CapacidadePassageiros { get; set; }
    protected DePassageiros(string placa, string marca, string modelo, int ano, decimal valor, int capacidadePassageiros) : base(placa, marca, modelo, ano, valor)
    {
        CapacidadePassageiros = capacidadePassageiros;
    }

    public DePassageiros(string placa, string marca, string modelo, int ano, decimal valor) : base(placa, marca, modelo, ano, valor)
    {
    }
}