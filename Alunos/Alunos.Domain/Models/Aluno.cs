namespace Alunos.Domain.Models
{
	public class Aluno : IEntityBase
	{
		public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
		public List<AlunoCurso> AlunoCurso { get; set; }

	}
}
