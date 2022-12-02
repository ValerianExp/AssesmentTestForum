using ForumApiCNet.Models;

using Microsoft.AspNetCore.Mvc;

namespace ForumApiCNet.Controllers;

[ApiController]
[Route("[controller]")]

public class ThreadController : ControllerBase

{
    private readonly ForumContext _DBcontext;

    public ThreadController(ForumContext context)
    {
        this._DBcontext = context;
    }

    [HttpGet("GetAllThread", Name = "GetAllThread")]
    public IActionResult Get()
    {
        return Ok(_DBcontext.TblThread);
    }

    [HttpGet("GetThreadById/{id}", Name = "GetThreadById")]
    public IActionResult Get(int id)
    {
        var thread = this._DBcontext.TblThread.FirstOrDefault(x => x.Id == id);
        return Ok(thread);
    }

    [HttpPost("AddThread", Name = "AddThread")]
    public IActionResult Post(TblThread thread)
    {
        this._DBcontext.TblThread.Add(thread);
        this._DBcontext.SaveChanges();
        return Ok(thread);
    }

    [HttpPut("UpdateThread/{id}", Name = "UpdateThread")]
    public IActionResult Put(int id, TblThread thread)
    {
        var threadToUpdate = this._DBcontext.TblThread.FirstOrDefault(x => x.Id == id);
        threadToUpdate.Title = thread.Title;
        this._DBcontext.SaveChanges();
        return Ok(threadToUpdate);
    }

    [HttpDelete("DeleteThread/{id}", Name = "DeleteThread")]
    public IActionResult Delete(int id)
    {
        var threadToDelete = this._DBcontext.TblThread.FirstOrDefault(x => x.Id == id);
        if (threadToDelete != null)
        {
            this._DBcontext.TblThread.Remove(threadToDelete);
            this._DBcontext.SaveChanges();
            return Ok();
        }
        return NotFound();
    }

}
