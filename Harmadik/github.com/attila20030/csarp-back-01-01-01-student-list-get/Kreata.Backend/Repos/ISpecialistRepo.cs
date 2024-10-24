using Kreata.Backend.Datas.Entities;

namespace Kreata.Backend.Repos
{
    public interface ISpecialistRepo
    {
        Task<List<Specialist>> GetAll();
        Task<Specialist> GetBy(Guid id);
    }
}