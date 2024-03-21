using EasyJob.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyJob.Infra.Data.EntitiesConfiguration
{
    internal class AnuncioConfiguration : IEntityTypeConfiguration<Anuncio>
    {
        public void Configure(EntityTypeBuilder<Anuncio> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Titulo).HasMaxLength(25).IsRequired();
            builder.Property(x => x.Descricao).HasMaxLength(250).IsRequired();

        }
    }
}
