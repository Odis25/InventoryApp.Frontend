using System.ComponentModel.DataAnnotations;

namespace InventoryApp.Frontend.Models.Device
{
    public class UpdateDeviceCommand
    {
        public int Id { get; set; }

        public int? Year { get; set; }

        
        public DeviceTypeDto Type { get; set; }

        [Required(ErrorMessage = "Нужно указать название")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Нужно указать модель оборудование")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Нужно указать зав. номер оборудования")]
        public string SerialNumber { get; set; }

        [Required(ErrorMessage = "Нужно указать фирму-производителя")]
        public string Manufacturer { get; set; }

        public string Description { get; set; }
    }
}
