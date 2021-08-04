namespace InventoryApp.Frontend.Models.Employee
{
    public class UpdateEmployeeCommand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DepartmentDto Department { get; set; }
    }
}
