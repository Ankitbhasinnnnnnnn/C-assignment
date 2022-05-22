using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRICKET.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRICKET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StadiumController : ControllerBase
    {
        // GET: api/Player
        private readonly CRICKETContext _cricketcontext;
        public StadiumController(CRICKETContext cricketss)
        {
            _cricketcontext = cricketss;
        }
        [HttpGet]
        public IActionResult Get4()
        {
            var getStadium = _cricketcontext.Stadium.ToList();
            return Ok(getStadium);
        }
        //GET: api/Stadium
      
       // public IEnumerable<string> Get()
        //{
          //  return new string[] { "value1", "value2" };
        //}

        // GET: api/Stadium/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
          //  return "value";
        //}

        // POST: api/Stadium
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        // PUT: api/Stadium/5
        //[HttpPut("{id}")]
       // public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
