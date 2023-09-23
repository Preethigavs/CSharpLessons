using System;
using System.Collections.Generic;

namespace NWindApplication.Models;

public partial class Doctor
{
    public int Doctorno { get; set; }

    public string Name { get; set; } = null!;

    public string Speciality { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public decimal VisitingFees { get; set; }

    public decimal PhoneNumber { get; set; }
}
