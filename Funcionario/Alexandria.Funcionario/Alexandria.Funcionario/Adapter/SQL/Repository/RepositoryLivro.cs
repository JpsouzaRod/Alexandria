using Alexandria.Funcionario.Adapter.SQL.Context;
using Alexandria.Funcionario.Domain.Core.Interface.Adapter.SQL;
using Alexandria.Funcionario.Domain.Core.Models;
using Dapper;

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
                var sql = "INSERT INTO Livro VALUES (@codigo, @titulo, @autor, @status)";
                await conn.ExecuteAsync(sql, 
                    new { 
                        livro.CodigoLivro, 
                        livro.Titulo, 
                        livro.Autor, 
                        livro.Status 
                    });
            }
        }

        public async Task<Livro> ConsultarLivro(int codigoLivro)
        {
            using (var conn = context.CreateConnection())
            {
                var sql = "SELECT * FROM Livro WHERE CodigoLivro = @codigo";
                var livro = await conn.QueryFirstOrDefaultAsync<Livro>(sql,
                    new
                    {
                        codigoLivro,
                    });

                return livro;

            }
        }
    }
}
