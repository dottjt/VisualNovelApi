
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
    // [ValidateAntiForgeryToken] doesn't quite work, not sure why.
    public ActionResult CreateNovel(Novel novel)
    {
        _dbContext.Novels.Add(novel);
        _dbContext.SaveChanges();
        return Ok();
    }

    // [HttpPut("{id:int}")]
    // public IActionResult PutNovel(int id, Novel novel)
    // {
    //     dbContext.Novels.Update(novel);
    //     dbContext.SaveChanges();
    //     return Ok();
    // }

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
