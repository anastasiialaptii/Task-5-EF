using Ninject.Modules;
using Task5_EF.Managers;
using Task5_EF.Repository;

namespace Task5_EF.NinjectRegistration
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IFlowerRepository>().To<FlowerManager>();
        }
    }
}