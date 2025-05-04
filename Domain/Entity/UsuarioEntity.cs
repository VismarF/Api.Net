namespace Domain.Entity
{
    public class UsuarioEntity : BaseEntity<Guid>
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }

        public UsuarioEntity(
            string nome,
            string cpf,
            string email,
            string telefone
        )
        {
            ValidarNome(nome);
            ValidarCpf(cpf);
            ValidarEmail(email);
            ValidarTelefone(telefone);

            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
        }

        public void ValidarNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException(nameof(nome), "Nome não pode ser vazio ou nulo.");
            }

            if (nome.Length < 2)
            {
                throw new ArgumentException(nameof(nome), "Nome deve ter pelo menos 2 caracteres.");
            }

        }

        public void ValidarCpf(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
            {
                throw new ArgumentException(nameof(cpf), "Cpf não pode ser vazio ou nulo.");
            }

            if (cpf.Length < 11)
            {
                throw new ArgumentException(nameof(cpf), "Cpf deve ter pelo menos 11 caracteres.");
            }
        }

        public void ValidarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentException(nameof(email), "Email não pode ser vazio ou nulo.");
            }

            if (email.Length > 255)
            {
                throw new ArgumentException(nameof(email), "Email não pode conter mais de 255 caracteres.");
            }
        }

        public void ValidarTelefone(string telefone)
        {
            if (string.IsNullOrWhiteSpace(telefone))
            {
                throw new ArgumentException(nameof(telefone), "Telefone não pode ser vazio ou nulo.");
            }
            if (telefone.Length < 10)
            {
                throw new ArgumentException(nameof(telefone), "Telefone deve ter pelo menos 10 caracteres.");
            }
        }
    }
}