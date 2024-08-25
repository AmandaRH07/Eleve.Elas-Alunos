namespace Alunos.Domain.Interfaces
{
	public interface IBaseRepository<T>
	{
		T BuscarPorId(int id);
		List<T> BuscarTodos();
		void Inserir(T entity);
		void Alterar(T entity);
		void Excluir(int id);

	}
}
