using AutoMapper;
using SmartNotes.Application.Dto;
using SmartNotes.Domain.NoteFeature.Entities;

namespace SmartNotes.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Note, NoteDto>(); 
        }
    }
}
