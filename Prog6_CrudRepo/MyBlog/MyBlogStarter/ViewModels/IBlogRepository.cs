using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogStarter.ViewModels
{
    public interface IBlogRepository
    {
        ObservableCollection<BlogVM> GetAll();
        void Add(BlogVM blog);
        void Delete(BlogVM blog);
    }
}
