using System.Collections.Generic;

namespace InventoryApp.Frontend.Models.Employee
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Department { get; set; }
        public string FullName { get; set; }
        public IEnumerable<DeviceDto> Devices { get; set; }
        public IEnumerable<CableDto> Cables { get; set; }
    }
}
