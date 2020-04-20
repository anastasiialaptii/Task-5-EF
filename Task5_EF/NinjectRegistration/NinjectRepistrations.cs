using Ninject.Modules;
using Task5_EF.Interfaces;
using Task5_EF.Repositories;

namespace Task5_EF.NinjectRegistration
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>();
        }
    }
}