using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Net.Http.Headers;
using System.Text;
using Webapi1.Models;

namespace Webapi1.Controllers
{
    public class EmployeesController : ApiController
    {
        
         Employee[] employees = new Employee[]{
          new Employee { ID = 1, Name = "Mark", JoiningDate =
             DateTime.Parse(DateTime.Today.ToString()), Age = 30,blood_group="A+" },
          new Employee { ID = 2, Name = "Allan", JoiningDate =
             DateTime.Parse(DateTime.Today.ToString()), Age = 35,blood_group="b+" },
          new Employee { ID = 3, Name = "Johny", JoiningDate =
             DateTime.Parse(DateTime.Today.ToString()), Age = 21,blood_group="ab+" }
          
       };
        [Route("api/GetAllEmployees")]
         public IEnumerable<Employee> GetAllEmployees()
         {
             return employees;
         }
       
        public IHttpActionResult GetEmployee(int id)
         {
             var employee = employees.FirstOrDefault((p) => p.ID == id);
             if (employee == null)
             {
                 return NotFound();
             }
             return Ok(employee);
         }

        public HttpResponseMessage Get()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "value");
            response.Content = new StringContent("hello", Encoding.Unicode);
            response.Headers.CacheControl = new CacheControlHeaderValue()
            {
                MaxAge = TimeSpan.FromMinutes(20)
            };
            return response;
        }
    }
}