using coreapplication.Model.Domain;
using coreapplication.Model.DTO;

namespace coreapplication.Repository
{
    public interface IResionRepository
    {
        Task<List<Region>> GetAll();
        Task<Region> GetById(Guid id);
        Task<Region> AdRegion(Region obj);
        Task<Region> DeleteById(Guid id);
        Task<Region> PutById(Guid id, UpdateRegionDTO obj);

    }
}
