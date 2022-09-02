using VoeAirlines.Entities.Enums;

namespace VoeAirlines.ViewModels.Manutencao;
public class AtualizarManutencaoViewModel
{
    public AtualizarManutencaoViewModel(DateTime dataHora, TipoManutencao tipoManuntecao, string? observacao, int aeronaveId)
    {
        DataHora = dataHora;
        this.TipoManutencao = tipoManuntecao;
        Observacao = observacao;
        AeronaveId = aeronaveId;
    }

    public DateTime DataHora { get; set; }
    public TipoManutencao TipoManutencao { get; set; }
    public string? Observacao { get; set; }
    public int AeronaveId { get; set; }

}


