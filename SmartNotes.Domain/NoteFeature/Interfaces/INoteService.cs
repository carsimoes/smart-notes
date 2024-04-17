namespace SmartNotes.Domain.NoteFeature.Interfaces
{
    public interface INoteService
    {
        IEnumerable<Domain.NoteFeature.Models.Note> GetAll();

        Domain.NoteFeature.Models.Note GetById(int id);

        void Remove(int id);
    }
}