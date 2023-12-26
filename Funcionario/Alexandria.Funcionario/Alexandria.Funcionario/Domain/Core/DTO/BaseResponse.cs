namespace Alexandria.Funcionario.Domain.Core.DTO
{
    public class BaseResponse<T>
    {
        public bool Status { get; set; }
        public T Objeto { get; set; } 
    }
}
