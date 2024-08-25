using Alunos.Domain.Interfaces;
using Alunos.Domain.Models;

namespace Alunos.Data.Repository
{
	public class BaseRepository<T> : IBaseRepository<T> where T : class, IEntityBase
	{
		protected readonly AlunosContexto _contexto;

		public BaseRepository(AlunosContexto contexto)
		{
			_contexto = contexto ?? throw new ArgumentNullException(nameof(contexto));
		}

		public void Alterar(T entity)
		{
			_contexto.Set<T>().Update(entity);
			_contexto.SaveChanges();
		}

		public List<T> BuscarTodos()
		{
			return _contexto.Set<T>().ToList();
		}

		public T BuscarPorId(int id)
		{
			return _contexto.Set<T>().FirstOrDefault(x => x.Id == id);
		}

		public void Excluir(int id)
		{
			var entity = BuscarPorId(id);
			_contexto.Set<T>().Remove(entity);
			_contexto.SaveChanges();
		}

		public void Inserir(T entity)
		{
			_contexto.Set<T>().Add(entity);
			_contexto.SaveChanges();
		}

		public void Dispose()
		{
			_contexto.Dispose();
		}
	}
}
