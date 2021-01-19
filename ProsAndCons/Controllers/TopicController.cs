using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProsAndCons.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProsAndCons.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TopicController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IEnumerable<Topic> Index()
        {
            var result = new[] {
                new Topic(1, "First to try", (new List<Argument>() {new Argument(1, "Pkus", true, 1)}))
            };
            return result;
        }
    }
}
