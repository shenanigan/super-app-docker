using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : Controller
    {
        private MySQLDBContext _dbContext;  
  
        public JobController(MySQLDBContext context)  
        {  
            _dbContext = context;  
        }  
  
        [HttpGet]  
        public IList<Job> Get()  
        {  
            return (this._dbContext.Job.Include(x => x.User).ToList());  
        } 
    }
}