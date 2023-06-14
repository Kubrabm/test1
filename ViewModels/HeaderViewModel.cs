using BackProject.DAL.Entities;

namespace BackProject.ViewModels
{
    public class HeaderViewModel
    {
        public List<Header> Headers { get; set; }
        public List<Home> Homes { get; set; }
        public List<About> Abouts { get; set; }
        public List<Course> Courses { get; set; }
        public List<Event> Events { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Contact> Contacts { get; set; }
        public List<BuyNow> BuyNows { get; set; }
    }
}
