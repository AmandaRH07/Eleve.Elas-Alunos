using Alunos.Domain.Interfaces;
using Alunos.Domain.Models;
using Alunos.WebApi.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Alunos.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AlunoController : ControllerBase
	{
		private readonly IAlunoRepository _alunoRepository;

		public AlunoController(IAlunoRepository alunoRepository)
		{
			_alunoRepository = alunoRepository ?? throw new ArgumentNullException(nameof(alunoRepository));
		}

		[HttpGet]
		public IActionResult Get()
		{
			return Ok(_alunoRepository.BuscarTodos());
		}

		[HttpGet("{id}")]
		public IActionResult Get(int id)
		{
			return Ok(_alunoRepository.BuscarPorId(id));
		}

		[HttpPost]
		public IActionResult Post([FromBody] AlunoDto alunoDto)
		{
			var entity = new Aluno(alunoDto.Nome, alunoDto.Endereco, alunoDto.Email, alunoDto.Status);
			_alunoRepository.Inserir(entity);

			return Ok();
		}

		[HttpPut("{id}")]
		public IActionResult Put(int id, [FromBody] AlunoDto alunoDto)
		{
			var entity = _alunoRepository.BuscarPorId(id);

			entity.AlterarAluno(alunoDto.Nome, alunoDto.Endereco, alunoDto.Email, alunoDto.Status);
			_alunoRepository.Alterar(entity);

			return Ok(entity);
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			_alunoRepository.Excluir(id);
			return Ok();
		}
	}
}
