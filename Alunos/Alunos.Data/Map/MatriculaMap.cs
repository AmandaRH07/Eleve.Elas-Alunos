using Alunos.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alunos.Data.Map
{
	public class MatriculaMap : IEntityTypeConfiguration<Matricula>
	{
		public void Configure(EntityTypeBuilder<Matricula> builder)
		{
			builder.HasKey(x => x.Id);

			builder.Property(x => x.DataMatricula)
				.HasColumnType("nvarchar(20)")
				.IsRequired();

			builder.Property(x => x.StatusMatricula)
				.IsRequired();

			builder.HasIndex(x => new { x.IdAluno, x.IdCurso }).IsUnique();

		}
	}
}
