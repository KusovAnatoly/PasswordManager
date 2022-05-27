using System;
using System.Collections.Generic;

namespace PasswordManager.Core.Models
{
    public partial class Service
    {
        public Service()
        {
            ServicePasswords = new HashSet<ServicePassword>();
        }

        public Guid ServiceId { get; set; }
        public string Name { get; set; } = null!;
        public string Url { get; set; } = null!;
        public bool IsDeleted { get; set; }

        public virtual ICollection<ServicePassword> ServicePasswords { get; set; }
    }
}
