using Alexandria.Funcionario.Adapter.SQL.Context;
using Alexandria.Funcionario.Domain.Core.Enum;
using Alexandria.Funcionario.Domain.Core.Interface.Adapter.SQL;
using Alexandria.Funcionario.Domain.Core.Models;
using Dapper;
using System;

namespace Alexandria.Funcionario.Adapter.SQL.Repository
{
    public class RepositoryEmprestimo : IRepositoryEmprestimo
    {
        public RepositoryEmprestimo(ContextSQL _context) 
        { 
            context = _context;
        }

        public readonly ContextSQL context;

        public async Task CadastrarDevolucao(int codigoLivro)
        {
            using (var conn = context.CreateConnection())
            {
                var emprestimo = await ConsultarEmprestimo(codigoLivro);
                if (emprestimo != null) 
                {
                    var emprestimoSql = "UPDATE Emprestimo " +
                        "SET DataEntrega = @dataEntrega, " +
                        "SET StatusEmprestimoId = @novoStatus " +
                        "WHERE Id = @emprestimoId";

                    await conn.ExecuteAsync(emprestimoSql, 
                        new { 
                            DateTime.Now, 
                            EnumStatusEmprestimo.FECHADO, 
                            emprestimo.Id 
                        });

                    var livroSql = "UPDATE Livro " +
                       "SET StatusLivro = 0 " +
                       "WHERE CodigoLivro = @codLivro";

                    await conn.ExecuteAsync(livroSql, 
                        new { 
                            DateTime.Now, 
                            EnumStatusLivro.DISPONIVEL,
                            emprestimo.Id 
                        });

                    if (DateTime.Now.Date > emprestimo.DataDevolucao.Date)
                    {
                        var alunoSql = "UPDATE Aluno " +
                       "SET DataProximoEmprestimo = @tempoAfastamento " +
                       "WHERE Matricula = @matricula";

                        var tempoAfastamento = DateTime.Now.AddDays(7);

                        await conn.ExecuteAsync(alunoSql, 
                            new { 
                                tempoAfastamento, 
                                emprestimo.MatriculaAluno 
                            });
                    }
                }
            }
        }

        public async Task CadastrarEmprestimo(Emprestimo emprestimo)
        {
            using (var conn = context.CreateConnection())
            {

                var livroSql = "UPDATE Livro " +
                   "SET StatusLivro = 1 " +
                   "WHERE CodigoLivro = @codLivro";

                await conn.ExecuteAsync(livroSql,
                    new
                    {
                        DateTime.Now,
                        EnumStatusLivro.DISPONIVEL,
                        emprestimo.Id
                    });
            }
        }

        public async Task CadastrarRenovacao(int codigoLivro)
        {
            using (var conn = context.CreateConnection())
            {
                var emprestimo = await ConsultarEmprestimo(codigoLivro);

                if (DateTime.Now.Date <= emprestimo.DataDevolucao.Date)
                {
                    if (!emprestimo.EmprestimoRenovado)
                    {
                        var sqlRenovacao = "UPDATE Emprestimo" +
                           "SET DataDevolucao = @novaDataDevolucao," +
                           "SET EmprestimoRenovado = 1 " +
                           "WHERE Id = @EmprestimoId";

                        var novoPrazoDevolucao = DateTime.Now.AddDays(7);

                        await conn.ExecuteAsync(sqlRenovacao,
                            new
                            {
                                novoPrazoDevolucao,
                                emprestimo.Id
                            });
                    }
                }
            }
        }

        public async Task<Emprestimo> ConsultarEmprestimo(int codigoLivro)
        {
            using (var conn = context.CreateConnection())
            {
                var sql = "SELECT * FROM Emprestimo " +
                    "WHERE CodigoLivro = @codigoLivro AND " +
                    "StatusEmprestimoId = @novoStatusLivro";
                var emprestimo = await conn.QueryFirstOrDefaultAsync<Emprestimo>(sql,
                    new
                    {
                        codigoLivro,
                        EnumStatusLivro.DISPONIVEL
                    });

                return emprestimo;
            }
        }
    }
}
