using Alexandria.Funcionario.Domain.Core.Enum;

namespace Alexandria.Funcionario.Domain.Core.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public int CodigoLivro { get; set; }
        public int MatriculaAluno { get; set; }
        public DateTime DataEmprestimo { get; private set; } = DateTime.Now;
        public DateTime DataEntrega { get; private set; } = DateTime.Now.AddDays(7);
        public DateTime DataDevolucao { get; set; }
        public EnumStatusEmprestimo StatusEmprestimo { get; private set; } = EnumStatusEmprestimo.ABERTO;
    }
}
