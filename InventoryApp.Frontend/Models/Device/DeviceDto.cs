namespace InventoryApp.Frontend.Models.Device
{
    public class DeviceDto
    {
        public int Id { get; set; }
        public int? Year { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Type { get; set; }
        public EmployeeDto CurrentUser { get; set; }
    }
}
