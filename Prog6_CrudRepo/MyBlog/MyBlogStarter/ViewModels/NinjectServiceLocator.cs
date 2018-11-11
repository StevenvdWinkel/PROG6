using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogStarter.ViewModels
{
    public class NinjectServiceLocator
    {
        public NinjectServiceLocator()
        {
            ///Iets met een kernel?
        }

        public MainViewModel Main
        {
            get
            {
                //Dit kan natuurlijk een stuk beter
                return new MainViewModel();
            }
        }
    }
}
