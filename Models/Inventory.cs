namespace FreshVegetableManagementSystem.Models
{
    public class Inventory
    {
        public int Id {  get; set; }   

        public string Name { get; set; }

        public int TotalVegetableTypes { get; set; }

        public string Location { get; set; }    

        public List<int> VegetableIds { get; set; }
    }
}
