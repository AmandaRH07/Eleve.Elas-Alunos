using Alunos.Domain.Enums;
using System.Globalization;

namespace Alunos.Domain.Models
{
	public class Aluno : IEntityBase
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Endereco { get; set; }
		public string Email { get; set; }
		public Status Status { get; set; }

        public Aluno() { }

        public Aluno(string nome, string endereco, string email, Status status)
		{
			Nome = nome;
			Endereco = endereco;
			Email = email;
			Status = status;
		}

		public Aluno AlterarAluno(string novoNome, string novoEndereco, string novoEmail, Status status)
		{
			Nome = Alterar(novoNome, Nome);
			Endereco = Alterar(novoEndereco, Endereco);
			Email = Alterar(novoEmail, Email);
			Status = status;

			return this;
		}

		private string Alterar(string campoNovo, string campoAntigo)
			=> campoAntigo != campoNovo ? campoNovo : campoAntigo;
	}
}
