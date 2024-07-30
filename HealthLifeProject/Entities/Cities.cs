using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 
namespace HealthLifeProject.Entities {
    public class Cities
    {
        public int Id { set; get; }
        public string NameCity { set; get; }
        public string Desc { set; get; }
        public List<Patients> Patients { set; get; }
        public List<Hospitals> Hospitals { set; get; }
        public List<Wards> Wards { set; get; }
    }
}
