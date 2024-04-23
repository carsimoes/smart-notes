using AutoMapper;
using SmartNotes.Domain.NoteFeature.Interfaces;
using SmartNotes.Domain.NoteFeature.Entities;

namespace SmartNotes.Services.Note
{
    public class NoteService : INoteService
    {
        private readonly IMapper _mapper;

        public NoteService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public void Add(Domain.NoteFeature.Entities.Note note)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.NoteFeature.Entities.Note> GetAll()
        {
            return new List<Domain.NoteFeature.Entities.Note>()
            {
                new Domain.NoteFeature.Entities.Note()
                {
                    Id = 1,
                    Content = "Content"
                }
            };
        }

        public Domain.NoteFeature.Entities.Note GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
