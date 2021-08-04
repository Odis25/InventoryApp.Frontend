namespace InventoryApp.Frontend.Models.Cable
{
    public class CableDto
    {
        public int Id { get; set; }
        public int Length { get; set; }
        public string Name { get; set; }
        public string Mark { get; set; }
        public string Type { get; set; }
        public EmployeeDto CurrentUser { get; set; }
    }
}
