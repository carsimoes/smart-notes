namespace SmartNotes.Domain.Models
{
    public class Note
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
