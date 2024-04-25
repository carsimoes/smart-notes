using Microsoft.Extensions.DependencyInjection;
using SmartNotes.Application.Services.Note;
using SmartNotes.Domain.NoteFeature.Interfaces;

namespace SmartNotes.Common.DependencyInjection
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddCustomDIs(this IServiceCollection services)
        {
            services.AddScoped<INoteService, NoteService>();

            return services;
        }
    }
}
