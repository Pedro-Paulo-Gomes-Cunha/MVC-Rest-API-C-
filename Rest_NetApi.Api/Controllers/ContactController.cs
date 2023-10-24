using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rest_NetApi.Api.Views;
using Rest_NetApi.Domain.Interface.IService;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Rest_NetApi.Api.Controllers
{
    
    [Route("/contact")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        IContactService _service;

        public ContactController(IContactService service)
        {
            _service = service;
        }

        [HttpGet()]
        public IActionResult GetAll()
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();
            var contacts = _service.FindAll().Select(ViewParser.Parse);
                return Ok(contacts);
            }catch(Exception e)
            {
                //add logs
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);

            }
            
        }

        [HttpPost()]
        public IActionResult Post(ContactView dado)
        {
            try
            {
                _service.Save(DtoParser.Parse(dado));

                return Ok(dado);
            }
            catch (Exception e)
            {
                //add logs
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);

            }

        }

        [HttpPut()]
        public IActionResult Put(ContactView dado)
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

