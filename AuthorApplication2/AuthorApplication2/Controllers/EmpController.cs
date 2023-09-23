using AuthorApplication2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthorApplication2.Controllers
{
    public class EmpController : Controller
    {
        // GET: EmpController
        public ActionResult Index()
        {
            List<Emptbl> emplist = EmpDBRepository.GetEmpList();
            return View(emplist);
        }

        // GET: EmpController/Details/5
        public ActionResult Details(int id)
        {
            if(id <=0)
            {
                return RedirectToAction("Index");
            }
            Emptbl emp = EmpDBRepository.GetEmpID(id);
            return View(emp);
        }

        // GET: EmpController/Create
        public ActionResult Create()
        {
            Emptbl emp = new Emptbl();
            return View(emp);
        }

        // POST: EmpController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection , Emptbl pEmp)
        {
            try
            {
                if(ModelState.IsValid) //inbuilt property for all controllers
                {
                    EmpDBRepository.AddNewEmp(pEmp);
                    
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpController/Edit/5
        public ActionResult Edit(int id)
        {
            Emptbl emp = EmpDBRepository.GetEmpID(id) ;
            if (id <=0)
            {

                return RedirectToAction("Index") ;
            }
            
            return View(emp);
        }

        // POST: EmpController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection, Emptbl pEmp)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    EmpDBRepository.UpdateEmp(pEmp);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpController/Delete/5
        public ActionResult Delete(int id)
        {

            if (id <= 0)
            {
                return RedirectToAction("Index");
            }

            Emptbl emp = EmpDBRepository.GetEmpID(id) ;
            return View(emp);
        }

        // POST: EmpController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            if (ModelState.IsValid)
            {
                EmpDBRepository.DeleteEmp(id);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
