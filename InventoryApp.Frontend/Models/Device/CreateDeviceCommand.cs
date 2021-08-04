using System.ComponentModel.DataAnnotations;

namespace InventoryApp.Frontend.Models.Device
{
    public class CreateDeviceCommand
    {
        public int? Year { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Нужно выбрать тип оборудования")]
        public int TypeId { get; set; }
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
