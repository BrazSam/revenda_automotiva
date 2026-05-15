public class Utilitario : DePassageiros
{   
    public string Outros{get; set;}
    public Utilitario(string placa, string marca, string modelo, int ano, decimal valor, string outros) : base(placa, marca, modelo, ano, valor)
    {
        Outros = outros;
    }

    public override string ExibirInformacoes()
    {
        return $"Utilitário: Marca: {Marca} Modelo: {Modelo} Ano: ({Ano}) e Outros: ({Outros}) ";
    }
}