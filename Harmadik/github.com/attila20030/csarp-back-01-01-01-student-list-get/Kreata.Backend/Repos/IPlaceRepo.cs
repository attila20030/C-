using Kreata.Backend.Datas.Entities;

namespace Kreata.Backend.Repos
{
    public interface IPlaceRepo
    {
        Task<List<Place>> GetAll();
        Task<Place> GetBy(Guid id);
    }
}
