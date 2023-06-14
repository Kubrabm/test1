using NuGet.DependencyResolver;

namespace BackProject.DAL.Entities
{
    public class ContactInfo
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Skype { get; set; }
        public string TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public ICollection<SosialMedia> sosialMedias { get; set; }
    }
}
