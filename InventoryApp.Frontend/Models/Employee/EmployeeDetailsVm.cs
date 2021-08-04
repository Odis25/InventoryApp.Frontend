using System.Collections.Generic;

namespace InventoryApp.Frontend.Models.Employee
{
    public class EmployeeDetailsVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DepartmentDto Department { get; set; }

        public IList<CheckoutDeviceDto> DeviceCheckouts { get; set; }
        public IList<CheckoutCableDto> CableCheckouts { get; set; }
    }
}
