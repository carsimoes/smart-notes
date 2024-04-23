using SmartNotes.Domain.NoteFeature.Entities;

namespace SmartNotes.Data.Repository
{
    public class NoteRepository : INoteRepository
    {
        private List<Note> Notes = new List<Note>();

        public IEnumerable<Note> GetAll()
        {
            return Enumerable.Range(1, 5).Select(index => new Note
            {
                Id = 1,
                Content = "Test",
                Title = "Title"
            })
           .ToArray();
        }    

        public void Create(Note note)
        {
            Notes.Add(note);
        }
    }
}
