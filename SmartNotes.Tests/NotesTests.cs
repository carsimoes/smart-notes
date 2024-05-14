using AutoMapper;
using Moq;
using NSubstitute;
using SmartNotes.Api.Controllers;
using SmartNotes.Domain.NoteFeature.Entities;
using SmartNotes.Domain.NoteFeature.Interfaces;

namespace SmartNotes.Tests
{
    public class NotesTests
    {
        //Mock implementation
        public Mock<INoteService> noteServiceMock = new Mock<INoteService>();
        public Mock<IMapper> mapperMock = new Mock<IMapper>();

        //Nsubstitute
        private readonly INoteService _noteService;

        public NotesTests()
        {
            _noteService = Substitute.For<INoteService>();
        }


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

        [Fact]
        public void GivenInputIsCorrect_WhenNoteIsInvoked_ThenTrueIsReturned()
        {
            var result = _noteService.GetAll().Returns(new List<Note>() { new Note() { Id = 1 } });

            Assert.NotNull(result);
        }
    }
}
