public class Automovel : DePassageiros
{
    public Automovel(string placa, string marca, string modelo, int ano, decimal valor, int capacidadePassageiros) : base(placa, marca, modelo, ano, valor, capacidadePassageiros)
    {
        
    }

    public override string ExibirInformacoes()
    {
        return ($"Automóvel: {Marca} {Modelo} ({Ano}), Capacidade de Passageiros: {CapacidadePassageiros}");
    }
}