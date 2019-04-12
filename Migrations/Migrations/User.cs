using System;

namespace Migrations
{
    public class User
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string password { get; set; }
        public DateTime? CreationDate { get; set; }

        public User()
        {
            Id = Guid.NewGuid();
        }
    }
}
