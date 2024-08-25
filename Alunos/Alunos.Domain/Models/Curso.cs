
using Alunos.Domain.Enums;

namespace Alunos.Domain.Models
{
	public class Curso : IEntityBase
	{
		public int Id { get; set; }
		public string Titulo { get; set; }
		public string Descricao { get; set; }
		public Status Status { get; set; }

		public int? IdProfessor { get; set; }
		public Professor? Professor { get; set; }

		public Curso() { }

		public Curso(string titulo, string descricao, int idProfessor, Status status)
		{
			Titulo = titulo;
			Descricao = descricao;
			IdProfessor = idProfessor;
			Status = status;
		}

		public Curso AlterarCurso(string novoTitulo, string novoDescricao, Status status)
		{
			Titulo = Alterar(novoTitulo, Titulo);
			Descricao = Alterar(novoDescricao, Descricao);
			Status = status;

			return this;
		}

		private string Alterar(string campoNovo, string campoAntigo)
			=> campoAntigo != campoNovo ? campoNovo : campoAntigo;
	}
}
