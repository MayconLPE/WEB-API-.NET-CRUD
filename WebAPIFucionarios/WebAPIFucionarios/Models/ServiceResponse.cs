namespace WebAPIFucionarios.Models
{
    public class ServiceResponse<T> // T dados variados.
    {
        public T? Dados { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public bool Sucesso { get; set; } = true;

    }
}
