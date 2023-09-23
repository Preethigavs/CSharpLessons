
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcEFApp.Models
{
    public class Appointment
    {
        [Key]
        [Column("appointmentno")]
        public int Id { get; set; }
        [Required]
        public int Patient { get; set; }
        [Required]
        public string DoctorId { get; set; }
        [Required]
        public DateTime DateofAppointment { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
