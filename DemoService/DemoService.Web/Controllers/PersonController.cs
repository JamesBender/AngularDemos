using System.Web.Http;
using DemoService.Web.Models.ViewModels;

namespace DemoService.Web.Controllers
{
    public class PersonController : ApiController
    {
        public int PostPerson(Person person)
        {
            return 42;
        }
    }
}
