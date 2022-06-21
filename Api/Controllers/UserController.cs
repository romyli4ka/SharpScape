﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharpScape.Api.Data;
using SharpScape.Api.Models;
using SharpScape.Shared.Dto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SharpScape.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
    private readonly AppDbContext _context;


        public UserController(AppDbContext context)
        {
            _context = context;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<ActionResult<List<UserInfoDto>>> Get()
        {
            var users = await _context.Users.Select(user=>new UserInfoDto()
            {
                Id = user.Id,
                Email = user.Email,
                Created = user.Created,
                Username = user.Username
            }).ToListAsync();

            return Ok(users);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserInfoDto>> Get(Guid id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user is null)
            {
                return NotFound();
            }
               var userinfo = new UserInfoDto()
            {
                Id = user.Id,
                Email = user.Email,
                Created = user.Created,
                Username = user.Username
            };

            return Ok(userinfo);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<IActionResult> UpdateUser(Guid id,[FromBody] UserRegisterDto value)
        {
            var user = await _context.Users.FindAsync(id);
            if (user is null)
            {
                return NotFound();
            }
            var newuser = new User(value.Username, value.Email, value.Password);
            user.Email = newuser.Email;
            user.Username = newuser.Username;
            user.PasswordHash = newuser.PasswordHash;
            user.PasswordSalt = newuser.PasswordSalt;
            _context.Entry(user).State=EntityState.Modified;
            try { await _context.SaveChangesAsync(); }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExist(id))
                {
                    return NotFound();
                }
                throw;
            }
            return NoContent();
        }
        private bool UserExist(Guid id)
        {
            return _context.Users.Any(user => user.Id == id);   
        }


        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var user = await _context.Users.FindAsync(id);
            if(user is null)
            {
                return NotFound();
            }
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
