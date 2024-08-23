namespace Alunos.Domain.Models
{
	public class Curso : IEntityBase
	{
		public int Id { get; set; }
		public string Titulo { get; set; }
		public string Descricao { get; set; }

		public List<Aluno> Alunos { get; set; }
	}
}
