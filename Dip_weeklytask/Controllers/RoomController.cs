using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Dip_weeklytask.Models;

namespace Dip_weeklytask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        //getting all room
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(fakeData.room1.Values.ToArray());
        }

        //getting room by number
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            if (fakeData.room1.ContainsKey(id))
            {
                return Ok(fakeData.room1[id]);
            }
            else
            {
                return NotFound();
            }
        }

    

        //post new room
        [HttpPost]
        public ActionResult Post([FromBody]Room1 room1)
        {
            if (!this.ModelState.IsValid || room1 == null)
            {
                return BadRequest();
            }
            else
            {
                var maxExistingID = 0;
                if(fakeData.room1.Count > 0)
                {
                    maxExistingID = fakeData.room1.Keys.Max();
                }
                room1.Number = maxExistingID + 1;
                fakeData.room1.Add(room1.Number, room1);
                return Created($"api/room1/{room1.Number}", room1);
            }
        }

        //update room
        [HttpPut("{Number}")]
        public ActionResult Put(int Number, [FromBody]Room1 room1)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest();
            }else if (fakeData.room1.ContainsKey(Number))
            {
                fakeData.room1[Number] = room1;
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        //delete room
        [HttpDelete("{Number}")]
        public ActionResult Delete(int Number)
        {
            if (fakeData.room1.ContainsKey(Number))
            {
                fakeData.room1.Remove(Number);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
   
}