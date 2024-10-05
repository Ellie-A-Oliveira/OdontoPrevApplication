using Microsoft.EntityFrameworkCore;

namespace OdontoPrevApplication.Infrastructure.Data.AppData
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        
    }
}
