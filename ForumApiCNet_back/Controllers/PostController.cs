using ForumApiCNet.Models;

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ForumApiCNet.Controllers;
[ApiController]
[Route("[controller]")]
public class PostController : ControllerBase
{

    private readonly ForumContext _DBcontext;

    private readonly string[] _forbiddenWords = {
        "fuck"
    };
    public PostController(ForumContext context)
    {
        this._DBcontext = context;
    }

    [HttpGet]
    public IEnumerable<TblPosts> Get()
    {
        return _DBcontext.TblPosts;
    }

    [HttpGet("/{threadId}/", Name = "GetPostsByThreadId")]
    public IEnumerable<TblPosts> GetPostsByThreadId(int threadId)
    {
        return _DBcontext.TblPosts.Where(x => x.Thread_Post_Id == threadId);
    }

    [HttpGet("{id}")]
    public TblPosts Get(int id)
    {
        return _DBcontext.TblPosts.Find(id);
    }

    [HttpPost]
    public void Post([FromBody] TblPosts post)
    {
        if (_forbiddenWords.Any(x => post.Content.Contains(x)))
        {
            // json custom error message
            var json = JsonConvert.SerializeObject(new { error = "Forbidden word" });
            Response.StatusCode = 400;
            Response.ContentType = "application/json";
            Response.WriteAsync(json);
        }
        _DBcontext.TblPosts.Add(post);
        _DBcontext.SaveChanges();
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] TblPosts post)
    {
        _DBcontext.TblPosts.Update(post);
        _DBcontext.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        _DBcontext.TblPosts.Remove(_DBcontext.TblPosts.Find(id));
        _DBcontext.SaveChanges();
    }

}