using Alexandria.Funcionario.Domain.Core.Models;

namespace Alexandria.Funcionario.Domain.Core.Interface.Adapter.SQL
{
    public interface IRepositoryAluno
    {
        Task CadastrarAluno(Aluno aluno);
        Task<Aluno> ConsultarAluno(int matricula);

    }
}
