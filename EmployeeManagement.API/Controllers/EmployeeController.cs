using EmployeeManagement.DAL.Models.CommandModel;
using EmployeeManagement.DAL.Repository.Command;
using EmployeeManagement.DAL.Repository.Query;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(IEmployeeCommandRepository commandRepository, IEmployeeQueryRepository queryrepository) : ControllerBase
    {
        private readonly IEmployeeCommandRepository _commandRepository = commandRepository;
        private readonly IEmployeeQueryRepository _queryrepository = queryrepository;


        [HttpGet]
        public async Task<ActionResult> GetEmployees([FromQuery] int? id)
        {
            
            if (id.HasValue)
            {
                return Ok(await _queryrepository.GetById(id.Value));       
            }
            
            return Ok(await _queryrepository.GetAll());
        }


        [HttpPost]
        public async Task<ActionResult> CreateEmployee(EmployeeCommandModel entity)
        {
            await _commandRepository.Create(entity);
            return Ok(entity);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateEmployee(int id,EmployeeCommandModel entity)
        {
            await _commandRepository.Update(id,entity);
            return Ok(entity);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteResult(int id)
        {
            await _commandRepository.Delete(id);
            return Ok($"Employee with ID : {id} deleted Successfully");
        }

    }
}
