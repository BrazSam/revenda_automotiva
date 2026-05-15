public class Caminhao : DeCarga
{
    public Caminhao(string placa, string marca, string modelo, int ano, string tipoCarga, decimal valor) : base(placa, marca, modelo, ano, tipoCarga, valor)
    {

    }

    public override string ExibirInformacoes()
    {
        return $"Utilitário: Marca: {Marca} Modelo: {Modelo} Ano: ({Ano}) e Tipo de Carga({TipoCarga}) ";
    }
}