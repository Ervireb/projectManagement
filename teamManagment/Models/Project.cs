using System.ComponentModel.DataAnnotations;

namespace teamManagment.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Owner { get; set; }
        public string? Members { get; set; }
        [DataType(DataType.Date)]
        public DateTime Start { get; set; }
        [DataType(DataType.Date)]
        public DateTime Deadline { get; set; }
        public decimal Budget { get; set; }
        public decimal CostPerHour { get; set; }
    }
}
