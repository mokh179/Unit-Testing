using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiUT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Users : ControllerBase
    {
        IOperations<user> _db;

        public Users(IOperations<user> db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult getAll()
        {

            if (_db.getAll() is null)
                return NotFound();
            return Ok(_db.getAll());

        }

        [HttpPost]
        public IActionResult add(user u)
        {
            if (u == null)
                return BadRequest();
            else
            {
                _db.Addnew(u);
                return Ok(u);
            }

        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, user u)
        {
            if (id == null)
                return BadRequest();
            else
            {
                //user us = _db.getByID(id);
                if (id !=u.ID)
                    return NotFound();
                else
                {
                    _db.Edit(u);
                    return Ok(_db.getAll());
                }
            }
        }
        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            if (id == null)
                return BadRequest();
            else
            {
                user us = _db.getByID(id);
                if (us == null)
                    return NotFound();
                else
                {
                    _db.del(id);
                    return Ok(_db.getAll());
                }
            }
        }
        [HttpGet("Details/{id}")]
        public IActionResult details(int id)
        {
            if (id == null)
                return BadRequest();

            else
            {
                user us = _db.getByID(id);
                if (us == null)
                    return NotFound();
                else
                {

                    return Ok(us);
                }
            }

        }
    }
}
