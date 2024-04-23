using AutoMapper;
using SmartNotes.Application.Dto;
using SmartNotes.Domain.NoteFeature.Entities;

namespace SmartNotes.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Note, NoteDto>();
            CreateMap<NoteDto, Note>();
        }
    }
}
