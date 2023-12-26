using Alexandria.Funcionario.Domain.Core.DTO;
using Alexandria.Funcionario.Domain.Core.Interface.Usecase;
using Alexandria.Funcionario.Domain.Core.Models;

namespace Alexandria.Funcionario.Domain.Application.Usecase
{
    public class UsecaseFuncionario : IUsecaseFuncionario
    {
        public BaseResponse<string> CadastrarAluno(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        public BaseResponse<string> CadastrarDevolucao(int codigoLivro)
        {
            throw new NotImplementedException();
        }

        public BaseResponse<string> CadastrarEmprestimo(Emprestimo emprestimo)
        {
            throw new NotImplementedException();
        }

        public BaseResponse<string> CadastrarLivro(Livro livro)
        {
            throw new NotImplementedException();
        }

        public BaseResponse<string> RenovarEmprestimo(int codigoLivro)
        {
            throw new NotImplementedException();
        }
    }
}
