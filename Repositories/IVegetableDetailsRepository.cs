using FreshVegetableManagementSystem.Models;

namespace FreshVegetableManagementSystem.Repositories
{
    public interface IVegetableDetailsRepository
    {
        public Task<List<VegetableDetails>> GetAllVegetableDetails();

        public Task<VegetableDetails> GetVegetableDetailsById(int id);

        public Task DeleteVegetableDetailsById(int id);

        public Task AddVegetableDetails(VegetableDetails vegetableDetails);

        public Task UpdateVegetableDetails(VegetableDetails vegetableDetails);
    }
}
