using Alexandria.Funcionario.Domain.Core.Models;

namespace Alexandria.Funcionario.Domain.Core.Interface.Adapter.SQL
{
    public interface IRepositoryLivro
    {
        Task CadastrarLivro(Livro livro);
        Task<Livro> ConsultarLivro(int codigoLivro);
    }
}
