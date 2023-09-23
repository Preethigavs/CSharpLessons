using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcEFApp.Models;

namespace MvcEFApp.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: AppointmentController
        public ActionResult Index()
        {
            List<Appointment> apt = RepositoryAppointment.GetAppointment();
            if (apt != null && apt.Count > 0)
            {
                return View(apt);
            }
            else
            {
                return RedirectToAction("Create");
            }
        }

        // GET: AppointmentController/Details/5
        public ActionResult Details(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("Index");
            }
            Appointment appointment = RepositoryAppointment.GetAppointmentById(id);
            return View(appointment);
        }

        // GET: AppointmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AppointmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Appointment apt)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryAppointment.AddNewAppointment(apt);

                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: AppointmentController/Edit/5
        public ActionResult Edit(int id)
        {
            Appointment apt = RepositoryAppointment.GetAppointmentById(id);
            return View(apt);
        }

        // POST: AppointmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection, Appointment apt)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryAppointment.ModifyAppointment(apt);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AppointmentController/Delete/5
        public ActionResult Delete(int id)
        {
            
            Appointment apt = RepositoryAppointment.GetAppointmentById(id);
            return View(apt);
        }

        // POST: AppointmentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    
                    RepositoryAppointment.RemoveAppointment(id);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
