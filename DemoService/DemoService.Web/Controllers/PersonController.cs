using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using DemoService.Web.Models.ViewModels;

namespace DemoService.Web.Controllers
{
    public class PersonController : ApiController
    {
        private IDictionary<int, Person> _personDictionary; 

        public PersonController()
        {
            _personDictionary = new Dictionary<int, Person>
            {
                {1, new Person {Id = 1, FirstName = "Fred", LastName = "Flinstone", UserName = "FFlinstone"}}
            };
        }

        public IEnumerable<Person> GetListOfPeople()
        {
            return _personDictionary.Values.ToList();
        }

        public Person GetPerson(int id)
        {
            if (!_personDictionary.ContainsKey(id))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                return _personDictionary[id];
            }
        }

        public int PostPerson(Person person)
        {
            var newId = _personDictionary.Count + 1;
            _personDictionary.Add(newId, person);
            return newId;
        }
    }
}
