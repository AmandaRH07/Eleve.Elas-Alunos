using Alunos.Domain.Interfaces;
using Alunos.Domain.Models;
using Alunos.WebApi.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Alunos.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProfessorController : ControllerBase
	{
		private readonly IProfessorRepository _professorRepository;

		public ProfessorController(IProfessorRepository professorRepository)
		{
			_professorRepository = professorRepository ?? throw new ArgumentNullException(nameof(professorRepository));
		}

		[HttpGet]
		public IActionResult Get()
		{
			return Ok(_professorRepository.BuscarTodos());
		}

		[HttpGet("{id}")]
		public IActionResult Get(int id)
		{
			return Ok(_professorRepository.BuscarPorId(id));
		}

		[HttpPost]
		public IActionResult Post([FromBody] ProfessorDto professorDto)
		{
			var entity = new Professor(professorDto.Nome, professorDto.Email);
			_professorRepository.Inserir(entity);

			return Ok();
		}

		[HttpPut("{id}")]
		public IActionResult Put(int id, [FromBody] ProfessorDto professorDto)
		{
			var entity = _professorRepository.BuscarPorId(id);

			entity.AlterarProfessor(professorDto.Nome, professorDto.Email);
			_professorRepository.Alterar(entity);

			return Ok(entity);
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			_professorRepository.Excluir(id);
			return Ok();
		}
	}
}
