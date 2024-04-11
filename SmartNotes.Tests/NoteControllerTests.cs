using Microsoft.AspNetCore.Mvc;
using Moq;
using SmartNotes.Api.Controllers;
using SmartNotes.Data.Repository;
using SmartNotes.Domain.Models;
using SmartNotes.Services.Note;
using Xunit;

namespace SmartNotes.Tests
{
    public class NoteControllerTests
    {
        private readonly INoteService noteService;
        private readonly NoteController controller;

        public NoteControllerTests()
        {
            noteService = new NoteService();
            controller = new NoteController(noteService);
        }

        [Fact]
        public void Index_ActionExecutes_ReturnNotes()
        {
            var result = controller.Get();
            Assert.IsType<OkObjectResult>(result as OkObjectResult);
        }
    }
}




