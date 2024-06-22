
using Microsoft.AspNetCore.Mvc;
using VisualNovelApi.Context;
using VisualNovelApi.Model;

namespace VisualNovelApi.Controllers;

[ApiController]
[Route("api/novels")]
public class NovelController : ControllerBase
{
    private readonly NovelDbContext _dbContext;

    public NovelController(NovelDbContext dbContext)
    {
        this._dbContext = dbContext;
    }

    [HttpGet("")]
    public ActionResult<IEnumerable<Novel>> GetNovels()
    {
        // Console.WriteLine(_dbContext);
        // var novels = _dbContext.Novels.ToList();
        return Ok();
    }

    // [HttpGet("{id:int}")]
    // public ActionResult<Novel> GetNovelById(int id)
    // {
    //     var novel = dbContext.Novels.Where(x => x.Id.Equals(id)).FirstOrDefault();

    //     if (novel != null) {
    //         return Ok(novel);
    //     }
    //     return NoContent();
    // }

    // [HttpPost("")]
    // public ActionResult<Novel?> CreateNovel(Novel novel)
    // {
    //     Console.WriteLine(novel);
    //     dbContext.Novels.Add(novel);
    //     dbContext.SaveChanges();
    //     return Ok();
    // }

    // [HttpPut("{id:int}")]
    // public IActionResult PutNovel(int id, Novel novel)
    // {
    //     dbContext.Novels.Update(novel);
    //     dbContext.SaveChanges();
    //     return Ok();
    // }

    // [HttpDelete("{id:int}")]
    // public ActionResult<Novel> DeleteNovelById(int id)
    // {
    //     var novel = dbContext.Novels.Where(a => a.Id.Equals(id)).FirstOrDefault();
    //     if (novel != null) {
    //         dbContext.Novels.Remove(novel);
    //         dbContext.SaveChanges();
    //         return Ok();
    //     }
    //     return NotFound();
    // }
}
