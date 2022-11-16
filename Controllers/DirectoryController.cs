using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KafkaDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectoryController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            return "Demo";
        }
    }
}
