using System;
using System.Collections.Generic;

namespace NWindApplication.Models;

public partial class Patient
{
    public int Patientno { get; set; }

    public string Name { get; set; } = null!;

    public string City { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public decimal PhoneNumber { get; set; }
}
