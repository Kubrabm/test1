
namespace BackProject.DAL.Entities
{
    public class Header
    {
        public int Id { get; set; }
        public string LogoUrl { get; set; }
        public ICollection<Home> Homes { get; set; }
        public ICollection<About> Abouts { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<EventDetail> Events { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<Blog> Blogs { get; set; }
        public ICollection<Contact> Contacts { get; set; }
        public ICollection<BuyNow> BuyNowS { get; set; }


    }
}
