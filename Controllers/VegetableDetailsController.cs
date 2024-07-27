using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FreshVegetableManagementSystem.Data;
using FreshVegetableManagementSystem.Models;
using FreshVegetableManagementSystem.Repositories;

namespace FreshVegetableManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VegetableDetailsController : ControllerBase
    {
        public readonly IVegetableDetailsRepository _vegetableDetailsRepository;

        public VegetableDetailsController(IVegetableDetailsRepository vegetableDetailsRepository)
        {
            _vegetableDetailsRepository = vegetableDetailsRepository;
        }

        // GET: api/VegetableDetails
        [HttpGet]
        [Route("GetAllVegetableDetails")]
        public async Task<ActionResult<IEnumerable<VegetableDetails>>> GetVegetableDetails()
        {
            var vegetableDetails = await _vegetableDetailsRepository.GetAllVegetableDetails();
            if (vegetableDetails == null)
            {
                return NotFound();
            }
            return vegetableDetails;
        }

        // GET: api/VegetableDetails/5
        [HttpGet("getVegetableDetailsBy{id}")]
        public async Task<ActionResult<VegetableDetails>> GetVegetableDetails(int id)
        {
            var vegetableDetails = await _vegetableDetailsRepository.GetVegetableDetailsById(id);

            if (vegetableDetails == null)
            {
                return NotFound();
            }

            return vegetableDetails;
        }

        // PUT: api/VegetableDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("updateVegetableDetails{id}")]
        public async Task<IActionResult> PutVegetableDetails(int id, VegetableDetails vegetableDetails)
        {
            await _vegetableDetailsRepository.UpdateVegetableDetails(vegetableDetails);
            return Ok();
        }

        // POST: api/VegetableDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Route("addVegetableDetails")]
        public async Task<ActionResult<VegetableDetails>> PostVegetableDetails(VegetableDetails vegetableDetails)
        {
            await _vegetableDetailsRepository.AddVegetableDetails(vegetableDetails);
            return CreatedAtAction("GetVegetableDetails", new { id = vegetableDetails.Id }, vegetableDetails);
        }

        // DELETE: api/VegetableDetails/5
        [HttpDelete("removeVegetableDetailsBy{id}")]
        public async Task<IActionResult> DeleteVegetableDetails(int id)
        {
            var vegetableDetails = await _vegetableDetailsRepository.GetVegetableDetailsById(id);
            if (vegetableDetails == null)
            {
                return NotFound();
            }

            await _vegetableDetailsRepository.DeleteVegetableDetailsById(id);

            return NoContent();
        }
    }
}
