using Moq;
using SmartNotes.Api.Controllers;
using SmartNotes.Domain.NoteFeature.Interfaces;

namespace SmartNotes.Tests
{
    public class NotesTests
    {

        public Mock<INoteService> noteServiceMock = new Mock<INoteService>();

        [Fact]
        public async void GetAllNotesTest()
        {
            noteServiceMock.Setup(x => x.GetAll()).Returns(
                    new List<Domain.NoteFeature.Models.Note>()
                    {
                            new Domain.NoteFeature.Models.Note()
                            {
                                Id = 1,
                                Content = "Content"
                            }
                    }
              );

            NoteController controller = new NoteController(noteServiceMock.Object);

            var result = controller.Get();

            Assert.NotNull(result);
        }
    }
}
