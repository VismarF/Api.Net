namespace Application.Models.Usuario
{
    public record CriarUsuarioInputDto
    {
        public string Nome { get; init; }
        public string Cpf { get; init; }
        public string Email { get; init; }
        public string Telefone { get; init; }
    }
}
