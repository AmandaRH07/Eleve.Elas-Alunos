using Alunos.Domain.Models;

namespace Alunos.Domain.Interfaces
{
	public interface ICursoRepository : IBaseRepository<Curso>
	{
		bool CursoAtivo(int id);
	}
}
