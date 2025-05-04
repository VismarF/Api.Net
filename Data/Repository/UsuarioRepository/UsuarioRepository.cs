using Application.Contracts.Repository.UsuarioRepository;
using Data.Context;
using Data.Repository.BaseRepository;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository.UsuarioRepository
{
    public class UsuarioRepository(AppDbContext dbContext) : BaseRepository<UsuarioEntity>(dbContext), IUsuarioRepository
    {
        public async Task<UsuarioEntity?> GetByNameAndCpf(string nome, string cpf)
        {
            return await _dbSet
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Nome == nome && x.Cpf == cpf);
        }
    }
}
