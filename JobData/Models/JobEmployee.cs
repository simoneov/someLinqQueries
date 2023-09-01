namespace JobData.Models
{
    public class JobEmployee
    {
        public Job Job { get; set; }
        public int JobId { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
    }
}