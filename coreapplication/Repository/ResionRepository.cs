using coreapplication.Data;
using coreapplication.Model.Domain;
using coreapplication.Model.DTO;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace coreapplication.Repository
{
    public class ResionRepository : IResionRepository
    {
        private readonly walkDbContext dbcontext;
        public ResionRepository(walkDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public async Task<Region> AdRegion(Region obj)
        {
           await dbcontext.regions.AddAsync(obj);
           await dbcontext.SaveChangesAsync();
            return obj;
        }

        public async Task<Region> DeleteById(Guid id)
        {
            var resion=await dbcontext.regions.FirstAsync(r => r.Id == id);
            if (resion != null) 
            {
                dbcontext.regions.Remove(resion);
                await dbcontext.SaveChangesAsync();
                return resion;
            }
            else
            {
                return null;
            }
            
        }

        public async Task<List<Region>> GetAll()
        {
           return await dbcontext.regions.ToListAsync();
        }

        public async Task<Region> GetById(Guid id)
        {
            return await dbcontext.regions.FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<Region> PutById(Guid id, UpdateRegionDTO obj)
        {
            var region = await dbcontext.regions.FirstOrDefaultAsync(x => x.Id == id);
            if (region == null)
            {
                return null;
            }
            region.Code = obj.Code;
            region.Regionimageurl = obj.Regionimageurl;
            region.Name = obj.Name;
            await dbcontext.SaveChangesAsync();
            return region;
        }
    }
}
