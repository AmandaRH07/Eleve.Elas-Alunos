using Alunos.Domain.Models;

namespace Alunos.Domain.Interfaces
{
	public interface IMatriculaRepository : IBaseRepository<Matricula>
	{
		bool ValidaDisponibilidadeCurso(int idCurso, int idAluno, DateTime data);
	}
}
