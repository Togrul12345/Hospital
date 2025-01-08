using Hospital.Bl.Dtos.PatientDtos;
using Hospital.Bl.Exceptions;
using Hospital.Bl.Services.Abstraction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatienceService _patienceService;

        public PatientController(IPatienceService patienceService)
        {
            _patienceService = patienceService;
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreatePatientDto createPatientDto)
        {
            if (!ModelState.IsValid)
            {
                throw new ModelStateException();
            }
            try
            {
                return StatusCode(StatusCodes.Status200OK, await _patienceService.CreateAsync(createPatientDto));

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
           

        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
           
            try
            {
                return StatusCode(StatusCodes.Status200OK, await _patienceService.GetAllAsync());

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }


        }
        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {

            try
            {
                return StatusCode(StatusCodes.Status200OK, await _patienceService.GetByIdAsync(id));

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }


        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {

            try
            {
                return StatusCode(StatusCodes.Status200OK, await _patienceService.HardDeleteAsync(id));

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }


        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update(int id,UpdatePatientDto updatePatientDto)
        {

            try
            {
                return StatusCode(StatusCodes.Status200OK, await _patienceService.Update(id,updatePatientDto));

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }


        }
    }
}
