using Alunos.Domain.Enums;

namespace Alunos.Domain.Models
{
	public class Matricula
	{
		public int Id { get; set; }
		public DateTime DataMatricula { get; set; }
		public StatusMatricula StatusMatricula { get; set; }

		public int IdAluno { get; set; }
		public int IdCurso { get; set; }

		public Aluno Aluno { get; set; }
		public Curso Curso { get; set; }
	}
}
