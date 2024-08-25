using Alunos.Domain.Enums;
using Alunos.Domain.Interfaces;
using Alunos.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Alunos.Data.Repository
{
	public class CursoRepository : BaseRepository<Curso>, ICursoRepository
	{
		public CursoRepository(AlunosContexto contexto) : base(contexto)
		{
		}

		public bool CursoAtivo(int id)
		{
			var cursoStatus = _contexto.Set<Curso>().FirstOrDefault(x => x.Id == id).Status;
			return cursoStatus == Status.Ativo ? true : false;
		}
	}
}
