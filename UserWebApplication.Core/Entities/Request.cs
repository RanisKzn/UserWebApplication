using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserWebApplication.Core.Entities
{
    public class Request
    { 
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int AuthorId { get; set; }

        public virtual User? Author { get; set; }

        public int RequestCategoryId { get; set; }

        public virtual RequestCategory? RequestCategory { get; set; }
    }
}
