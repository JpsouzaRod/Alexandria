using Alexandria.Funcionario.Adapter.SQL.Context;
using Alexandria.Funcionario.Domain.Core.Interface.Adapter.SQL;
using Alexandria.Funcionario.Domain.Core.Models;

namespace Alexandria.Funcionario.Adapter.SQL.Repository
{
    public class RepositoryEmprestimo : IRepositoryEmprestimo
    {
        public RepositoryEmprestimo(ContextSQL _context) 
        { 
            context = _context;
        }

        public readonly ContextSQL context;

        public async Task CadastrarDevolucao(string codigoLivro)
        {
            using (var conn = context.CreateConnection())
            {

            }
        }

        public async Task CadastrarEmprestimo(Emprestimo emprestimo)
        {
            using (var conn = context.CreateConnection())
            {

            }
        }

        public async Task<Emprestimo> ConsultarEmprestimo(string codigoLivro)
        {
            using (var conn = context.CreateConnection())
            {

            }
        }
    }
}
