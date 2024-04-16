using SmartNotes.Api.Controllers;
using SmartNotes.Services.Note;
using Moq;
using NUnit.Framework;

namespace SmartNotes.Tests
{
    public class NotesTests
    {
        private NoteController controller;
        private Mock<INoteService> noteServiceMock;

        [SetUp]
        public void Setup()
        {
            noteServiceMock = new Mock<INoteService>();
            controller = new NoteController(noteServiceMock.Object);
        }

        [Fact]
        public void Test1()
        {
            //noteServiceMock.Setup(p => p.GetAll(It.IsAny<double>(), cardMock.Object)).Returns(true);

            Xunit.Assert.Equal(5, 1);
        }
    }
}