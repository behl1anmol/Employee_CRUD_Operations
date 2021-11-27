using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class EmployeeService : IEmployee
    {
        private Repository _repository = new Repository();
        public Repository repository { 
            get => _repository;
        }
       public bool AddData(employee emp)
        {
            return repository.AddEmployee(emp);
        }

        public bool DeleteData(int id)
        {
            return repository.DeleteEmployee(id);   
        }

        public IEnumerable<employee> FindAll()
        {
            return repository.GetAllEmployee();
        }

        public IEnumerable<employee> FindData(int id)
        {
            return repository.FindEmployee(id);
        }

        public bool UpdateData(int id, employee emp)
        {
            return repository.UpdateEmployee(id, emp);
        }
    }
}
