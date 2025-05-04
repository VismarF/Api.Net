using Application.Contracts.UseCase.Usuario;
using Application.Models.Usuario;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly ICriarUsuarioUseCase _criarUsuarioUseCase;
        public UsuarioController(
            ICriarUsuarioUseCase criarUsuarioUseCase
        )
        {
            _criarUsuarioUseCase = criarUsuarioUseCase;
        }


        [HttpPost]
        public async Task<CriarUsuarioOutpuDto> ExecutarAsync(CriarUsuarioInputDto input)
        {
            return await _criarUsuarioUseCase.ExecutarAsync(input);
        }
    }
}