using System;
using System.Collections.Generic;

namespace HealthLifeProject.Entities
{
    public class Events
    {
        public int Id { set; get; }
        public string NameEvent { set; get; }
        public DateTime EventDate { set; get; }
        public string Desc { set; get; }
        public List<Partners> Partners { set; get; }
    }
}
