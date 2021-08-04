using System.ComponentModel.DataAnnotations;

namespace InventoryApp.Frontend.Models.Cable
{
    public class CreateCableCommand
    {
        [Range(1, int.MaxValue, ErrorMessage = "Длина кабеля не может быть меньше 1 метра")]
        public int Length { get; set; }
        [Required(ErrorMessage = "Нужно указать обозначение кабеля")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Нужно указать марку кабеля")]
        public string Mark { get; set; }
        [Required(ErrorMessage = "Нужно указать кол-во жил и сечение кабеля")]
        public string Type { get; set; }
        public string Description { get; set; }
    }
}
