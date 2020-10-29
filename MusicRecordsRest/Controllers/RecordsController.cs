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

        private static List<Records> records = new List<Records>()
        {
            new Records(1,"Back in Black", "AC/DC", 1988, 5),
            new Records(2,"Into The Groove", "Madonna", 1984, 2),
            new Records(3,"Raining Blood", "Slayer", 1987, 4)
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
        public Records Get(int id)
        {
            return records.Find(r => r.Id == id);
        }   

        // POST api/<RecordsController>
        [HttpPost]
        public void Post([FromBody] Records value)
        {
            records.Add(value);
        }

        // PUT api/<RecordsController>/5
        [HttpPut("{id}")]
        public int Put(int id, [FromBody] Records value)
        {
            Records records = Get(id);
            if (records != null)
            {
                records.Id = value.Id;
                records.Title = value.Title;
                records.Artist = value.Artist;
                records.Yop = value.Yop;
                records.AlbumRating = value.AlbumRating;

                return 1;
            }
            return 0;
        }

        // DELETE api/<RecordsController>/5
        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            Records records = Get(id);
            if (records != null)
            {
                RecordsController.records.Remove(records);
                return 1;
            }

            return 0;
        }
    }
}
