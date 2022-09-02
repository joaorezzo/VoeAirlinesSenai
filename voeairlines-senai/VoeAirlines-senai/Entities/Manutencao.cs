namespace VoeAirlines.Entities;
using VoeAirlines.Entities.Enums;

public class Manutencao
{
    public Manutencao(DateTime dataHora, TipoManutencao tipoManutencao, int aeronaveId, string? observacao)
    {
        DataHora = dataHora;
        TipoManutencao = tipoManutencao;
        AeronaveId = aeronaveId;
        Observacao = observacao;
    }


    //Gera Construtor desses aqui
    public int Id { get; set; }
    public DateTime DataHora { get; set; }
    public string? Observacao { get; set; }
    public TipoManutencao TipoManutencao{get;set;}
    public int AeronaveId { get; set; }
    //Não gera construtor
    public Aeronave Aeronave { get; set; } = null!;




}