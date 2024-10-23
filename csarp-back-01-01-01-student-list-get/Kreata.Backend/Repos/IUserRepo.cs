﻿using Kreata.Backend.Datas.Entities;

namespace Kreata.Backend.Repos
{
    public interface IUserRepo
    {
        Task<List<User>> GetAll();
        Task<User?> GetBy(Guid id);
    }
}
