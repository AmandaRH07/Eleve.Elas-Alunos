using Alunos.Domain.Enums;
using Alunos.Domain.Interfaces;
using Alunos.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Alunos.Data.Repository
{
	public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository
	{
		public AlunoRepository(AlunosContexto contexto) : base(contexto)
		{
		}

		public bool AlunoAtivo(int id)
		{
			var alunoStatus = _contexto.Set<Aluno>().FirstOrDefault(x => x.Id == id).Status;
			return alunoStatus == Status.Ativo ? true : false;
		}
	}
}
