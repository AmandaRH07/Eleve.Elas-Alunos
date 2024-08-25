using Alunos.Domain.Enums;

namespace Alunos.WebApi.DTO
{
	public class AlunoDto
	{
		public string Nome { get; set; }
		public string Endereco { get; set; }
		public string Email { get; set; }
		public Status Status { get; set; }
	}
}
