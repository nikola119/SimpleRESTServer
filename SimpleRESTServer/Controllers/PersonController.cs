using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleRESTServer.Controllers
{
    [Route("api/[controller]")]
    public class PersonController
    {
        public PersonController()
        {

        }
        [HttpGet()]
        public Person GetPersonData()
        {
            Person john = new Person("John", "Doe");
            return john;
        }
    }
}
