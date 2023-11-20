using MagicVilla_API.Controllers.Modelos;
using MagicVilla_API.Controllers.Modelos.Dto;
using MagicVilla_API.Datos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDto> GetVillas()
        {
            return VillaStore.villalist;
        }


        [HttpGet("id:int")]
        public VillaDto GetVilla(int id)
        {
            return VillaStore.villalist.FirstOrDefault(v => v.Id == id);
        }
    }
}
