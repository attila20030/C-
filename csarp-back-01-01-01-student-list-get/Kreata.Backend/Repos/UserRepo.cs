using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Repos
{
    public class userRepo : IUserRepo
    {

        private readonly KretaInMemoryContext _dbContext;

        public userRepo(KretaInMemoryContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<User>> GetAll()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<User?> GetBy(Guid id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(t => t.Id == id);
        }

        Task<List<User>> IUserRepo.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<User?> IUserRepo.GetBy(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
