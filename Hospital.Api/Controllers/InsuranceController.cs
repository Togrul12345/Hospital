using Hospital.Bl.Dtos.InsuranceDtos;
using Hospital.Bl.Dtos.PatientDtos;
using Hospital.Bl.Exceptions;
using Hospital.Bl.Services.Abstraction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsuranceController : ControllerBase
    {
        private readonly IInsuranceService _patienceService;

        public InsuranceController(IInsuranceService patienceService)
        {
            _patienceService = patienceService;
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateInsuranceDto createInsuranceDto)
        {
            if (!ModelState.IsValid)
            {
                throw new ModelStateException();
            }
            try
            {
                return StatusCode(StatusCodes.Status200OK, await _patienceService.CreateAsync(createInsuranceDto));

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
        public async Task<IActionResult> Update(int id, UpdateInsuranceDto updateInsuranceDto)
        {

            try
            {
                return StatusCode(StatusCodes.Status200OK, await _patienceService.Update(id, updateInsuranceDto));

            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }


        }
    }
}
