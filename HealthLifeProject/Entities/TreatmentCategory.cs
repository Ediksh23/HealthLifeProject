using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 
namespace HealthLifeProject.Entities 
{ 
    public class TreatmentCategory
    {
          public int Id { set; get; }
          public string NameTreatmentCategory { set; get; }
          public string Desc { set; get; }
          public List<Patients> Patients { set; get; }
    }
}
