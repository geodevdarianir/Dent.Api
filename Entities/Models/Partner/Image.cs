namespace Entities.Models.Partner
{
    public class Image : IEntity
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FullName { get; set; }
        public string MimeType { get; set; }
        public string Location { get; set; }
        public User User { get; set; }
        public Work Work { get; set; }
    }
}
