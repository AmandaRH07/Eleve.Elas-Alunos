using Alunos.Data.Map;
using Alunos.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Alunos.Data
{
	public class AlunosContexto : DbContext
	{
        public DbSet<Aluno> Aluno { get; set; }

        public AlunosContexto(DbContextOptions<AlunosContexto> options) : base(options)
        {
                
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new AlunoMap());
			base.OnModelCreating(modelBuilder);
		}
	}
}
