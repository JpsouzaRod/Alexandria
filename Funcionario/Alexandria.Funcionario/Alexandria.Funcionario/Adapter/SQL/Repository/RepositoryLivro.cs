using Alexandria.Funcionario.Adapter.SQL.Context;
using Alexandria.Funcionario.Domain.Core.Interface.Adapter.SQL;
using Alexandria.Funcionario.Domain.Core.Models;

namespace Alexandria.Funcionario.Adapter.SQL.Repository
{
    public class RepositoryLivro : IRepositoryLivro
    {
        public RepositoryLivro(ContextSQL _context) 
        {
            context = _context;
        }

        public readonly ContextSQL context;
        public async Task CadastrarLivro(Livro livro)
        {
            using (var conn = context.CreateConnection())
            {

            }
        }

        public async Task<Livro> ConsultarLivro(int codigoLivro)
        {
            using (var conn = context.CreateConnection())
            {

            }
        }
    }
}
