using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BackEnd.Logic;
using BackEnd.Models;

namespace BackEnd.Controllers
{
    [RoutePrefix("api/Materi")]
    public class MateriController : ApiController
    {
        readonly ILogicRepo service;
        public MateriController(ILogicRepo _service)
        {
            this.service = _service;
        }
        public IHttpActionResult Getlist()
        {
            try
            {
                var data = service.LsMateri();
                return Ok(data);
            }
            catch
            {
                return NotFound();
            }
        }

        public IHttpActionResult Get(int id)
        {
            try
            {
                var data = service.GetMateri(id);
                return Ok(data);
            }
            catch
            {
                return NotFound();
            }
        }

        public IHttpActionResult Delete(int id)
        {
            bool ret = false;
            try
            {
                ret = service.DeleteMateri(id);
                if (ret)
                    return Ok();
                else
                    return BadRequest();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut, Route("Modify")]
        public IHttpActionResult Putdata(Materi data)
        {
            bool ret = false;
            try
            {
                ret = service.ModifyMateri(data);
                if (ret)
                    return Ok();
                else
                    return BadRequest();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost, Route("Postdata")]
        public IHttpActionResult Postdata(Materi data)
        {
            bool ret = false;
            try
            {
                ret = service.ModifyMateri(data);
                if (ret)
                    return Ok();
                else
                    return BadRequest();
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}
