namespace BackProject.DAL.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string BgImgUrl { get; set; }
        public ICollection<BlogDetail> BlogDetails { get; set; }
    }

}
