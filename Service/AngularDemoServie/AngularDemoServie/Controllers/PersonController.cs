using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using AngularDemoServie.Models.ViewModels;
using Newtonsoft.Json;

namespace AngularDemoServie.Controllers
{
    public class PersonController : ApiController
    {
        public int PostPerson(Person person)
        {
            //do stuff here
            return 42;
        }
    }
}
