using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Repos
{
    public class SpecialistRepo : ISpecialistRepo
    {
        private readonly KretaInMemoryContext _dbContext;

        public SpecialistRepo(KretaInMemoryContext dbContext)
        {
            _dbContext = dbContext;
        }
        //Végre kész
        public async Task<List<Specialist>> GetAll()
        {
            return await _dbContext.Specialist.ToListAsync();
        }

        public async Task<Specialist?> GetBy(Guid id)
        {
            return await _dbContext.Specialist.FirstOrDefaultAsync(s => s.Id == id);
        }
    }
}
