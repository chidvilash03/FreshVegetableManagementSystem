using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreshVegetableManagementSystem.Models
{
    public class VegetableDetails
    {
        [Key]public int Id {  get; set; }

        public string Name { get; set; }

        public int Quantity {  get; set; }

        public double CostPerKg {  get; set; }   

        public DateOnly ExpiryDate {  get; set; }


    }
}
