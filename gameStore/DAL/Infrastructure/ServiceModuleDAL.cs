using Autofac;
using Store.DAL.Interfaces;
using Store.DAL.Repositories;

namespace Store.BLL.Infrastructure
{
    public class ServiceModuleDAL: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
        }
    }
}
