using Alunos.Data.Repository;
using Alunos.Domain.Interfaces;
using Alunos.Domain.Models;
using Alunos.WebApi.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Alunos.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CursoController : ControllerBase
	{
		private readonly ICursoRepository _cursoRepository;

		public CursoController(ICursoRepository cursoRepository)
		{
			_cursoRepository = cursoRepository ?? throw new ArgumentNullException(nameof(cursoRepository));
		}

		[HttpGet]
		public IActionResult Get()
		{
			return Ok(_cursoRepository.BuscarTodos());
		}

		[HttpGet("{id}")]
		public IActionResult Get(int id)
		{
			return Ok(_cursoRepository.BuscarPorId(id));
		}

		[HttpPost]
		public IActionResult Post([FromBody] CursoDto cursoDto)
		{
			var entity = new Curso(cursoDto.Titulo, cursoDto.Descricao, cursoDto.IdProfessor, cursoDto.Status);
			_cursoRepository.Inserir(entity);

			return Ok();
		}

		[HttpPut("{id}")]
		public IActionResult Put(int id, [FromBody] CursoDto cursoDto)
		{
			var entity = _cursoRepository.BuscarPorId(id);

			entity.AlterarCurso(cursoDto.Titulo, cursoDto.Descricao, cursoDto.Status);
			_cursoRepository.Alterar(entity);

			return Ok(entity);
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			_cursoRepository.Excluir(id);
			return Ok();
		}
	}
}
