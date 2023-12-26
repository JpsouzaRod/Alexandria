using Alexandria.Funcionario.Adapter.SQL.Context;
using Alexandria.Funcionario.Domain.Core.Interface.Adapter.SQL;
using Alexandria.Funcionario.Domain.Core.Models;
using System.Data;

namespace Alexandria.Funcionario.Adapter.SQL.Repository
{
    public class RepositoryAluno : IRepositoryAluno
    {
        public RepositoryAluno(ContextSQL _context) 
        {
            context = _context;
        }

        public readonly ContextSQL context;

        public async Task CadastrarAluno(Aluno aluno)
        {
            using(var conn = context.CreateConnection())
            {

            }
        }

        public async Task<Aluno> ConsultarAluno(int matricula)
        {
            using (var conn = context.CreateConnection())
            {

            }
        }
    }
}
