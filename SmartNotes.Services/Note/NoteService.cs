using SmartNotes.Domain.NoteFeature.Interfaces;

namespace SmartNotes.Services.Note
{
    public class NoteService : INoteService
    {
        public NoteService()
        {
            
        }

        public IEnumerable<Domain.NoteFeature.Models.Note> GetAll()
        {
            return new List<Domain.NoteFeature.Models.Note>()
            {
                new SmartNotes.Domain.NoteFeature.Models.Note()
                {
                    Id = 1,
                    Content = "Content"
                }
            };
        }

        public Domain.NoteFeature.Models.Note GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
