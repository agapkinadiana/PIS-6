using Ninject.Modules;
using Ninject.Web.Common;

using AbstractPhoneDataProvider;

namespace Lab_3_MVC.Utils
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IPhoneDictionary>().To<JSONDataProvider.PersonRepository>().InTransientScope();
        }
    }
}
