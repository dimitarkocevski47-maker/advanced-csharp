using System;
using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Base;

namespace TaxiManager9000.Domain.Models
{
    public class User : BaseEntity
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public Role Role { get; set; }
    }
}
