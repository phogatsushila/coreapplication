using coreapplication.Model.Domain;
using coreapplication.Model.DTO;

namespace coreapplication.Repository
{
    public interface IwalkRepository
    {
        Task<Walk> Create(Walk obj);
        Task<List<Walk>> GetallWalk();
        Task<Walk?> GetallWalkId(Guid id);
    }
}
