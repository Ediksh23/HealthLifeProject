﻿using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 
namespace HealthLifeProject.Entities { 
    public class FundraisingStatuses
    {
        public int Id { set; get; }
        public string NameFundraisingStatus { set; get; }
        public string Desc { set; get; }
        public List<Patients> Patients { set; get; }
    }
}
