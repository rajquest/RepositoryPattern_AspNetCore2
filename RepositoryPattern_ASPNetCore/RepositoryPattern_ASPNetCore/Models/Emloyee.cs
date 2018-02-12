using System;
using System.Collections.Generic;

namespace RepositoryPattern_ASPNetCore.Models
{
    public partial class Emloyee
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? HireDate { get; set; }
        public string Title { get; set; }
        public bool? VoidId { get; set; }
    }
}
