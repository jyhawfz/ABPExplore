using System.Linq;
using MyAbp.EntityFramework;
using MyAbp.MultiTenancy;

namespace MyAbp.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly MyAbpDbContext _context;

        public DefaultTenantCreator(MyAbpDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
