
using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations.Schema;

namespace DapperDemo.Models
{
    public class Employee
    {
        [Key]  
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Title { get; set; }
        public int CompanyId { get; set; }

        #nullable disable
        public virtual Company Company { get; set; }
    }
}
