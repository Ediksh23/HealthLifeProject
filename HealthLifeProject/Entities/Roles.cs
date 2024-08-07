using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace HealthLifeProject.Entities { 
    public class Roles
    {
        public int Id { set; get; }
        public string NameRole { set; get; }
        public string Desc { set; get; }
        public List<Benefactors> Benefactors { set; get; }
        public List<HospitalsRepresentatives> HospitalsRepresentatives { set; get; }
    }
}