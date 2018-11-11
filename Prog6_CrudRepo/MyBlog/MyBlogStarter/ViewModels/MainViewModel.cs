using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogStarter.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<BlogVM> Blogs { get; set; }

        public MainViewModel()
        {
            Blogs = new ObservableCollection<BlogVM>();

            Blogs.Add(new BlogVM()
            {
                Title = "A WPF Tutorial",
                Author = "Stijn Smulders",
                TimeStamp = DateTime.Now
            });

            Blogs.Add(new BlogVM()
            {
                Title = "A DI Tutorial",
                Author = "Stijn Smulders",
                TimeStamp = DateTime.Now
            });
        }
    }
}
