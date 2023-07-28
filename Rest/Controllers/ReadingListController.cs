using Microsoft.AspNetCore.Mvc;
using Rest.Models;
using Rest.Services;

namespace Rest.Controllers;

public class ReadingListController : ControllerBase
{
    private readonly ReadingListService _readingListService;

    [HttpPost]
    public IActionResult AddNovelToList(ReadingList list, LightNovel novel)
    {
        try
        {
            var addNovelResult = _readingListService.AddNovelToList(list, novel);
            return Ok(addNovelResult);
        }
        catch (Exception e)
        {
            return BadRequest(e.InnerException?.Message);
        }
    }

    [HttpGet]
    public IActionResult GetAllReadingLists()
    {
        try
        {
            var allReadingLists = _readingListService.GetAllReadingLists();
            return Ok(allReadingLists);
        }
        catch (Exception e)
        {
            return BadRequest(e.InnerException?.Message);
        }
    }

    [HttpGet]
    public IActionResult GetReadingListById(int id)
    {
        try
        {
            var readingList = _readingListService.GetReadingListById(id);
            return Ok(readingList);
        }
        catch (Exception e)
        {
            return BadRequest(e.InnerException?.Message);
        }
    }

    [HttpPost]
    public IActionResult GetReadingListByUser(User user)
    {
        try
        {
            var readingLists = _readingListService.GetReadingListsByUser(user);
            return Ok(readingLists);
        }
        catch (Exception e)
        {
            return BadRequest(e.InnerException?.Message);
        }
    }

    [HttpPut]
    public IActionResult UpdateReadingList(int id, ReadingList readingListData)
    {
        try
        {
            var readingList = _readingListService.UpdateReadingList(id, readingListData);
            return Ok(readingList);
        }
        catch (Exception e)
        {
            return BadRequest(e.InnerException?.Message);
        }
    }

    [HttpPost]
    public IActionResult AddReadingList(ReadingList readingListData)
    {
        try
        {
            var readingList = _readingListService.AddReadingList(readingListData);
            return Ok(readingList);
        }
        catch (Exception e)
        {
            return BadRequest(e.InnerException?.Message);
        }
    }

    [HttpDelete]
    public IActionResult GetReadingListByUser(int id)
    {
        try
        {
            var deleteSuccess = _readingListService.DeleteReadingList(id);
            return Ok(deleteSuccess);
        }
        catch (Exception e)
        {
            return BadRequest(e.InnerException?.Message);
        }
    }
}