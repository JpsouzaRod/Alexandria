using Alexandria.Funcionario.Domain.Core.DTO;
using Alexandria.Funcionario.Domain.Core.Models;

namespace Alexandria.Funcionario.Domain.Core.Interface.Usecase
{
    public interface IUsecaseFuncionario
    {
        public BaseResponse<string> CadastrarLivro(Livro livro);
        public BaseResponse<string> CadastrarAluno(Aluno aluno);
        public BaseResponse<string> CadastrarEmprestimo(Emprestimo emprestimo);
        public BaseResponse<string> CadastrarDevolucao(int codigoLivro);
        public BaseResponse<string> RenovarEmprestimo(int codigoLivro);
    }
}
