using System.Collections.Generic;

namespace EmployeeService
{
    public interface IRepository
    {
        employeeDBContext context { get;}

        bool AddEmployee(employee emp);
        bool UpdateEmployee(int id, employee emp);
        bool DeleteEmployee(int id);
        IEnumerable<employee> FindEmployee(int id);

        IEnumerable<employee> GetAllEmployee();

    }
}
