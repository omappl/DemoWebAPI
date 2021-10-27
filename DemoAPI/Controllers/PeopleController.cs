using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAPI.Controllers
{
    /// <summary>
    /// This is info about peoples
    /// </summary>
    public class PeopleController : ApiController
    {

        List<Person> people = new List<Person>();
        public PeopleController()
        {
            people.Add(new Person { FirstName = "Tm", LastName = "Cry" ,Id=1});
            people.Add(new Person { FirstName = "su", LastName = "strm", Id = 2 });
            people.Add(new Person { FirstName = "blo", LastName = "bagn", Id = 3 });
        }

        /// <summary>
        /// get list of all  users
        /// </summary>
        /// <param name="userId">the uniqie id</param>
        /// <param name="age" >age of person</param>
        /// <returns>a list of firstnames</returns>

        [Route("api/People/GetFirstNames")]
////        [Route("api/People/GetFirstNames/{userId:int}/{age:int}")]
        [HttpGet]
        public List<string> GetFirstNames(int userId, int age)
        {
            List<string> output = new List<string>();
            foreach (var p in people)
            {
                output.Add(p.FirstName);
            }
            return output;
        }



        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x =>x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person val)
        {
            people.Add(val);

        }



        // DELETE: api/People/5
        public void Delete(int id)
        {
            people.Remove(people.Find(x => x.Id == id));

        }
    }
}
