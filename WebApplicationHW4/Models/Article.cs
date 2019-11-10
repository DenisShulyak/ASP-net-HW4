using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationHW4
{
    public class Article
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string PathImg { get; set; }
        public string Description { get; set; }
    }
}