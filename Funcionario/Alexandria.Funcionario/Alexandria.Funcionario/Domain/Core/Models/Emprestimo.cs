using Alexandria.Funcionario.Domain.Core.Enum;

namespace Alexandria.Funcionario.Domain.Core.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public int CodigoLivro { get; set; }
        public int MatriculaAluno { get; set; }
        public DateTime DataEmprestimo { get; private set; }
        public DateTime DataEntrega { get; private set; }
        public DateTime DataDevolucao { get; set; }
        public EnumStatusEmprestimo StatusEmprestimo { get; private set; } = EnumStatusEmprestimo.ABERTO;
        public bool EmprestimoRenovado { get; set; }
    }
}
