using Microsoft.AspNetCore.Mvc;
using SmartNotes.Domain.NoteFeature.Interfaces;

namespace SmartNotes.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NoteController : Controller
    {
        //private readonly INoteService noteService;

        //public NoteController(INoteService noteService)
        //{
        //    noteService = noteService;
        //}

        //[HttpGet]
        //public IActionResult Get()
        //{
        //    var items = noteService.GetAll();
        //    return Ok(items);
        //}

        //[HttpGet("{id}")]
        //public IActionResult Get(int id)
        //{
        //    var item = noteService.GetById(id);
        //    if (item == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(item);
        //}

        ////[HttpPost]
        ////public IActionResult Post([FromBody] ShoppingItem value)
        ////{
        ////    if (!ModelState.IsValid)
        ////    {
        ////        return BadRequest(ModelState);
        ////    }
        ////    var item = noteService.Add(value);
        ////    return CreatedAtAction("Get", new { id = item.Id }, item);
        ////}

        //[HttpDelete("{id}")]
        //public IActionResult Remove(int id)
        //{
        //    var existingItem = noteService.GetById(id);
        //    if (existingItem == null)
        //    {
        //        return NotFound();
        //    }
        //    noteService.Remove(id);
        //    return NoContent();
        //}
    }
}
