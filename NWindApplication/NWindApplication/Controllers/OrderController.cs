using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Identity.Client;
using NWindApplication.Models;

namespace NWindApplication.Controllers
{
    public class OrderController : Controller
    {
     
        private RepositoryOrder _repositoryOrder;
		public OrderController(RepositoryOrder orders)
		{
			_repositoryOrder= orders;
		}
		// GET: OrderController
		public ActionResult Index()
		{
			List<int> orderIds = _repositoryOrder.GetAllOrderId();
			OrderIdsListView idsViewModel = new OrderIdsListView(orderIds);
			return View(idsViewModel);
		}
		//{
		//  order.OrderSelectView = new List<SelectListItem>();
		//    foreach (var list in order.Orders())
		//    {
		//        order.OrderSelectView.Add(new SelectListItem(list.OrderId.ToString(), list.OrderId.ToString()));
		//    }

		//    return View(order);
		//}



		// GET: OrderController/Details/5
		[HttpPost]
		public ActionResult Details(int id)
		{
			Order order = _repositoryOrder.FindOrderById(id); //need to have all the details in the db 
			List<OrderDetail> detail = _repositoryOrder.FindOrderDetailByOrderId(id);
			ViewData["OrderDetail"] = detail;
			return View(order);
		}

		//// GET: OrderController/Create
		//public ActionResult Create()
		//{
		//    return View();
		//}



		//// POST: OrderController/Create
		//[HttpPost]
		//[ValidateAntiForgeryToken]
		//public ActionResult Create(IFormCollection collection)
		//{
		//    try
		//    {
		//        return RedirectToAction(nameof(Index));
		//    }
		//    catch
		//    {
		//        return View();
		//    }
		//}



		//// GET: OrderController/Edit/5
		//public ActionResult Edit(int id)
		//{
		//    return View();
		//}



		//// POST: OrderController/Edit/5
		//[HttpPost]
		//[ValidateAntiForgeryToken]
		//public ActionResult Edit(int id, IFormCollection collection)
		//{
		//    try
		//    {
		//        return RedirectToAction(nameof(Index));
		//    }
		//    catch
		//    {
		//        return View();
		//    }
		//}



		//// GET: OrderController/Delete/5
		//public ActionResult Delete(int id)
		//{
		//    return View();
		//}



		//// POST: OrderController/Delete/5
		//[HttpPost]
		//[ValidateAntiForgeryToken]
		//public ActionResult Delete(int id, IFormCollection collection)
		//{
		//    try
		//    {
		//        return RedirectToAction(nameof(Index));
		//    }
		//    catch
		//    {
		//        return View();
		//    }
		//}
	}
}
