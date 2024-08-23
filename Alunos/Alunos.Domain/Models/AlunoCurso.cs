namespace Alunos.Domain.Models
{
	public class AlunoCurso : IEntityBase
	{
		public int Id { get; set; }
		public int IdAluno { get; set; }
		public int IdCurso { get; set; }
		public Aluno Aluno { get; set; }
		public Curso Curso { get; set; }
	}
}
