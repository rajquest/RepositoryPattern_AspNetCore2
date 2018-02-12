
using Microsoft.EntityFrameworkCore;

namespace RepositoryPattern_ASPNetCore.Models
{
    public partial class DevDBContext : DbContext
    {
        public DevDBContext(DbContextOptions<DevDBContext> options) : base(options)
        {

        }
    }
}
