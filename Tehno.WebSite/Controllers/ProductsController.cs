using Tehno.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tehno.WebSite.Models;

namespace Tehno.WebSite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileTorroService torroService)
        {
            this.TorroService = torroService;
        }
        public JsonFileTorroService TorroService { get; }

        [HttpGet]
        public IEnumerable<Torro> Get()
        {
            return TorroService.GetTorro();
        }

    }
}
