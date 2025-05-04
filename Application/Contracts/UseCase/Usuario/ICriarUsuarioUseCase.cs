using Application.Models.Usuario;

namespace Application.Contracts.UseCase.Usuario
{
    public interface ICriarUsuarioUseCase
    {
        Task<CriarUsuarioOutpuDto> ExecutarAsync(CriarUsuarioInputDto input);
    }
}