using Data.Models;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DataApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<M, T> : Controller where M:Base where T : BaseRepository<M>
    {
        T repo = Activator.CreateInstance<T>();
        [HttpPost]
        public void Post([FromBody] M model)
        {
            
            repo.Create(model);

        }       
    }
}
