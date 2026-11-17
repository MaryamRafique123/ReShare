namespace ReShare.Models
{
    public class Donation
    {
        public int Id { get; set; }

        public string Title { get; set; } = "";

        public string Category { get; set; } = "";

        public string Description { get; set; } = "";

        public string Condition { get; set; } = "";

        public string Location { get; set; } = "";
    }
}
