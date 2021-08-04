using System;

namespace InventoryApp.Frontend.Models.Employee
{
    public class CheckoutCableDto
    {
        public long Id { get; set; }
        public CableDto Cable { get; set; }
        public DateTime CheckedIn { get; set; }
        public DateTime? CheckedOut { get; set; }
    }
}