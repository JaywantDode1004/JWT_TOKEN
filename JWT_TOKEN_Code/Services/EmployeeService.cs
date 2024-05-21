using JWT_Role_Based_Authentication.Context;
using JWT_Role_Based_Authentication.Interfaces;
using JWT_Role_Based_Authentication.Models;

namespace JWT_Role_Based_Authentication.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly JWTContext _context;
        public EmployeeService(JWTContext context)
        {
            _context = context;
        }
        public Employee AddEmployee(Employee employee)
        {
            var emp = _context.Employees.Add(employee);
            _context.SaveChanges();
            return emp.Entity;
        }

        public List<Employee> GetEmployeeDetails()
        {
            var employees = _context.Employees.ToList();
            return employees;
        }
    }
}
