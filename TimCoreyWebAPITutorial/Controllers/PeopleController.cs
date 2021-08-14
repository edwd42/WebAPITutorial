using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TimCoreyWebAPITutorial.Models;

namespace TimCoreyWebAPITutorial.Controllers
{
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName = "Ed", LastName = "Me", Id = 1 });
            people.Add(new Person { FirstName = "Bilbo", LastName = "Baggins", Id = 2 });
            people.Add(new Person { FirstName = "Frodo", LastName = "Baggins", Id = 3 });
        }

        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/People
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
