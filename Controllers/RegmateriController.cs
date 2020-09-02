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
    [RoutePrefix("api/Regmateri")]
    public class RegmateriController : ApiController
    {
        readonly ILogicRepo service;
        public RegmateriController(ILogicRepo _service)
        {
            this.service = _service;
        }

        public IHttpActionResult Getlist(string id, string start, string lenght, string search)
        {
            try
            {
                var data = service.LsRegisterMateri(id, start, lenght, search);
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
                var data = service.GetRegister(id);
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
                ret = service.DeleteRegisterMateri(id);
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
        public IHttpActionResult Putdata(RegisterMateri data)
        {
            bool ret = false;
            try
            {
                ret = service.ModifyRegisterMateri(data);
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
        public IHttpActionResult Postdata(RegisterMateri data)
        {
            bool ret = false;
            try
            {
                ret = service.ModifyRegisterMateri(data);
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
