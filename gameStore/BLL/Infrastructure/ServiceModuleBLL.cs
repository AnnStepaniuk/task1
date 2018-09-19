using Autofac;

namespace Store.BLL.Infrastructure
{
    public class ServiceModuleBLL : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new ServiceModuleDAL());
            
        }
    }
}
