using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using S02.Models;

namespace S02.Controllers
{/*
   [Route("api/[controller]")]
   public class DemoController : Controller
   {
      // GET api/demo
      [HttpGet]
      public IEnumerable<DataRecord> Get()
      {
         List<DataRecord> dbList = DBUtl.GetList<DataRecord>("SELECT * FROM DataRecord");
         return dbList;
      }

      // GET api/demo/batman
      [HttpGet("{id}")]
      public IActionResult Get(string id)
      {

         List<DataRecord> dbList = DBUtl.GetList<DataRecord>($"SELECT * FROM DataRecord WHERE Field1='{id}'");
         if (dbList.Count >0)
            return Ok(dbList[0]);
         else
            return NotFound();
      }

      // POST api/demo
      [HttpPost]
      public IActionResult Post([FromBody]DataRecord rec)
      {
         if (rec == null)
         {
            return BadRequest();
         }

         string sqlInsert = @"INSERT INTO DataRecord(Field1,Field2,Field3,Field4,Field5,Field6) VALUES
                        ('{0}','{1}',{2},{3},'{4}','{5}');";
         if (DBUtl.ExecSQL(sqlInsert, rec.Field1, rec.Field2, rec.Field3,
                                       rec.Field4, rec.Field5, 
                                       rec.Field6.ToUniversalTime().ToString("s")) == 1)
            return Ok();
         else
            return BadRequest(new { Message = DBUtl.DB_Message });
      }

      // PUT api/demo/superman
      [HttpPut("{id}")]x
      public IActionResult Put(string id, [FromBody]DataRecord rec)
      {
         if (rec == null || id == null)
         {
            return BadRequest();
         }

         string sql = @"UPDATE DataRecord 
                           SET Field2 = '{1}',
                               Field3 = {2},
                               Field4 = {3},
                               Field5 = '{4}',
                               Field6 = '{5}'
                         WHERE Field1='{0}'";
         string update = String.Format(sql, rec.Field1, rec.Field2, rec.Field3,
                                       rec.Field4, rec.Field5, rec.Field6.ToUniversalTime().ToString("s"));
         if (DBUtl.ExecSQL(update) == 1)
            return Ok();
         else
            return BadRequest(new { Message = DBUtl.DB_Message });
      }

      // DELETE api/demo/wonderwoman
      [HttpDelete("{id}")]
      public IActionResult Delete(string id)
      {
         if (id == null)
         {
            return BadRequest();
         }

         string sql = @"DELETE DataRecord 
                         WHERE Field1='{0}'";
         string delete = String.Format(sql, id);
         if (DBUtl.ExecSQL(delete) == 1)
            return Ok();
         else
            return BadRequest(new { Message = DBUtl.DB_Message });

      }
   }*/
}
