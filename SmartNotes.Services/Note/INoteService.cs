
namespace SmartNotes.Services.Note
{
    public interface INoteService
    {
        IEnumerable<Domain.Models.Note> GetAll();

        Domain.Models.Note GetById(int id);

        void Remove(int id);
    }
}