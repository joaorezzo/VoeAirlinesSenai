using VoeAirlinesSenai.Contexts;
using VoeAirlines.Entities;
using VoeAirlines.ViewModels;

namespace VoeAirlinesSenai.Services;

public class AeronaveService{
    
    
    //propriedade para injeção de dependência
    private readonly VoeAirlinesContext _context;

    public AeronaveService(VoeAirlinesContext context)
    {
        _context = context;
    }

    public DetalhesAeronaveViewModel AdicionarAeronave(AdicionarAeronaveViewModel dados)
    {
        

        var aeronave = new Aeronave(dados.Fabricante, dados.Modelo, dados.Codigo);

        _context.Add(aeronave);
        _context.SaveChanges();

        return new DetalhesAeronaveViewModel
        (
            aeronave.Id,
            aeronave.Fabricante,
            aeronave.Modelo,
            aeronave.Codigo
        );
    }

    internal object ListarAeronavePeloId(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ListarAeronaveViewModel>ListarAeronave(){
        
         return _context.Aeronaves.Select(a=>new ListarAeronaveViewModel(a.Id,a.Modelo,a.Codigo));
     }
    public void ExcluirAeronave(int id){
        var aeronave = _context.Aeronaves.Find(id);
        if(aeronave != null){
            _context.Remove(aeronave);
            _context.SaveChanges();
        }
    }
  
    public DetalhesAeronaveViewModel? AtualizarAeronave(AtualizarAeronaveViewModel dados){
              
              var aeronave = _context.Aeronaves.Find(dados.Id);
              if(aeronave != null){
                  aeronave.Fabricante = dados.Fabricante;
                  aeronave.Modelo = dados.Modelo;
                  aeronave.Codigo = dados.Codigo;
                  _context.Update(aeronave);
                  _context.SaveChanges();
                  return new DetalhesAeronaveViewModel(aeronave.Id,aeronave.Fabricante,aeronave.Modelo,aeronave.Codigo);

              }
              return null; 
     
    }

    



}