//using Collectionrepeat.Models;
//using Collectionrepeat.Services;
//using Collectionrepeat.Services.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Collectionrepeat.Controller
//{
//    internal class EmployeeController
//    {
//        private readonly IEmployeeService _employeeService;
//        public EmployeeController()
//        {
//            _employeeService = new EmployeeService();
//        }

//        public void GetAll()
//        {
//            var employees = _employeeService.GetAll();

//            foreach (var employee in employees)
//            {
//                string result = $"{employee.Id}  -  {employee.FullName}  -  {employee.Age}  -  {employee.Salary}";
//                Console.WriteLine(result);
//            }
//        }

//        public void FilterByPrice()
//        {
//            decimal first = 2400;
//            decimal secont = 4000;


//            List<Employee> employees = _employeeService.GetAll();
//            var filteredEmployees = _employeeService.FilterBySalary(first, secont, employees);

//            foreach (var item in filteredEmployees)
//            {
//                string result = $"{item.Id}  -  {item.FullName}  -  {item.Age}  -  {item.Salary}";
               
//                Console.WriteLine(result);
//            }
//        }
//    }
//}
