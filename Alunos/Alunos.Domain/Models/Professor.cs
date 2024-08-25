namespace Alunos.Domain.Models
{
	public class Professor : IEntityBase
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Email { get; set; }

		public List<Curso>? Curso { get; set; }

		public Professor() { }

		public Professor(string titulo, string email)
		{
			Nome = titulo;
			Email = email;
		}

		public Professor AlterarProfessor(string novoNome, string novoEmail)
		{
			Nome = Alterar(novoNome, Nome);
			Email = Alterar(novoEmail, Email);

			return this;
		}

		private string Alterar(string campoNovo, string campoAntigo)
			=> campoAntigo != campoNovo ? campoNovo : campoAntigo;

	}
}
