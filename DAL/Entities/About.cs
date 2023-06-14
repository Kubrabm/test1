using NuGet.DependencyResolver;

namespace BackProject.DAL.Entities
{
    public class About
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string BgImgUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<Employe> Employes { get; set; }
        public ICollection<Notice> Notices { get; set; }


    }
}
