using SmartNotes.Domain;

namespace SmartNotes.Data
{
    public class NoteRepository
    {
        private List<Note> Notes = new List<Note>();

        public IEnumerable<Note> GetAll
        {
            get { return Notes; }
        }
        public void Create(Note note)
        {
            Notes.Add(note);
        }
    }
}
