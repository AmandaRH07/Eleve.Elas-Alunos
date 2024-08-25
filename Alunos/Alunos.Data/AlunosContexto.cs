using Alunos.Data.Map;
using Alunos.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Alunos.Data
{
	public class AlunosContexto : DbContext
	{
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Matricula> Matricula { get; set; }
        //public DbSet<AlunoCurso> AlunoCurso { get; set; }

		public AlunosContexto(DbContextOptions<AlunosContexto> options) : base(options)
        {
                
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new AlunoMap());
			base.OnModelCreating(modelBuilder);

			modelBuilder.ApplyConfiguration(new CursoMap());
			base.OnModelCreating(modelBuilder);

			modelBuilder.ApplyConfiguration(new ProfessorMap());
			base.OnModelCreating(modelBuilder);

			modelBuilder.ApplyConfiguration(new MatriculaMap());
			base.OnModelCreating(modelBuilder);
		}

	}
}
