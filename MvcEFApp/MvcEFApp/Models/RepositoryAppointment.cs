using Microsoft.EntityFrameworkCore;

namespace MvcEFApp.Models
{
    public class RepositoryAppointment
    {
        public static Appointment GetAppointmentById(int id)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            var apt = ctx.Appointments.Find(id);
            return apt;
        }

        public static List<Appointment> GetAppointment()
        {
            HospitalDbContext ctx = new HospitalDbContext();
            var list = ctx.Appointments.ToList();
            return list;
        }
        public static void AddNewAppointment(Appointment appointment)
        {

            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Appointments.Add(appointment);
            ctx.SaveChanges();

        }

        public static void ModifyAppointment(Appointment appointment)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Entry(appointment).State = EntityState.Modified;
            ctx.SaveChanges();
        }
        public static void RemoveAppointment(int id)
        {
            HospitalDbContext cxt = new HospitalDbContext();
            Appointment apt = cxt.Appointments.Find(id);
            cxt.Appointments.Remove(apt);
            cxt.SaveChanges();
        }
    }
}

