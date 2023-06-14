namespace BackProject.DAL.Entities
{
    public class TeacherDetail
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string BgImgUrl { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string Experiens { get; set; }
        public string TeacherId { get; set; }
        public ICollection<Position> Positions { get; set; }
        public ICollection<Degree> Degree { get; set; }
        public ICollection<Fakulty> Fakulties { get; set; }
        public ICollection<Hobbi> hobbis { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public ICollection<ContactInfo> ContactInfo { get; set; }


    }
}
