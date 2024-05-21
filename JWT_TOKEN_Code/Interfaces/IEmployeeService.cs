using JWT_Role_Based_Authentication.Models;

namespace JWT_Role_Based_Authentication.Interfaces
{
    public interface IEmployeeService
    {
        public List<Employee> GetEmployeeDetails();
        public Employee AddEmployee(Employee employee);
    }
}
