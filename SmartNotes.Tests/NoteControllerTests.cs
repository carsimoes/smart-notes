using SmartNotes.Api.Controllers;

namespace SmartNotes.Tests
{
    public class NoteControllerTests
    {
        //private readonly Mock<INoteRepository> _mockRepo;
        private readonly NoteController _controller;
        public NoteControllerTests()
        {
            //_mockRepo = new Mock<INoteRepository>();
            _controller = new NoteController();//_mockRepo.Object);
        }
    }
}
