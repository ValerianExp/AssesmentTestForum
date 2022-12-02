using Microsoft.AspNetCore.Mvc;
using ForumApiCNet.Models;
using Microsoft.EntityFrameworkCore;
using ForumApiCNet.Controllers;
using System.Collections.Generic;
using System.Linq;

namespace ForumApiCNet.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{

    private readonly ForumContext _DBcontext;

    public UserController(ForumContext context)
    {
        this._DBcontext = context;
    }

    [HttpGet("GetAllUsers", Name = "GetAllUsers")]
    public IActionResult Get()
    {
        var user = this._DBcontext.TblUsers.ToList();
        return Ok(user);
    }

    [HttpGet("GetUserById/{id}", Name = "GetUserById")]
    public IActionResult Get(int id)
    {
        var user = this._DBcontext.TblUsers.FirstOrDefault(x => x.Id == id);
        return Ok(user);
    }

    [HttpPost("AddUser", Name = "AddUser")]
    public IActionResult Post(TblUser user)
    {
        this._DBcontext.TblUsers.Add(user);
        this._DBcontext.SaveChanges();
        return Ok(user);
    }

    [HttpPut("UpdateUser/{id}", Name = "UpdateUser")]
    public IActionResult Put(int id, TblUser user)
    {
        var userToUpdate = this._DBcontext.TblUsers.FirstOrDefault(x => x.Id == id);
        userToUpdate.Username = user.Username;
        userToUpdate.Password = user.Password;
        userToUpdate.Email = user.Email;
        this._DBcontext.SaveChanges();
        return Ok(userToUpdate);
    }

    [HttpDelete("DeleteUser/{id}", Name = "DeleteUser")]
    public IActionResult Delete(int id)
    {
        var userToDelete = this._DBcontext.TblUsers.FirstOrDefault(x => x.Id == id);
        if (userToDelete != null)
        {
            this._DBcontext.TblUsers.Remove(userToDelete);
            this._DBcontext.SaveChanges();
            return Ok(userToDelete);
        }
        else
        {
            return NotFound();
        }
    }
}
