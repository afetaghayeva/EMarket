using Ninject;
using Ninject.Modules;

namespace Core.Business.DependencyResolvers.Ninject
{
    public class InstanceFactory
    {
        public static T GetInstance<T>(NinjectModule module)
        {
            var kernel=new StandardKernel(module);
            return kernel.Get<T>();
        }
    }
}
