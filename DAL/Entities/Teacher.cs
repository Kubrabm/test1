namespace BackProject.DAL.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string BgImgUrl { get; set; }
        public ICollection<TeacherDetail> teacherDetails { get; set; }
    }
}
