
using ExtendedHomeHealthcare.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExtendedHomeHealthcare.Context
{
    public class PatientContext
    {
        public DbSet<Patient> Patients { get; set; }
    }
}