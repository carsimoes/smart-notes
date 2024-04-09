using Microsoft.AspNetCore.Mvc;
using SmartNotes.Domain.Models;

namespace SmartNotes.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NoteController
    {
        [HttpGet(Name = "GetNotes")]
        public IEnumerable<Note> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Note
            {
                Id = 1,
                Content = "Test",
                Title = "Title"
            })
            .ToArray();
        }
    }
}
