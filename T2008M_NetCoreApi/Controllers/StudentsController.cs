using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using T2008M_NetCoreApi.Models;
using T2008M_NetCoreApi.Repositories;

namespace T2008M_NetCoreApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]    
    public class StudentsController : ControllerBase
    {
        private IStudentsRepository repository;

        public StudentsController(IStudentsRepository repository)
        {
            this.repository = repository;
        }

        // GET: api/Categories
        [HttpGet]
        public async Task<IEnumerable<Student>> GetCategories()
        {
            return await repository.GetStudentsAsync();
        }

        
    }
}
