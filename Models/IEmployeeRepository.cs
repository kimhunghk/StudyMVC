﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyWebAppMVC.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);
        IEnumerable<Employee> GetAllEmployee();
        Employee Update(Employee employeeChanges);
        Employee Add(Employee employee);
        Employee Delete(int id);
    }
}
