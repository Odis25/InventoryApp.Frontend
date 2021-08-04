using System.ComponentModel.DataAnnotations;

namespace InventoryApp.Frontend.Models.Employee
{
    public class CreateEmployeeCommand
    {
        [Required(ErrorMessage = "Нужно указать имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Нужно указать фамилию")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Нужно указать отчество")]
        public string Patronymic { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Нужно указать департамент")]
        public int DepartmentId { get; set; }
    }
}
