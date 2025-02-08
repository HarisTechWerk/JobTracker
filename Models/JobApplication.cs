namespace JobTracker.Models
{
    public class JobApplication
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public string Status { get; set; }
        public DateTime AppliedDate { get; set; }
    }
}
