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
    public class MatchesController : ControllerBase
    {
        private readonly CRICKETContext _cricketcontext;
        public MatchesController(CRICKETContext cricketss)
        {
            _cricketcontext = cricketss;
        }
        // GET: api/Matches
        [HttpGet]
        public IActionResult Get2()
        {
            var getMatches = _cricketcontext.Matches.ToList();
            return Ok(getMatches);
        }

        // GET: api/Matches/5
       // [HttpGet("{id}", Name = "Get")]
       // public string Get(int id)
      //  {
        //    return "value";aaaaaaaaa
       // }

        // POST: api/Matches
  //      [HttpPost]
    //    public void Post([FromBody] string value)
      //  {
        //}

        // PUT: api/Matches/5
 //       [HttpPut("{id}")]
   //     public void Put(int id, [FromBody] string value)
     //   {
       // }

        // DELETE: api/ApiWithActions/5
   //     [HttpDelete("{id}")]
     //   public void Delete(int id)
       // {
        //}
    }
}
