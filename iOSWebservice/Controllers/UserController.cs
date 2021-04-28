using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BAL.Service;
using DAL.Interface;
using DAL.Models;
using Newtonsoft.Json;


namespace iOSWebservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        private readonly IRepository<user> _User;

        public UserController(IRepository<user> user, UserService userService)
        {
            _userService = userService;
            _User = user;

        }

        //Add User  
        [HttpPost("AddUser")]
        public async Task<Object> AddUser([FromBody] user user)
        {
            try
            {
                await _userService.AddUser(user);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        //Delete Person  
        [HttpDelete("DeleteUser")]
        public bool DeletePerson(int UserId)
        {
            try
            {
                _userService.DeleteUser(UserId);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //Update user 
        [HttpPut("UpdatePerson")]
        public bool UpdatePerson(user Object)
        {
            try
            {
                _userService.UpdateUser(Object);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //GET All User by Username  
        [HttpGet("GetAllUserByName")]
        public Object GetAllPersonByName(string UserName)
        {
            var data = _userService.GetUserByUserName(UserName);
            var json = JsonConvert.SerializeObject(data, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );
            return json;
        }

        //GET All Person  
        [HttpGet("GetAllUsers")]
        public ActionResult GetAllUsers()
        {
            var data = _userService.GetAllUsers();

            return Ok(data);
        }
    }
    
}