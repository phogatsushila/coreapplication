using coreapplication.Data;
using coreapplication.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace coreapplication.Repository
{
    public class WalkRepository : IwalkRepository
    {
        private readonly walkDbContext walkDbContext;
        public WalkRepository(walkDbContext dbcontext)
        {
            walkDbContext = dbcontext;

        }
        public async Task<Walk> Create(Walk obj)
        {
            await walkDbContext.walks.AddAsync(obj);
            await walkDbContext.SaveChangesAsync();
            return obj;
        }

        public async Task<List<Walk>> GetallWalk()
        {
            var result= await walkDbContext.walks.Include("Dificulity").Include("Region").ToListAsync();
            return result;

        }

        public async Task<Walk> GetallWalkId(Guid id)
        {
            return await walkDbContext.walks.
                Include("Dificulity").
                Include("Region").FirstOrDefaultAsync(x => x.Id == id);

        }


    }
}
