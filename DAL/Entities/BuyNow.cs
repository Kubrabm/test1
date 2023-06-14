namespace BackProject.DAL.Entities
{
    public class BuyNow
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ImageUrl { get; set; }
        public int? ParentCategoryId { get; set; }
        public string Bacground { get; set; }
        public int OptionValue { get; set; }
        public BuyNow ParentCategory { get; set; }
        public bool IsMain { get; set; }
    }
}
