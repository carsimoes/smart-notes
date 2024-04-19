namespace SmartNotes.Domain.NoteFeature.Interfaces
{
    public interface INoteService
    {
        IEnumerable<Models.Note> GetAll();

        Models.Note GetById(int id);

        void Remove(int id);
    }
}