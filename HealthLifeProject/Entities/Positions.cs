using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace HealthLifeProject.Entities { 
    public class Positions
    {
        public int Id { set; get; }
        public string NamePositions { set; get; }
        public string Desc { set; get; }
        public List<HospitalsRepresentatives> HospitalsRepresentatives { set; get; }
    }
}