using JobData.Models;

namespace JobData.Data
{
    public static class DbSeed
    {

        public static void Seed(AppDbContext ctx) 
        {
            ctx.JobEmployees.RemoveRange(ctx.JobEmployees);
            ctx.Jobs.RemoveRange(ctx.Jobs);
            ctx.Projects.RemoveRange(ctx.Projects);
            ctx.Employees.RemoveRange(ctx.Employees);

            var employees = new List<Employee>()
            {
                new Employee() 
                {
                    Name = "Luca",
                    Surname = "Verdi"
                },
                new Employee()
                {
                    Name = "Mario",
                    Surname = "Rossi"
                },
                new Employee()
                {
                    Name = "Luigi",
                    Surname = "Calogero"
                },
                new Employee()
                {
                    Name = "Gianni",
                    Surname = "Verdi"
                },
            };
            ctx.Employees.AddRange(employees);


            var projects = new List<Project>()
            {
                new Project()
                {
                    Name = "project 1",
                },
                new Project()
                {
                    Name = "project 2",
                },
                new Project()
                {
                    Name = "project 3",
                },
                new Project()
                {
                    Name = "project 4",
                },
            };
            ctx.Projects.AddRange(projects);


            var jobs = new List<Job>()
            {
                new Job()
                {
                    Effort = 20,
                    Project = projects.ElementAt(0)
                },
                new Job()
                {
                    Effort = 1000,
                    Project = projects.ElementAt(0)
                },
                new Job()
                {
                    Effort = 300,
                    Project = projects.ElementAt(0)
                },
                new Job()
                {
                    Effort = 100,
                    Project = projects.ElementAt(1)
                },
            };
            ctx.Jobs.AddRange(jobs);



            var jobemployees = new List<JobEmployee>()
            {
                new JobEmployee()
                {
                    Job = jobs.ElementAt(3),
                    Employee= employees.ElementAt(2),

                },
                new JobEmployee()
                {
                    Job = jobs.ElementAt(3),
                    Employee= employees.ElementAt(1),
                },
                new JobEmployee()
                {
                    Job = jobs.ElementAt(0),
                    Employee= employees.ElementAt(2),
                },
                new JobEmployee()
                {
                    Job = jobs.ElementAt(2),
                    Employee= employees.ElementAt(1),
                },
                new JobEmployee()
                {
                    Job = jobs.ElementAt(1),
                    Employee= employees.ElementAt(0),
                },
            };
            ctx.JobEmployees.AddRange(jobemployees);
            ctx.SaveChanges();
        }
    }
}
