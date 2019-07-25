using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using MyAbp.EntityFramework;

namespace MyAbp.Migrator
{
    [DependsOn(typeof(MyAbpDataModule))]
    public class MyAbpMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MyAbpDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}