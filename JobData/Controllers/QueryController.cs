using JobData.Data;
using JobData.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobData.Controllers
{
    [ApiController]

    public class QueryController : ControllerBase
    {


        private readonly AppDbContext _db;



        public QueryController(AppDbContext db)
        {
            _db = db;

        }




        [HttpGet("/Employees")]
        public List<Employee> Get()
        {
            var employee = _db.Employees.ToList();
            return employee;
        }


        [HttpGet("/EmployeesWithAJob")]
        public List<Employee> EmployeesWithAJob()
        {
            var employee = _db.Employees.Where(e => e.JobEmployees.Any()).ToList();
            return employee;
        }



        [HttpGet("/JobsPerProject")]
        public dynamic JobsPerProject()
        {
            var jobsperproject = _db.Projects.Select(e => 
            new
            { 
                Project = e.Name,
                JobNumber = e.Jobs.Count(),
            }).ToList();
            return jobsperproject;
        }


        [HttpGet("/EmployeesPerProject")]
        public dynamic EmployeesPerProject()
        {
            var employeesPerProject = _db.Projects.Select(e =>
            new
            {
                Project = e.Name,
                JobNumber = e.Jobs.SelectMany(a => a.JobEmployees).Select(d=>d.EmployeeId).Distinct().Count(),
            }).ToList();
            
            return employeesPerProject;
        }


        [HttpGet("/EmployeesNameWithTheirJobNumber")]
        public dynamic EmployeesNameWithTheirJobNumber()
        {
            var employeesNameWithTheirJobNumber = 
                _db.Employees.Select(i => 
                new 
                {
                    Name = i.Name,
                    JobNumber = i.JobEmployees.Count(),
                }).ToList();
            return employeesNameWithTheirJobNumber;
        }

    }
}
