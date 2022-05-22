using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRICKET.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRICKET.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {

        // GET: api/Country
        private readonly CRICKETContext  _cricketcontext;
            public CountryController(CRICKETContext cricketss)
        {
            _cricketcontext = cricketss;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var getcountry = _cricketcontext.Country.ToList();
            return Ok(getcountry);
        }

        // GET: api/Country/5
      //  [HttpGet("{id}", Name = "Get")]
       //public string Ret(int id)
        //{
          //  return "value";
        //}

        // POST: api/Country
      //  [HttpPost]
       // public void Post([FromBody] string value)
        //{
        //}

        // PUT: api/Country/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE: api/ApiWithActions/5
       // [HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
