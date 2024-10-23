using Kreata.Backend.Datas.Entities;

namespace Kreata.Backend.Repos
{
    public interface IUserRepo1
    {
        Task<List<User>> GetAll();
        Task<User?> GetBy(Guid id);
    }
}