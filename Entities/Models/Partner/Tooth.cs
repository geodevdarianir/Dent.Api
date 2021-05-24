namespace Entities.Models.Partner
{
    public class Tooth : IEntity
    {
        public int Id { get; set; }
        public string Nummer { get; set; }
        public string Value { get; set; }
        public bool SpecificArt { get; set; }
        public bool SpecificColor { get; set; }
        public Art Art { get; set; }
        public Color Color { get; set; }
        public Work Work { get; set; }
    }
}
