using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryApp.Frontend.Models.Device
{
    public class DeviceDetailsVm
    {
        public int Id { get; set; }
        public int? Year { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string SerialNumber { get; set; }
        public string Description { get; set; }
        public DeviceTypeDto Type { get; set; }

        public string CreatedBy { get; set; }
        public string EditedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EditDate { get; set; }

        public IList<CheckoutDto> Checkouts { get; set; }

        public bool InUse => Checkouts.Any(c => c.CheckedOut == null);
    }
}
