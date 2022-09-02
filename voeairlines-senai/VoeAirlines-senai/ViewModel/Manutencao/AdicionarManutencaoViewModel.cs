using VoeAirlines.Entities.Enums;

namespace VoeAirlines.ViewModels.Manutencao;

           
    public class AdicionarManutencaoViewModel
   {
    public AdicionarManutencaoViewModel(DateTime dataHora, TipoManutencao tipoManutencao, string? observacao, int aeronaveId)
    {
        DataHora = dataHora;
        this.tipoManutencao = tipoManutencao;
        Observacao = observacao;
        AeronaveId = aeronaveId;
    }

    public DateTime DataHora { get; set; }
         public TipoManutencao tipoManutencao { get; set; }
        public string? Observacao { get; set; }
        public int AeronaveId { get; set; }
   }

    
    
