using Alunos.Domain.Interfaces;
using Alunos.Domain.Models;

namespace Alunos.Data.Repository
{
	public class ProfessorRepository : BaseRepository<Professor>, IProfessorRepository
	{
		public ProfessorRepository(AlunosContexto contexto) : base(contexto)
		{
		}
	}
}
