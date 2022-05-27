using System;
using System.Collections.Generic;

namespace PasswordManager.Core.Models
{
    public partial class ServicePassword
    {
        public Guid ServicePasswordId { get; set; }
        public Guid ServiceId { get; set; }
        public Guid UserId { get; set; }
        public string Password { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string? Note { get; set; }

        public virtual Service Service { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
