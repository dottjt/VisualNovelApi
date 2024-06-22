using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VisualNovelApi.Model;

namespace VisualNovelApi.Controllers
{
    [ApiController]
    [Route("api/novels")]
    public class NovelController : ControllerBase
    {
        // private readonly NovelContext _dbContext;

        // public NovelController(NovelContext dbContext)
        // {
        //     _dbContext = dbContext;
        // }

        // [HttpGet("")]
        // public ActionResult<IEnumerable<Novel>> GetNovels()
        // {
        //     // var novels = _dbContext.Novels.ToList();
        //     // return novels;
        //     return null;
        // }

        // [HttpGet("{id}")]
        // public ActionResult<Novel> GetNovelById(int id)
        // {
        //     // var novels = _dbContext.Novels.ToList();
        //     // return novels;
        //     return null;
        // }

        [HttpPost("")]
        public ActionResult<Novel> PostNovel(Novel model)
        {
            return null;
        }

        // [HttpPut("{id}")]
        // public IActionResult PutNovel(int id, Novel model)
        // {
        //     return NoContent();
        // }

        // [HttpDelete("{id}")]
        // public ActionResult<Novel> DeleteTModelById(int id)
        // {
        //     return null;
        // }
    }
}
