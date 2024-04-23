namespace SmartNotes.Domain.NoteFeature.Entities
{
    public class Note
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Tags { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
