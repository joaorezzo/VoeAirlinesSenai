using VoeAirlines.Entities.Enums;

namespace VoeAirlines.ViewModels.Manutencao;

    public class ListarManutencaoViewModel
    {
    public ListarManutencaoViewModel(int id, DateTime dataHora, TipoManutencao tipoManutencao, string? observacao, int aeronaveId)
    {
        Id = id;
        DataHora = dataHora;
        this.tipoManutencao = tipoManutencao;
        Observacao = observacao;
        AeronaveId = aeronaveId;
    }

    public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public TipoManutencao tipoManutencao { get; set; }
        public string? Observacao { get; set; }
        public int AeronaveId { get; set; }
    }

        
