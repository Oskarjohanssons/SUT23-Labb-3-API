using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SUT23_Labb_3___API.Models;
using SUT23_Labb_3___API.Services;

namespace SUT23_Labb_3___API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IPerson _application;
        public PersonController(IPerson application)
        {
            _application = application;
        }

        [HttpGet]
        public async Task<ActionResult<Person>> GetAllPerson()
        {
            try
            {
                return Ok(await _application.GetAll());
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to retrive data from Database...");
            }
        }

        [HttpGet("GetPersonInterest/{id:int}")]
        public async Task<ActionResult<Person>> GetIntrestPersonID(int id)
        {
            try
            {
                var result = await _application.GetInterests(id);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to retrive data from Database...");
            }
        }


        [HttpGet("GetPersonLinks/{Id:int}")]
        public async Task<ActionResult<Person>> GetLinkID(int Id)
        {
            try
            {
                var result = await _application.GetLinks(Id);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to retrive data from Database...");
            }
        }

        [HttpPost("AddInterest")]
        public async Task<IActionResult> AddInterestToPerson(int personID, int interest)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                await _application.AddInterest(personID, interest);
                return Ok();

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to post data to Database...");
            }
        }

        [HttpPost("AddLink")]
        public async Task<IActionResult> AddLinkToPerson(int personID, int interestID, string url)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                await _application.AddLink(personID, interestID, url);
                return Ok();
            }
            catch
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to post data to Database...");
            }
        }
    }
}
