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
    [RoutePrefix("api/Mahasiswa")]
    public class MahasiswaController : ApiController
    {
        readonly ILogicRepo service;
        public MahasiswaController(ILogicRepo _service)
        {
            this.service = _service;
        }

        public IHttpActionResult Getlist()
        {
            try
            {
                var data = service.LsMahasiswa();
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
                var data = service.GetMahasiswa(id);
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
                ret = service.DeleteMahasiswa(id);
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
        public IHttpActionResult Putdata(Mahasiswa data)
        {
            bool ret = false;
            try
            {
                ret = service.ModifyMahasiswa(data);
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
        public IHttpActionResult Postdata(Mahasiswa data)
        {
            bool ret = false;
            try
            {
                ret = service.ModifyMahasiswa(data);
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
