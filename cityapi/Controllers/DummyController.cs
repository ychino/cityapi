using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cityapi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace cityapi.Controllers
{
    public class DummyController : Controller
    {
        private CityInfoContext _ctx;

        public DummyController(CityInfoContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet]
        [Route("api/testdatabase")]
        public IActionResult TestDatabase()
        {
            return Ok();
        }
    }
}