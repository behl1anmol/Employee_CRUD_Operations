using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IEmployee
    {
        Repository repository { get; }

        [OperationContract]
        bool AddData(employee emp);

        [OperationContract]
        bool UpdateData(int id, employee emp);

        [OperationContract]
        bool DeleteData(int id);

        [OperationContract]
        IEnumerable<employee> FindData(int id);

        [OperationContract]

        IEnumerable<employee> FindAll();


        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "EmployeeService.ContractType".
}
