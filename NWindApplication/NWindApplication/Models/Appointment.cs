using System;
using System.Collections.Generic;

namespace NWindApplication.Models;

public partial class Appointment
{
    public int Appointmentno { get; set; }

    public int Patient { get; set; }

    public string DoctorId { get; set; } = null!;

    public DateTime DateofAppointment { get; set; }

    public bool Status { get; set; }
}
