using Alunos.Domain.Models;

namespace Alunos.Domain.Interfaces
{
	public interface IAlunoRepository : IBaseRepository<Aluno>
	{
		bool AlunoAtivo(int id);
	}
}
