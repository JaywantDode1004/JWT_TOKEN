﻿using JWT_Role_Based_Authentication.Interfaces;
using JWT_Role_Based_Authentication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT_Role_Based_Authentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _auth;
        public AuthController(IAuthService auth)
        {
            _auth = auth;
        }
        [HttpPost("login")]
        public string Login([FromBody] LoginRequest obj)
        {
            var token = _auth.Login(obj);
            return token;
        }

        [HttpPost("assignRole")]
        public bool AssignRoleToUser([FromBody] AddUserRole userRole)
        {
            var addedUserRole = _auth.AssignRoleToUser(userRole);
            return addedUserRole;
        }

        [HttpPost("addUser")]
        public User AddUser([FromBody] User user)
        {
            var addeduser = _auth.AddUser(user);
            return addeduser;
        }

        [HttpPost("addRole")]
        public Role AddRole([FromBody] Role role)
        {
            var addedRole = _auth.AddRole(role);
            return addedRole;
        }

    }
}
