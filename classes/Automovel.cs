public class Automovel : DePassageiros
{
    public Automovel(string placa, string marca, string modelo, int ano, int capacidadePassageiros, decimal valor) : base(placa, marca, modelo, ano, capacidadePassageiros, valor)
    {
        
    }

    public override string ExibirInformacoes()
    {
        return ($"Automóvel: {Marca} {Modelo} ({Ano}), Capacidade de Passageiros: {CapacidadePassageiros}");
    }
}