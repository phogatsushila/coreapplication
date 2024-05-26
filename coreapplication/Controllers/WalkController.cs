using AutoMapper;
using coreapplication.Model.Domain;
using coreapplication.Model.DTO;
using coreapplication.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coreapplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalkController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IwalkRepository walkrepository;
        public WalkController(IMapper mapper,IwalkRepository walkrespository) 
        {
            _mapper = mapper;
            walkrepository= walkrespository;

        }
        [HttpPost]
        public async Task<IActionResult> create( AddWalkDTO walkobj)
        {
            var wakmapping = _mapper.Map<Walk>(walkobj);
            await walkrepository.Create(wakmapping);
            return Ok(_mapper.Map<walkdto>(wakmapping));
        }
        [HttpGet]
        public async Task<IActionResult> GetAllWalk()
        {
            var walkobj= walkrepository.GetallWalk();
            return Ok(_mapper.Map<walkdto>(walkobj));
        }
        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetAllWalkbyid(Guid id)
        {
            var walkobj = await  walkrepository.GetallWalkId(id);
            if (walkobj == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<walkdto>(walkobj));
        }
        //[HttpPut]
        //public async Task<IActionResult> Addwalk(Walk obj)
        //{
                
        //}
    }
}
