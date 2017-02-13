using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Meeeedium.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string TeaserText { get; set; }
        public string CreatedDate { get; set; }
        public string Body { get; set; }
        public bool Public { get; set; }

        public string AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public virtual ApplicationUser Author { get; set; }
    }
}