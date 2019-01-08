using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using RoboclubWebsite.Models;
using Microsoft.AspNetCore.MVC;

namespace RoboclubWebsite.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ProjectContext _Context;
        // GET: Project
        public ActionResult Index()
        {
            return View();
        }

        [Route("[controller]")]
        [ApiController]
        public ProjectController(ProjectContext projectContext)
        {
            _Context = projectContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Project>>> GetProjects()
        {

        }
    }
}