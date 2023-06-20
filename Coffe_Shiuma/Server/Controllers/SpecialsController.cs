using Coffe_Shiuma.Server.Models;
using Coffe_Shiuma.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffe_Shiuma.Server.Controllers
{
    [Route("specials")]
    [ApiController]
    public class SpecialsController : ControllerBase
    {
        private readonly CafeteriaStoreContext Context;
        public SpecialsController(CafeteriaStoreContext context)
        {
            this.Context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<CafeSpecial>>> GetSpecials()
        {
            return await Context.Specials
            .OrderByDescending(s => s.BasePrice).ToListAsync();
        }
    }
}
