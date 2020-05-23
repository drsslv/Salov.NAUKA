using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salov.NAUKA
{
    class EmployeeContext:DbContext
    {
        public EmployeeContext() : base("Connection") { }

        public DbSet<Employee> Employees { get; set; }
    }
}
