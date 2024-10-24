using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Repos
{
    public class PlaceRepo : IPlaceRepo
    {
        private readonly KretaInMemoryContext _dbContext;

        public PlaceRepo(KretaInMemoryContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Place>> GetAll()
        {
            return await _dbContext.Places.ToListAsync();
        }

        public async Task<Place?> GetBy(Guid id)
        {
            return await _dbContext.Places.FirstOrDefaultAsync(s => s.Id == id);
        }
    }
}
