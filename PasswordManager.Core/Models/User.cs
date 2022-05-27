using System;
using System.Collections.Generic;

namespace PasswordManager.Core.Models
{
    public partial class User
    {
        public User()
        {
            ServicePasswords = new HashSet<ServicePassword>();
        }

        public Guid UserId { get; set; }
        public string Login { get; set; } = null!;
        public byte[]? SaltedHash { get; set; }
        public byte[]? Salt { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime Birthdate { get; set; }
        public string Email { get; set; } = null!;
        public bool IsDeleted { get; set; }

        public virtual ICollection<ServicePassword> ServicePasswords { get; set; }
    }
}
