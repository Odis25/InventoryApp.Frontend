using System.Collections.Generic;

namespace InventoryApp.Frontend.Models.Checkout
{
    public class CheckinCableCommand
    {
        public CheckinCableCommand()
        {
            CablesId = new List<int>();
        }
        public IList<int> CablesId { get; set; }
        public int EmployeeId { get; set; }
    }
}
