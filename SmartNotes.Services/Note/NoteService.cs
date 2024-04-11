

namespace SmartNotes.Services.Note
{
    public class NoteService : INoteService
    {
        public NoteService()
        {
            
        }

        public IEnumerable<Domain.Models.Note> GetAll()
        {
            return new List<Domain.Models.Note>()
            {
                new Domain.Models.Note()
                {
                    Id = 1,
                    Content = "Content"
                }
            };
        }

        public Domain.Models.Note GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
