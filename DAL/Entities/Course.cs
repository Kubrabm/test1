namespace BackProject.DAL.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string BgImgUrl { get; set; }
        public ICollection<CoursDetail> CoursDetails { get; set; }
    }
}
