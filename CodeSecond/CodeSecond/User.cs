namespace CodeSecond
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        public Guid Id { get; set; }

        public string Login { get; set; }

        public string password { get; set; }

        public DateTime? CreationDate { get; set; }
    }
}
