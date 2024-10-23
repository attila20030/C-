﻿using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Repos
{
    public class ParentRepo : IParentRepo
    {
        private readonly KretaInMemoryContext _dbContext;

        public ParentRepo(KretaInMemoryContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Parent>> GetAll()
        {
            return await _dbContext.Parents.ToListAsync();
        }

        public Task<Parent> GetBy(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
