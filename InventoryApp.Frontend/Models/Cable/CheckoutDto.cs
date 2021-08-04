using System;

namespace InventoryApp.Frontend.Models.Cable
{
    public class CheckoutDto
    {
        public long Id { get; set; }
        public EmployeeDto Employee { get; set; }
        public DateTime CheckedIn { get; set; }
        public DateTime? CheckedOut { get; set; }
    }
}
