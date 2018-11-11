using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogStarter.ViewModels
{
    /// <summary>
    /// Deze klasse moeten we nog refactoren
    /// </summary>
    public class BlogVM
    {
        public int Id { get; set; }

        public String Title { get; set; }

        public String Content { get; set; }

        public DateTime TimeStamp { get; set; }

        public String Author { get; set; }
    }
}
