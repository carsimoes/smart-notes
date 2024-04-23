using AutoMapper;
using Moq;
using SmartNotes.Api.Controllers;
using SmartNotes.Domain.NoteFeature.Entities;
using SmartNotes.Domain.NoteFeature.Interfaces;

namespace SmartNotes.Tests
{
    public class NotesTests
    {

        public Mock<INoteService> noteServiceMock = new Mock<INoteService>();
        public Mock<IMapper> mapperMock = new Mock<IMapper>();

        [Fact]
        public async void GetAllNotesTest()
        {
            noteServiceMock.Setup(x => x.GetAll()).Returns(
                    new List<Note>()
                    {
                            new()
                            {
                                Id = 1,
                                Content = "Content"
                            }
                    }
              );

            NoteController controller = new NoteController(noteServiceMock.Object, mapperMock.Object);

            var result = controller.Get();

            Assert.NotNull(result);
        }
    }
}
