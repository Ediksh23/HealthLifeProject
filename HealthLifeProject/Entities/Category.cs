using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 
namespace HealthLifeProject.Entities 
{ 
    public class Category
    {
          public int Id { set; get; }
          public string NameCategory { set; get; }
          public string Desc { set; get; }
          public List<Patients> Patients { set; get; }
    }
}
