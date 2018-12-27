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
    public class GoalController : ControllerBase
    {
        // GET: api/Goal
        [HttpGet]
        public IEnumerable<GoalModel> Get()
        {
            return GoalRepository.GetGoals();
        }

        // GET: api/Goal/5
        [HttpGet("{id}", Name = "Get")]
        public GoalModel Get(int id)
        {
            return GoalRepository.GetGoal(id);
        }

        // POST: api/Goal
        [HttpPost]
        public bool Post([FromBody] GoalModel goal)
        {
            return GoalRepository.CreateNewGoal(goal);
        }

        // PUT: api/Goal/5
        [HttpPut("{id}")]
        public bool Put(int id)
        {
            return GoalRepository.UpdateGoal(id);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return GoalRepository.DeleteGoal(id);
        }
    }
}
