using Microsoft.AspNetCore.Mvc;
using Rest.Models;
using Rest.Services;

namespace Rest.Controllers;

public class LightNovelController : ControllerBase
{
    private readonly LightNovelService _lightNovelService;

    [HttpPost]
    public IActionResult AddNovel(LightNovel novelData)
    {
        try
        {
            var createNovelResult = _lightNovelService.AddNovel(novelData);
            return Ok(createNovelResult);
        }
        catch (Exception e)
        {
            return BadRequest(e.InnerException?.Message);
        }
    }

    [HttpPut]
    public IActionResult UpdateNovel(int id, LightNovel novelData)
    {
        try
        {
            var updateNovelResult = _lightNovelService.UpdateNovel(id, novelData);
            return Ok(updateNovelResult);
        }
        catch (Exception e)
        {
            return BadRequest(e.InnerException?.Message);
        }
    }

    [HttpDelete]
    public IActionResult DeleteNovel(int id)
    {
        try
        {
            var deleteSuccess = _lightNovelService.DeleteNovel(id);
            return Ok(deleteSuccess);
        }
        catch (Exception e)
        {
            return BadRequest(e.InnerException?.Message);
        }
    }

    [HttpGet]
    public IActionResult GetAllNovels()
    {
        try
        {
            var novelResult = _lightNovelService.GetAllNovels();
            return Ok(novelResult);
        }
        catch (Exception e)
        {
            return BadRequest(e.InnerException?.Message);
        }
    }

    [HttpGet]
    public IActionResult GetNovelById(int id)
    {
        try
        {
            var novelResult = _lightNovelService.GetNovelById(id);
            return Ok(novelResult);
        }
        catch (Exception e)
        {
            return BadRequest(e.InnerException?.Message);
        }
    }

    [HttpGet]
    public IActionResult GetNovelsByGenre(string genre)
    {
        try
        {
            var novelResult = _lightNovelService.GetNovelsByGenre(genre);
            return Ok(novelResult);
        }
        catch (Exception e)
        {
            return BadRequest(e.InnerException?.Message);
        }
    }

    [HttpGet]
    public IActionResult GetNovelsByAuthor(string author)
    {
        try
        {
            var novelResult = _lightNovelService.GetNovelsByAuthor(author);
            return Ok(novelResult);
        }
        catch (Exception e)
        {
            return BadRequest(e.InnerException?.Message);
        }
    }

    [HttpGet]
    public IActionResult GetNovelsByYear(int year)
    {
        try
        {
            var novelResult = _lightNovelService.GetNovelsByYear(year);
            return Ok(novelResult);
        }
        catch (Exception e)
        {
            return BadRequest(e.InnerException?.Message);
        }
    }
}