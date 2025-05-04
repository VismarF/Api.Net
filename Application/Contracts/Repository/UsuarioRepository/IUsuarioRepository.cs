using Application.Contracts.Repository.BaseRepository;
using Domain.Entity;

namespace Application.Contracts.Repository.UsuarioRepository
{
    public interface IUsuarioRepository : IBaseRepository<UsuarioEntity>
    {
        Task<UsuarioEntity?> GetByNameAndCpf(string nome, string cpf);
    }
}
