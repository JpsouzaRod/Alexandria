namespace Alexandria.Funcionario.Domain.Core.Models
{
    public class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataProximoEmprestimo { get; set; }
    }
}
