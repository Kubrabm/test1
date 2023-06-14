namespace BackProject.DAL.Entities
{
    public class CoursDetail
    {
        public int Id { get; set; }
        public string ImgUrl { get; set; }
        public string Name { get; set; }
        public string Descroption { get; set; }
        public string About { get; set; }
        public string Apply { get; set; }
        public string Certification { get; set; }
        public ICollection<CoursInfo> CoursInfos { get; set; }
    }
}
