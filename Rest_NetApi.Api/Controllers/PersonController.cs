using Autofac.Core;
using Microsoft.AspNetCore.Mvc;
using Rest_NetApi.Api.Views;
using Rest_NetApi.Domain.DTOs;
using Rest_NetApi.Domain.Entities;
using Rest_NetApi.Domain.Interface.IService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Rest_NetApi.Api.Controllers
{
    [Route("/person")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _service;

        public PersonController(IPersonService userappService)
        {
            _service = userappService;
        }
       // GET: api/<PersonController>
        [HttpGet()]
        public IActionResult GetAll()
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();
                var people = _service.FindAll().Select(ViewParser.Parse);
                return Ok(people);
            }
            catch (Exception e)
            {
                //add logs
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);

            }

        }

        [HttpPost()]
        public Guid Add([FromBody] PersonView dado)
        {
           
           return _service.Save(DtoParser.Parse(dado));
          
        }
        [HttpPut()]
        public IActionResult Put(PersonView dado)
        {
            try
            {
                _service.Update(DtoParser.Parse(dado));

                return Ok(dado);
            }
            catch (Exception e)
            {
                //add logs
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);

            }

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _service.Remove(id);

                return Ok();
            }
            catch (Exception e)
            {
                //add logs
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);

            }

        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                var result = _service.FindById(id);

                if (result == null) return NotFound();

                return Ok(ViewParser.Parse(result));
            }
            catch (Exception e)
            {
                //add logs
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);

            }


        }
    }
}
