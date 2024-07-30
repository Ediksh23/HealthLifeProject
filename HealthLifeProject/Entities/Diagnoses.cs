using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 

namespace HealthLifeProject.Entities { 
public class Diagnoses
    { 
        public int Id { set; get; }
        public string NameDiagnosis { set; get; }
        public string Desc { set; get; }
        public List<Patients> Patients { set; get; }
    }
}
