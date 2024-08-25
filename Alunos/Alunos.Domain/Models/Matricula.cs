using Alunos.Domain.Enums;

namespace Alunos.Domain.Models
{
	public class Matricula : IEntityBase
	{
		public int Id { get; set; }
		public DateTime DataMatricula { get; set; }
		public StatusMatricula StatusMatricula { get; set; }

		public int IdAluno { get; set; }
		public int IdCurso { get; set; }

		public Matricula(DateTime dataMatricula, StatusMatricula statusMatricula, int idAluno, int idCurso )
		{
			DataMatricula = dataMatricula;
			StatusMatricula = statusMatricula;
			IdAluno = idAluno;
			IdCurso = idCurso;
		}

		public Matricula AlterarMatricula(StatusMatricula novoStatusMatricula)
		{
			StatusMatricula = novoStatusMatricula;

			return this;
		}
	}
}
