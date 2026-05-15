public class Caminhao : DeCarga
{
    public Caminhao(string placa, string marca, string modelo, int ano, decimal valor, string tipoCarga) : base(placa, marca, modelo, ano, valor, tipoCarga)
    {

    }

    public override string ExibirInformacoes()
    {
        return $"Utilitário: Marca: {Marca} Modelo: {Modelo} Ano: ({Ano}) e Tipo de Carga({TipoCarga}) ";
    }
}