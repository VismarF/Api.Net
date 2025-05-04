using Application.Contracts.Repository.UsuarioRepository;
using Application.Contracts.UseCase.Usuario;
using Application.Models.Usuario;
using DocumentValidation.Validates;
using Domain.Entity;

namespace Application.UseCase.Usuario
{
    public class CriarUsuarioUseCase : ICriarUsuarioUseCase
    {
        private readonly IUsuarioRepository _usuariorepository;

        public CriarUsuarioUseCase(
            IUsuarioRepository usuarioRepository  
        )
        {
            _usuariorepository = usuarioRepository;
        }
        public async Task<CriarUsuarioOutpuDto> ExecutarAsync(CriarUsuarioInputDto input)
        {
            var validadorCpf = new CpfValidate();
            if (!validadorCpf.MathValidate(input.Cpf))
            {
                throw new Exception("Cpf inválido");
            }
            //commit teste
            var cpf = input.Cpf.Replace(".", "").Replace("-", "");
            var user = await _usuariorepository.GetByNameAndCpf(input.Nome, input.Cpf);
            if (user != null)
            {
                throw new Exception("Usuário já cadastrado");
            }

            var usuario = new UsuarioEntity(
                input.Nome,
                cpf,
                input.Email,
                input.Telefone
            );

            await _usuariorepository.CreateAsync(usuario);

            return new CriarUsuarioOutpuDto
            {
                Id = usuario.Id
            };
        }
    }
}