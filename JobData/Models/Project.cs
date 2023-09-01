namespace JobData.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Job> Jobs { get; set; } = new List<Job>(); 
    }
}
