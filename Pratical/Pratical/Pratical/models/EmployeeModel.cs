﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pratical.models
{
    class Employee
    {
        public List<EmployeeModel> employee_list { get; set; }
    }
    class EmployeeModel
    {
        public string name { get; set; }
        public string role { get; set; }
        public int birthyear { get; set; }
    }
}
