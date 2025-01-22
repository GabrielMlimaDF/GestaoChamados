using GestaoChamados.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GestaoChamados.Data.Mappings
{
    public class TipoMap: IEntityTypeConfiguration<Tipo>
    {
        public void Configure(EntityTypeBuilder<Tipo> builder)
        {
            // Definir a tabela
            builder.ToTable("Tipo");

            // Definir a chave primária
            builder.HasKey(t => t.Id);
            // Definir a geração automática para o campo 'Id'
            builder.Property(t => t.Id)
                   .ValueGeneratedOnAdd();            // Define que o Id será auto-incrementado (IDENTITY)

            // Configurar a coluna 'Descricao'
            builder.Property(t => t.Descricao)
                   .IsRequired()                      // Tornar a coluna 'Descricao' obrigatória
                   .HasMaxLength(50);                 // Limitar o comprimento máximo da string
        }
    }
}
