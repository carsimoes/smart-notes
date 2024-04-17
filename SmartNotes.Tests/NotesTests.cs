using SmartNotes.Api.Controllers;
using FakeItEasy;
using SmartNotes.Domain.NoteFeature.Models;
using SmartNotes.Domain.NoteFeature.Interfaces;

namespace SmartNotes.Tests
{
    public class NotesTests
    {
        private NoteController controller;
        //private Mock<INoteService> noteServiceMock;
        //private INoteService noteServiceMock;

        public void Setup()
        {
            //noteServiceMock = new Mock<INoteService>();
            //noteServiceMock = A.Fake<INoteService>();
            //controller = new NoteController(noteServiceMock.Object);
        }

        [Fact]
        public void Get_ReturnsOkResult()
        {
            //noteServiceMock.Setup(service => service.GetAll()).Returns(new List<Note>());

            //var result = controller.Get();

            //Assert.IsType<OkObjectResult>(result);
        }

        //[Fact]
        //public void Test_Addition()
        //{
        //    // Arrange
        //    A.CallTo(() => noteServiceMock.GetAll()).Returns(new List<Note>() { new Note() { Id = 1 } });

        //    // Act
        //    var result = noteServiceMock.GetAll();

        //    // Assert
        //    Assert.Equal(1, result.Count());
        //}
    }
}