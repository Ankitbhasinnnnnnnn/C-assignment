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
    public class PlayerController : ControllerBase
    {
        // GET: api/Player
        private readonly CRICKETContext _cricketcontext;
        public PlayerController(CRICKETContext cricketss)
        {
            _cricketcontext = cricketss;
        }
        [HttpGet]

        public IActionResult Get3()
        {
            var getPlayer = _cricketcontext.Player.ToList();
            return Ok(getPlayer);
        }

        // GET: api/Player/5
      /*  [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Player
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Player/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
