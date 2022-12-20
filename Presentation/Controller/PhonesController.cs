using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tosin_WGCNDDNE_WebServices.Domain;
using Tosin_WGCNDDNE_WebServices.Presentation.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tosin_WGCNDDNE_WebServices.Presentation.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhonesController : ControllerBase
    {
        // GET: api/<PhonesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Iphone", "Samsung" };
        }

        // GET api/<PhonesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "1";
        }

        // POST api/<PhonesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PhonesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PhonesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
