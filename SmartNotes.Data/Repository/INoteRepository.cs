using SmartNotes.Domain.NoteFeature.Entities;

namespace SmartNotes.Data.Repository
{
    public interface INoteRepository
    {
        IEnumerable<Note> GetAll();

        void Create(Note note);
    }
}