using System.Collections.Generic;

namespace WebFRameworkWithEntity
{
    public interface IDataBaseManager
    {
        List<Employee> GetAllEmployees();
    }
}