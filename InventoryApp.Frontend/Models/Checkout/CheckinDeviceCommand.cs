using System.Collections.Generic;

namespace InventoryApp.Frontend.Models.Checkout
{
    public class CheckinDeviceCommand
    {
        public CheckinDeviceCommand()
        {
            DevicesId = new List<int>();
        }
        public IList<int> DevicesId { get; set; }
        public int EmployeeId { get; set; }
    }
}
