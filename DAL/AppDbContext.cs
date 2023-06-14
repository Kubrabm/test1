using BackProject.DAL.Entities;
using BackProject.ViewComponenets;
using Microsoft.EntityFrameworkCore;

namespace BackProject.DAL
{
    public class AppDbContext : DbContext
    {
        internal readonly object Information;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Header> Headers { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<BestEducationTheme> BestEducations { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogDetail> BlogsDetails { get; set; }
        public DbSet<BuyNow> BuyNows { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Catigorie> Catigories { get; set; }
        public DbSet<CoursDetail> CoursDetails { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CoursInfo> CoursInfos { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Employe> Employes { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventDetail> EventsDetails { get; set; }
        public DbSet<Fakulty> Fakulties { get; set; }
        public DbSet<Hobbi> Hobbis { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<Information> Informations { get; set; }
        public DbSet<LatestPost> LatestPosts { get; set; }
        public DbSet<Letter> Letters { get; set; }
        public DbSet<Notice> Notices { get; set; }
        public DbSet<NoticeRigt> NoticeRigts { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Reply> Replys { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SosialMedia> SosialMedias { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherDetail> TeachersDetails { get; set; }
        public DbSet<UsefulLink> UsefulLinks { get; set; }

    }
}
