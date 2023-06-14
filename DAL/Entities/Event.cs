namespace BackProject.DAL.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string BgImgUrl { get; set; }
        public ICollection<EventDetail> EventDetails { get; set; }
    }

}
