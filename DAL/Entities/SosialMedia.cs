namespace BackProject.DAL.Entities
{
    public class SosialMedia
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        public EventDetail BrandAndFeature { get; set; }
    }
}
