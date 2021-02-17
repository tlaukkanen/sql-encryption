using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SqlEncryption.Data;
using SqlEncryption.Model;

namespace SqlEncryption.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        public AppDbContext _context { get; set; }
        public PersonController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _context.Persons.ToList();
        }
    }
}
