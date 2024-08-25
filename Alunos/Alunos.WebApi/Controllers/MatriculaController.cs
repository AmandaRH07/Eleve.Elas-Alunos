using Alunos.Domain.Enums;
using Alunos.Domain.Interfaces;
using Alunos.Domain.Models;
using Alunos.WebApi.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Alunos.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MatriculaController : ControllerBase
	{
		private readonly IMatriculaRepository _matriculaRepository;

		public MatriculaController(IMatriculaRepository matriculaRepository)
		{
			_matriculaRepository = matriculaRepository ?? throw new ArgumentNullException(nameof(matriculaRepository));
		}

		[HttpGet]
		public IActionResult Get()
		{
			return Ok(_matriculaRepository.BuscarTodos());
		}

		[HttpGet("{id}")]
		public IActionResult Get(int id)
		{
			return Ok(_matriculaRepository.BuscarPorId(id));
		}

		[HttpPost]
		public IActionResult Post([FromBody] MatriculaDto matriculaDto)
		{
			var aindaPodeReceberAlunos = _matriculaRepository.ValidaDisponibilidadeCurso(matriculaDto.IdCurso, matriculaDto.IdAluno, matriculaDto.DataMatricula);

			if (aindaPodeReceberAlunos)
			{
				var entity = new Matricula(matriculaDto.DataMatricula,
					matriculaDto.StatusMatricula,
					matriculaDto.IdAluno,
					matriculaDto.IdCurso);

				_matriculaRepository.Inserir(entity);

				return Ok();
			}
			else
			{
				return BadRequest("Não foi possível matricular o aluno no curso!");
			}
		}

		[HttpPut("{id}")]
		public IActionResult Put(int id, [FromBody] StatusMatricula statusMatricula)
		{
			var entity = _matriculaRepository.BuscarPorId(id);

			entity.AlterarMatricula(statusMatricula);
			_matriculaRepository.Alterar(entity);

			return Ok(entity);
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			_matriculaRepository.Excluir(id);
			return Ok();
		}
	}
}
