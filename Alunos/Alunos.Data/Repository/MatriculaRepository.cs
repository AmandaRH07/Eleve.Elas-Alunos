using Alunos.Domain.Enums;
using Alunos.Domain.Interfaces;
using Alunos.Domain.Models;

namespace Alunos.Data.Repository
{
	public class MatriculaRepository : BaseRepository<Matricula>, IMatriculaRepository
	{
		private readonly IAlunoRepository _alunoRepository;
		private readonly ICursoRepository _cursoRepository;

		public MatriculaRepository(AlunosContexto contexto,
			IAlunoRepository alunoRepository,
			ICursoRepository cursoRepository) : base(contexto)
		{
			_alunoRepository = alunoRepository;
			_cursoRepository = cursoRepository;
		}

		public bool ValidaDisponibilidadeCurso(int idCurso, int idAluno, DateTime data)
		{
			var cursoValido = _cursoRepository.CursoAtivo(idCurso);
			var alunoValido = _alunoRepository.AlunoAtivo(idAluno);
			var disponibilidadePorQtd = ValidaDisponibilidadeCursoPorQtdAlunos(idCurso);
			var disponibilidadePorData = ValidaDisponibilidadeCursoPorData(data);

			return cursoValido && alunoValido && disponibilidadePorQtd && disponibilidadePorData;
		}

		private bool ValidaDisponibilidadeCursoPorQtdAlunos(int idCurso)
		{
			var count = _contexto.Set<Matricula>()
				.Where(x => x.StatusMatricula == StatusMatricula.Ativa)
				.Count(x => x.IdCurso == idCurso);

			if (count > 2)
				return false;
			return true;
		}

		private bool ValidaDisponibilidadeCursoPorData(DateTime data)
		{
			if (data < DateTime.Today)
				return false;
			return true;
		}
	}
}
