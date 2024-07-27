using FreshVegetableManagementSystem.Data;
using FreshVegetableManagementSystem.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace FreshVegetableManagementSystem.Repositories
{
    public class VegetableDetailsRepository : IVegetableDetailsRepository
    {
        public readonly FreshVegetableManagementSystemContext _context;

        public VegetableDetailsRepository(FreshVegetableManagementSystemContext context)
        {
            _context = context;
        }

        public async Task AddVegetableDetails(VegetableDetails vegetableDetails)
        {
            await _context.VegetableDetails.AddAsync(vegetableDetails);
            await _context.SaveChangesAsync();
        }


        public async Task DeleteVegetableDetailsById(int id)
        {
            var vegetableDetails = await _context.VegetableDetails.FindAsync(id);
            if (vegetableDetails != null)
            {
                _context.VegetableDetails.Remove(vegetableDetails);
                await _context.SaveChangesAsync();
                return;
            }
        }

        public async Task<List<VegetableDetails>> GetAllVegetableDetails()
        {
            var vegetableDetails = await  _context.VegetableDetails.ToListAsync();
            return vegetableDetails;
        }

        public async Task<VegetableDetails> GetVegetableDetailsById(int id)
        {
            var vegetableDetails = await _context.VegetableDetails.FindAsync(id);
            return vegetableDetails;
        }

        public async Task UpdateVegetableDetails(VegetableDetails vegetableDetails)
        {
            _context.Entry(vegetableDetails).State = EntityState.Modified;
            await _context.SaveChangesAsync();  
        }
    }
}
