using Alunos.Domain.Enums;

namespace Alunos.WebApi.DTO
{
	public class MatriculaDto
	{
		public DateTime DataMatricula { get; set; }
		public StatusMatricula StatusMatricula { get; set; }

		public int IdAluno { get; set; }
		public int IdCurso { get; set; }
	}
}
