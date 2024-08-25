using Alunos.Domain.Enums;

namespace Alunos.WebApi.DTO
{
	public class CursoDto
	{
		public string Titulo { get; set; }
		public string Descricao { get; set; }
		public Status Status { get; set; }

		public int IdProfessor { get; set; }
	}
}
