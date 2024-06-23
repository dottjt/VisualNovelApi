
using Microsoft.AspNetCore.Mvc;
using VisualNovelApi.Context;
using VisualNovelApi.Model;

namespace VisualNovelApi.Controllers;

[ApiController]
[Route("api/novels")]
[Produces("application/json")]
public class NovelController : ControllerBase
{

    // Read through model binding to better understand how information is passed between controllers
    // https://learn.microsoft.com/en-us/aspnet/core/mvc/models/model-binding?view=aspnetcore-8.0

    private readonly NovelDbContext _dbContext;

    public NovelController(NovelDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Novel>> GetNovels()
    {
        using (var context = new NovelDbContext()) {
            var novels = _dbContext.Novels.ToList();
            return Ok(novels);
        }
    }

    [HttpGet("{id}")]
    public ActionResult<Novel> GetNovelById(string id)
    {
        Console.WriteLine("here" + id);
        var novel = _dbContext.Novels.Where(x => x.Id.Equals(Guid.Parse(id))).SingleOrDefault();

        if (novel != null) {
            return Ok(novel);
        }
        return NoContent();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult CreateNovel(Novel novel)
    {
        _dbContext.Novels.Add(novel);
        _dbContext.SaveChanges();
        return Ok();
    }

    [HttpPut]
    public IActionResult PutNovel(Novel novel)
    {
        _dbContext.Novels.Update(novel);
        _dbContext.SaveChanges();
        return Ok();
    }

    [HttpDelete("{id}")]
    public ActionResult<Novel> DeleteNovelById(string id)
    {
        var novel = _dbContext.Novels.Where(a => a.Id.Equals(Guid.Parse(id))).FirstOrDefault();
        if (novel != null) {
            _dbContext.Novels.Remove(novel);
            _dbContext.SaveChanges();
            return Ok();
        }
        return NotFound();
    }
}
