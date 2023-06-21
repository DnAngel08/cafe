using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coffe_Shiuma.Server.Models;
using Coffe_Shiuma.Shared;
using Microsoft.EntityFrameworkCore;


namespace Coffe_Shiuma.Server.Controllers
{
    [Route("bebidas")]
    [ApiController]
    public class BebidasController : ControllerBase
    {
        private readonly CafeteriaStoreContext Context;
        public BebidasController(CafeteriaStoreContext context)
        {
            this.Context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Bebida>>> GetToppings()
        {
            return await Context.Toppings
            .OrderBy(t => t.Name).ToListAsync();
        }
    }
}
