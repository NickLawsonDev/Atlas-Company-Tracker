using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtlasCompanyTracker.Database.Repositories;
using AtlasCompanyTracker.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtlasCompanyTracker.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        // GET: api/Resource
        [HttpGet]
        public IEnumerable<ResourceModel> Get()
        {
            return ResourceRepository.GetResources();
        }

        // GET: api/Resource/5
        [HttpGet("{id}", Name = "GetByID")]
        public ResourceModel Get(int id)
        {
            return ResourceRepository.GetResource(id);
        }

        // GET: api/Resource/5
        [HttpGet("{name}", Name = "GetByName")]
        public ResourceModel Get(string name)
        {
            return ResourceRepository.GetResource(name);
        }

        // POST: api/Resource
        [HttpPost]
        public bool Post([FromBody] ResourceModel resource)
        {
            return ResourceRepository.CreateNewResource(resource);
        }

        // PUT: api/Resource/5
        [HttpPut("{id}")]
        public bool Put(int id)
        {
            return ResourceRepository.UpdateResource(id);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return ResourceRepository.DeleteResource(id);
        }
    }
}
