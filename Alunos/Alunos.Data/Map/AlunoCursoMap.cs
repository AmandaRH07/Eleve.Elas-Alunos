using Alunos.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alunos.Data.Map
{
	public class AlunoCursoMap : IEntityTypeConfiguration<AlunoCurso>
	{
		public void Configure(EntityTypeBuilder<AlunoCurso> builder)
		{
			builder.Property(x => x.Id).UseIdentityColumn();

			builder.HasKey(x => x.Id);

			builder.HasKey(x => new { x.IdAluno, x.IdCurso });

			builder.HasOne(x => x.Aluno)
				.WithMany(x => x.AlunoCurso)
				.HasForeignKey(x => x.IdAluno);

			builder.HasOne(x => x.Curso)
				.WithMany(x => x.AlunoCurso)
				.HasForeignKey(x => x.IdAluno);
		}
	}
}
