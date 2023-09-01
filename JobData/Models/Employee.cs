namespace JobData.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<JobEmployee> JobEmployees { get; set; } = new List<JobEmployee>();
    }
}
