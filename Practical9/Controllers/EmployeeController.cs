using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical9.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public string ParameterData(string Value)
        {

            return $"Passed String is : {Value}";
        }
    }
}