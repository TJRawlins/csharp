using System.ComponentModel.DataAnnotations;

namespace WebApiExample.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Email { get; set; } = string.Empty;
        [StringLength(30)]
        public string Password { get; set; } = string.Empty;
        public bool Active { get; set; } = true;

    }
}
