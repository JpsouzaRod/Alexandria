using Alexandria.Funcionario.Domain.Core.Models;

namespace Alexandria.Funcionario.Domain.Core.Interface.Adapter.SQL
{
    public interface IRepositoryEmprestimo
    {
        Task CadastrarEmprestimo(Emprestimo emprestimo);
        Task<Emprestimo> ConsultarEmprestimo(int codigoLivro);
        Task CadastrarDevolucao(int codigoLivro);
        Task CadastrarRenovacao(int codigoLivro);
    }
}
