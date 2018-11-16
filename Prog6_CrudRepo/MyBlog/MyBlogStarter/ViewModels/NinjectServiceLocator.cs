using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace MyBlogStarter.ViewModels
{
    public class NinjectServiceLocator
    {
        private StandardKernel _kernel;

        public NinjectServiceLocator()
        {
            _kernel = new StandardKernel();
            _kernel.Bind<MainViewModel>().ToSelf().InSingletonScope();
            _kernel.Bind<IBlogRepository>().To<DummyBlogRepository>();
        }

        public MainViewModel Main
        {
            get
            {
                return _kernel.Get<MainViewModel>();
            }
        }
    }
}
