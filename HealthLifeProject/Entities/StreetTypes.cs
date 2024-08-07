using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace HealthLifeProject.Entities { 
    public class StreetTypes
    {
        public int Id { set; get; }
        public string NameStreetTypes { set; get; }
        public string Desc { set; get; }
        public List<Streets> Streets { set; get; }
    }
}
