using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SalesApiRecode.Models
{
    [Index("Email", IsUnique = true)]
    public class Employee
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string FirstName { get; set; } = string.Empty;
        [StringLength(30)]
        public string LastName { get; set; } = string.Empty;
        [StringLength(50)]
        public string Email { get; set; } = string.Empty;
        [StringLength(30)]
        public string Password { get; set; } = string.Empty;
        public bool Active { get; set; } = true;
    }
}
