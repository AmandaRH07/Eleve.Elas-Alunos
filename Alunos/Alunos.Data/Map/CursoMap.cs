using Alunos.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alunos.Data.Map
{
	public class CursoMap : IEntityTypeConfiguration<Curso>
	{
		public void Configure(EntityTypeBuilder<Curso> builder)
		{
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Titulo)
				.HasColumnType("nvarchar(150)")
				.IsRequired();

			builder.Property(x => x.Descricao)
				.HasColumnType("nvarchar(150)")
				.IsRequired();

			builder.Property(x => x.Status)
				.IsRequired();

			builder.HasOne(x => x.Professor)
				.WithMany(x => x.Curso)
				.HasForeignKey(x => x.IdProfessor);
		}
	}
}
