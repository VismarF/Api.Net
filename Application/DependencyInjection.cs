using Application.Contracts.UseCase.Usuario;
using Application.UseCase.Usuario;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ICriarUsuarioUseCase, CriarUsuarioUseCase>();
            return services;
        }
    }
}
