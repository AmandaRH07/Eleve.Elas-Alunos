using Alunos.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alunos.Data.Map
{
	public class ProfessorMap : IEntityTypeConfiguration<Professor>
	{
		public void Configure(EntityTypeBuilder<Professor> builder)
		{
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Nome)
				.HasColumnType("nvarchar(150)")
				.IsRequired();

			builder.Property(x => x.Endereco)
				.HasColumnType("nvarchar(150)")
				.IsRequired();

			builder.Property(x => x.Email)
				.HasColumnType("nvarchar(150)")
				.IsRequired();
		}
	}
}
