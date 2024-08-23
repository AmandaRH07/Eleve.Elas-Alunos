namespace Alunos.Domain.Models
{
	public class Professor : IEntityBase
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Email { get; set; }
		public List<Curso> Curso { get; set; }

	}
}
