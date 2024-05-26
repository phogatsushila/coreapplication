using coreapplication.Model.Domain;

namespace coreapplication.Model.DTO
{
    public class AddWalkDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Lengthinkm { get; set; }
        public string? walkimageurl { get; set; }
        public Guid DifficultyId { get; set; }
        public Guid RegionId { get; set; }
        public Dificulity Dificulity { get; set; }
        public Region Region { get; set; }

    }
}
