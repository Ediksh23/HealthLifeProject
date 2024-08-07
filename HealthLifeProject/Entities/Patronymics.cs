using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace HealthLifeProject.Entities { 
    public class Patronymics
    { 
        public int Id { set; get; }
        public string Patronymic { set; get; }
        public string Desc { set; get; }
        public List<Patients> Patients { set; get; }
        public List<HospitalsRepresentatives> HospitalsRepresentatives { set; get; }
    }
}