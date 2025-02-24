namespace CRUD_Operations.Models.Entities
{
    public class UpdateEmployeeDetails
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public required decimal Salary { get; set; }
    }
}
