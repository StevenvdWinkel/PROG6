using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogStarter.ViewModels
{
    class DummyBlogRepository : IBlogRepository
    {
        private ObservableCollection<BlogVM> blogs;
        
        public DummyBlogRepository()
        {
            blogs = new ObservableCollection<BlogVM>();

            blogs.Add(new BlogVM()
            {
                Title = "A WPF Tutorial",
                Author = "Stijn Smulders",
                TimeStamp = DateTime.Now
            });

            blogs.Add(new BlogVM()
            {
                Title = "A DI Tutorial",
                Author = "Stijn Smulders",
                TimeStamp = DateTime.Now
            });

            blogs.Add(new BlogVM()
            {
                Title = "A Dog Tutorial",
                Author = "Steven van de Winkel",
                TimeStamp = DateTime.Now
            });
        }

        public void Add(BlogVM blog)
        {
            blogs.Add(blog);
        }

        public void Delete(BlogVM blog)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<BlogVM> GetAll()
        {
            return blogs;
        }
    }
}
