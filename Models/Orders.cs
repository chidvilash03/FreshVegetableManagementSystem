using System.ComponentModel.DataAnnotations;

namespace FreshVegetableManagementSystem.Models
{
    public class Orders
    {
        [Key]public int Id { get; set; } 

        public string CustomerName { get; set; }

        public string Location { get; set; }

        public List<int> VegetableIds {  get; set; }

        public int InventoryId {  get; set; }
    }
}
