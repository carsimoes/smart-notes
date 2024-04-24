using SmartNotes.Domain.NoteFeature.Entities;

namespace SmartNotes.Domain.NoteFeature.Interfaces
{
    public interface INoteService
    {
        IEnumerable<Note> GetAll();

        Note GetById(int id);

        void Remove(int id);

        Note Add(Note note);
    }
}