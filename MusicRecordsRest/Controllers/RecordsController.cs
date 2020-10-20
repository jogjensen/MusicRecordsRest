using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicRecordsRest.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//azure http://recordsrest.azurewebsites.net/api/Records

namespace MusicRecordsRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordsController : ControllerBase
    {
        #region StaticList

        private static readonly List<Records> records = new List<Records>()
        {
            new Records(1,"Back in Black", "AC/DC", 1988, 5),
            new Records(2,"Madonna", "Into The Groove", 1984, 2),
            new Records(3,"Slayer", "Raining Blood", 1987, 4)
        };  

        #endregion



        // GET: api/<RecordsController>
        [HttpGet]
        public IEnumerable<Records> Get()
        {
            return records;
        }

        // GET api/<RecordsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RecordsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RecordsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RecordsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
