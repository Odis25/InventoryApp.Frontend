using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryApp.Frontend.Models.Cable
{
    public class CableDetailsVm
    {
        public int Id { get; set; }
        public int Length { get; set; }
        public string Name { get; set; }
        public string Mark { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public string EditedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EditDate { get; set; }

        public IList<CheckoutDto> Checkouts { get; set; }

        public bool InUse => Checkouts.Any(c => c.CheckedOut == null);
    }
}
