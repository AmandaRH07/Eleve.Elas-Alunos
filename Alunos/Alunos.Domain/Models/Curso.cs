using System.Globalization;

namespace Alunos.Domain.Models
{
	public class Curso : IEntityBase
	{
		public int Id { get; set; }
		public string Titulo { get; set; }
		public string Descricao { get; set; }

		public int IdProfessor { get; set; }
		public Professor Professor { get; set; }

		public List<AlunoCurso> AlunoCurso { get; set; }
	}
}
