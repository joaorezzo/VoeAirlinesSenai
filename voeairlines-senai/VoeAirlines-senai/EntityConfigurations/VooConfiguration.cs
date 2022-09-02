using VoeAirlines.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VoeAirlines.EntityConfigurations;

public class VooConfiguration : IEntityTypeConfiguration<Voo>
{
    public void Configure(EntityTypeBuilder<Voo> builder)
    {
        builder.ToTable("Voos");
        builder.HasKey(v=>v.Id);
        
        builder.Property(v=>v.Origem)
               .IsRequired()
               .HasMaxLength(3);
                   
        builder.Property(v=>v.DataHoraPartida)
               .IsRequired();
             

                   
        builder.Property(v=>v.DataHoraChegada)
               .IsRequired();
        
        //Relacionamentos

        //Piloto com o Voo
        //Piloto ele tem N Voos
        //1 Voo é vinculado a apenas UM piloto
        builder.HasOne(v=>v.Piloto)
               .WithMany(p=>p.Voos)
               .HasForeignKey(v=>v.PilotoId);

        //Voo com a Aeronave
        //Voo esta vinculado a uma aeronave
        //Aeronave ela pode ter vários voos.
        builder.HasOne(v=>v.Aeronave)
               .WithMany(a=>a.Voos)
               .HasForeignKey(v=>v.AeronaveId);

       //Cancelamento
       builder.HasOne(v=>v.Cancelamento)
              .WithOne(c=>c.Voo)
              .HasForeignKey<Cancelamento>(c=>c.VooId);

        

               
        




    }
}
