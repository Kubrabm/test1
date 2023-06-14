namespace BackProject.DAL.Entities
{
    public class LatestPost
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public ICollection<Blog> Blogs { get; set; }

    }
}
