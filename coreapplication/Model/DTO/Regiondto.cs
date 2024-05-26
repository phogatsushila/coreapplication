namespace coreapplication.Model.DTO
{
    public class Regiondto
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string? Regionimageurl { get; set; }
        public Regiondto Region { get; set; }
        public difficultydto Difficulty { get; set; }
    }
}
