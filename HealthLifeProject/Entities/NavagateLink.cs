using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Entities
{
    public class NavagateLink
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Href { get; set; }

        public int Order { get; set; }

        public int? ParentId { get; set; } = null;

        public ICollection<NavagateLink> Childs { get; set; }
    }
}
