namespace JobData.Models
{
    public class Job
    {
        public int Id { get; set; }
        public int Effort { get; set; }
        public Project Project { get; set; }
        public int ProjectId { get; set; }
        public List<JobEmployee> JobEmployees { get; set; } = new List<JobEmployee>();
    }
}
