public class Utilitario : DePassageiros
{   
    public string Outros{get; set;}
    public Utilitario(string marca, string modelo, int ano, string outros, decimal valor) : base(marca, modelo, ano,  valor)
    {
        Outros = outros;
    }

    public override string ExibirInformacoes()
    {
        return $"Utilitário: Marca: {Marca} Modelo: {Modelo} Ano: ({Ano}) e Outros: ({Outros}) ";
    }
}