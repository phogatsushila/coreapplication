using AutoMapper;
using coreapplication.Data;
using coreapplication.Model.Domain;
using coreapplication.Model.DTO;
using coreapplication.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace coreapplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Regions : ControllerBase
    {
        private readonly walkDbContext context;
        private readonly IResionRepository resionRepository;
        private readonly IMapper mapper;
        public Regions(walkDbContext context,IResionRepository resionRepository,IMapper mapper)
        {
            this.context = context;
            this.resionRepository = resionRepository;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> AdRegion([FromBody] AddRegionDTO addresiondto)
        {
            //var resigon = new Region
            //{
            //    Code = addresiondto.Code,
            //    Name = addresiondto.Name,
            //    Regionimageurl = addresiondto.Regionimageurl,
            //};
            //used auto mapping 
            var resigon = mapper.Map<Region>(addresiondto);
           // context.regions.Add(resigon);
           // context.SaveChanges();
           resigon=await resionRepository.AdRegion(resigon);
            var resigondto=mapper.Map<Regiondto>(resigon);
            //var resiondto = new Regiondto
            //{
            //    Name = addresiondto.Name,
            //    Code = addresiondto.Code,
            //    Regionimageurl = addresiondto.Regionimageurl,

            //};
            return CreatedAtAction(nameof(GetById),new {id= resigondto.Id}, resigondto);
        }
        [HttpGet]
        public async  Task<IActionResult> GetAll()
        {
            //var region = new List<Region>
            //{
            //    new Region
            //    {
            //        Id=Guid.NewGuid(),
            //        Name="Sushila",
            //        Code="xyz",
            //        Regionimageurl=""
            //    },
            //    new Region
            //    {
            //        Id=Guid.NewGuid(),
            //        Name="Sushila",
            //        Code="xyz",
            //        Regionimageurl=""
            //    }
            //    };  using await with using dbcontext
            //var region= await context.regions.ToListAsync();
            // to used repository then called dbcontext
            var region = await resionRepository.GetAll();
            //using dto 
            //var resiondto = new List<Regiondto>();
            //foreach(var regions in region)
            //{
            //    resiondto.Add(new Regiondto()
            //    {
            //        Id= regions.Id,
            //        Code= regions.Code,
            //        Name= regions.Name,
            //        Regionimageurl=regions.Regionimageurl,

            //    });

            //}
            return Ok(mapper.Map<List<Regiondto>>(region));
            }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
           // var region = context.regions.Find(id);
           // var region = await context.regions.FirstOrDefaultAsync(x=>x.Id==id);
            var region = await resionRepository.GetById(id);
            if (region==null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<Regiondto>(region));
        }
        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> DeleteById(Guid id) 
        {
           // var region = await context.regions.FirstOrDefaultAsync(x => x.Id == id);
           var region=await resionRepository.DeleteById(id);
            if (region == null)
            {
                return NotFound();
            } 
              //context.regions.Remove(region);
           //await context.SaveChangesAsync();
           //mapping using automapper
           var delresion=mapper.Map<Regiondto>(region);
            return Ok(delresion);

        }

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> PutById([FromRoute] Guid id, UpdateRegionDTO updateresiondto) 
        {
            //mapping dto to mapper
            var region=mapper.Map<Region>(updateresiondto);
            // var region = await  context.regions.FirstOrDefaultAsync(x => x.Id == id);
           // var region = await resionRepository.PutById(id, updateresiondto);
            if (region == null)
            {
                return NotFound();
            }
            //region.Code = updateresiondto.Code;
            //region.Regionimageurl = updateresiondto.Regionimageurl;
            //region.Name = updateresiondto.Name;
            var resiondto = mapper.Map<Regiondto>(region);
            await context.SaveChangesAsync();
            return Ok(resiondto);
        }
    }
    }

