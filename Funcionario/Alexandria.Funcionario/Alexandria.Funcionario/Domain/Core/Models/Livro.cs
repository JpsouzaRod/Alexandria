using Alexandria.Funcionario.Domain.Core.Enum;

namespace Alexandria.Funcionario.Domain.Core.Models
{
    public class Livro
    {
        public int CodigoLivro { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public EnumStatusLivro Status { get; private set; } = EnumStatusLivro.DISPONIVEL;
    }
}
