using System;

namespace InventoryApp.Frontend.Models.Employee
{
    public class CheckoutDeviceDto
    {
        public long Id { get; set; }
        public DeviceDto Device { get; set; }
        public DateTime CheckedIn { get; set; }
        public DateTime? CheckedOut { get; set; }
    }
}